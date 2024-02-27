using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Numerics;
using Tesseract;

namespace LinuxLabsChanger
{
    internal enum MyColor
    {
        Green = 0,
        Blue  = 1,
        Gray  = 2
    }
    internal struct InsertionData
    {
        public SixLabors.ImageSharp.Point Location;
        public SixLabors.ImageSharp.Size Size;
    }
    internal class Work
    {
        public static System.Drawing.Image Process(System.Drawing.Image mainImageSrc, System.Drawing.Image insertImageSrc, string keywordToFind)
        {
            using (Image<Rgba32> mainImage   = ConvertSystemDrawingImageToImageSharpImage(mainImageSrc))
            using (Image<Rgba32> insertImage = ConvertSystemDrawingImageToImageSharpImage(insertImageSrc))
            {
                var insertions = new List<InsertionData>();

                // Начальные и конечные точки области с зеленым цветом
                int minX = mainImage.Width, minY = mainImage.Height, maxX = 0, maxY = 0;

                // Поиск зелёных пикселей
                bool globalFoundGreen = false;
                for (int y = 0; y < mainImage.Height; y++)
                {
                    bool foundLocalGreenColor = false;
                    int notGreenInARowCounter = 0;
                    for (int x = 0; x < mainImage.Width; x++)
                    {
                        Rgba32 pixel = mainImage[x, y];
                        if (IsColor(pixel, MyColor.Green))
                        {
                            notGreenInARowCounter = 0;
                            globalFoundGreen      = true;
                            foundLocalGreenColor  = true;
                            if (x < minX) minX = x;
                            if (x > maxX) maxX = x;
                            if (y < minY) minY = y;
                            if (y > maxY) maxY = y;
                        }
                        else
                        {
                            ++notGreenInARowCounter;
                        }

                        if (!foundLocalGreenColor && maxX != 0 && notGreenInARowCounter >= maxX) break;
                    }
                    if (globalFoundGreen && !foundLocalGreenColor)
                    {
                        if (minX < maxX && minY < maxY)
                        {
                            var rectangle = new SixLabors.ImageSharp.Rectangle(minX, minY, maxX - minX + 1, maxY - minY + 1);
                            string text = RecognizeTextFromSpecificArea(mainImage, rectangle);
                            if (text.ToLower().Contains(keywordToFind))
                            {
                                insertions.Add(new InsertionData
                                {
                                    Location = new SixLabors.ImageSharp.Point(minX, minY),
                                    Size     = new SixLabors.ImageSharp.Size(rectangle.Width, rectangle.Height)
                                });
                            }
                        }
                    }

                    if (!foundLocalGreenColor)
                    {
                        minX = mainImage.Width;
                        minY = mainImage.Height;
                        maxX = 0;
                        maxY = 0;

                        globalFoundGreen = false;
                    }
                }

                foreach (var insertion in insertions)
                {
                    // Изменение размера изображения для вставки
                    insertImage.Mutate(x => x.Resize(insertion.Size));

                    // Изменение размера и вставка изображения осуществляются здесь
                    mainImage.Mutate(x => x.DrawImage(insertImage, insertion.Location, 1f));
                }

                return ConvertImageSharpImageToSystemDrawingImage(mainImage);
            }
        }


        private static bool IsColor(Rgba32 pixel, MyColor color)
        {
            // Преобразование Rgba32 в Hsv
            var hsv = pixel.ToVector4();
            var hue = Rgba32ToHue(hsv);

            if (color == MyColor.Green)
            {
                // Считаем пиксель зелёным, если его оттенок находится в пределах от 100 до 140 градусов
                return hue >= 100 && hue <= 140 && pixel.G >= 40;
            }
            else
            if (color == MyColor.Blue)
            {
                return hue >= 200 && hue <= 240;
            }
            else
            if (color == MyColor.Gray)
            {
                return pixel.R == 204 && pixel.G == 204 && pixel.B == 204;
            }

            return false;
        }
        private static float Rgba32ToHue(Vector4 rgba)
        {
            float r = rgba.X;
            float g = rgba.Y;
            float b = rgba.Z;

            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));
            float delta = max - min;

            if (delta == 0)
            {
                return 0; // H is undefined
            }

            float hue;
            if (max == r)
            {
                hue = (g - b) / delta;
            }
            else if (max == g)
            {
                hue = 2 + (b - r) / delta;
            }
            else
            {
                hue = 4 + (r - g) / delta;
            }

            hue *= 60;
            if (hue < 0)
            {
                hue += 360;
            }

            return hue;
        }

        public static Image<Rgba32> PreprocessImageForOCR(Image<Rgba32> image)
        {
            return ConvertSystemDrawingImageToImageSharpImage(
                       ImageProcessing.ProcessImageUsingBitmapFilters(
                           ConvertImageSharpImageToSystemDrawingImage(image)
                       )
                   );
        }

        public static string RecognizeTextFromSpecificArea(Image<Rgba32> image, SixLabors.ImageSharp.Rectangle area)
        {
            // Обрезка изображения до указанной области
            Image<Rgba32> croppedImage = image.Clone(x => x.Crop(area));

            var preprocessedImage = PreprocessImageForOCR(croppedImage);

            // Сохранение обрезанного изображения в поток в формате PNG
            using (var ms = new MemoryStream())
            {
                preprocessedImage.SaveAsPng(ms);
                ms.Position = 0;

                // Инициализация Tesseract
                using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                {
                    // Загрузка изображения в Tesseract
                    using (var img = Pix.LoadFromMemory(ms.ToArray()))
                    {
                        using (var page = engine.Process(img))
                        {
                            // Возвращаем распознанный текст
                            return page.GetText();
                        }
                    }
                }
            }
        }

        public static System.Drawing.Image ConvertImageSharpImageToSystemDrawingImage(Image<Rgba32> imageSharpImage)
        {
            using (var memoryStream = new MemoryStream())
            {
                // Сохраняем изображение ImageSharp в поток в формате PNG
                imageSharpImage.SaveAsPng(memoryStream);
                memoryStream.Position = 0; // Сбрасываем позицию потока на начало

                // Загружаем изображение из потока с использованием System.Drawing
                return System.Drawing.Image.FromStream(memoryStream);
            }
        }
        public static Image<Rgba32> ConvertSystemDrawingImageToImageSharpImage(System.Drawing.Image systemDrawingImage)
        {
            using (var memoryStream = new MemoryStream())
            {
                // Сохраняем изображение System.Drawing в поток в формате PNG
                systemDrawingImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                memoryStream.Position = 0; // Сбрасываем позицию потока на начало

                // Загружаем изображение из потока с использованием ImageSharp
                return SixLabors.ImageSharp.Image.Load<Rgba32>(memoryStream);
            }
        }
    }
}
