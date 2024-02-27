using System.Drawing.Imaging;

namespace LinuxLabsChanger
{
    internal class ImageProcessing
    {
        public static Bitmap ProcessImageUsingBitmapFilters(Image image)
        {
            Bitmap bitmap = (Bitmap)image;

            // Применение фильтров к Bitmap
            var processedBitmap = ApplyFiltersToBitmap(bitmap);

            // Возвращение обработанного Bitmap
            return processedBitmap;
        }

        public static Bitmap MedianFiltering(Bitmap bm)
        {
            List<byte> termsList = new List<byte>();

            byte[,] image = new byte[bm.Width, bm.Height];

            //Convert to Grayscale 
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    var c = bm.GetPixel(i, j);
                    byte gray = (byte)(.333 * c.R + .333 * c.G + .333 * c.B);
                    image[i, j] = gray;
                }
            }

            //applying Median Filtering 
            for (int i = 0; i <= bm.Width - 3; i++)
                for (int j = 0; j <= bm.Height - 3; j++)
                {
                    for (int x = i; x <= i + 2; x++)
                        for (int y = j; y <= j + 2; y++) termsList.Add(image[x, y]);
                    byte[] terms = termsList.ToArray();
                    termsList.Clear();
                    Array.Sort(terms);
                    Array.Reverse(terms);
                    byte color = terms[4];
                    bm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                }

            return bm;
        }

        public static Image BinImage(Bitmap image, byte threshold)
        {
            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                {
                    var curColor = image.GetPixel(i, j);
                    var ret = (int)(curColor.R * 0.299 + curColor.G * 0.578 + curColor.B * 0.114);
                    if (ret > threshold) ret = 255; else ret = 0;

                    image.SetPixel(i, j, Color.FromArgb(ret, ret, ret));
                }

            return image;
        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }

        public static Bitmap MakeGrayscale(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                //create the grayscale ColorMatrix
                System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(
                   new float[][]
                   {
                       new float[] {.3f, .3f, .3f, 0, 0},
                       new float[] {.59f, .59f, .59f, 0, 0},
                       new float[] {.11f, .11f, .11f, 0, 0},
                       new float[] {0, 0, 0, 1, 0},
                       new float[] {0, 0, 0, 0, 1}
                   });

                //create some image attributes
                using (ImageAttributes attributes = new ImageAttributes())
                {
                    //set the color matrix attribute
                    attributes.SetColorMatrix(colorMatrix);

                    //draw the original image on the new image
                    //using the grayscale color matrix
                    g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return newBitmap;
        }

        public static Image InvertColors(Image imgSource)
        {
            Bitmap bmpDest = null;

            using (Bitmap bmpSource = new Bitmap(imgSource))
            {
                bmpDest = new Bitmap(bmpSource.Width, bmpSource.Height);

                for (int x = 0; x < bmpSource.Width; x++)
                {
                    for (int y = 0; y < bmpSource.Height; y++)
                    {
                        Color clrPixel = bmpSource.GetPixel(x, y);

                        // Making background one certain color
                        if (clrPixel.R <= 13 && clrPixel.G <= 13 && clrPixel.B <= 13)
                        {
                            clrPixel = Color.FromArgb(0, 0, 0);
                        }

                        clrPixel = Color.FromArgb(255 - clrPixel.R, 255 - clrPixel.G, 255 - clrPixel.B);

                        bmpDest.SetPixel(x, y, clrPixel);
                    }
                }
            }

            return bmpDest;
        }

        private static Bitmap ApplyFiltersToBitmap(Bitmap bitmap)
        {
            var bitmap2 = MakeGrayscale(bitmap);
            bitmap2.SetResolution(300, 300);
            Image img = bitmap2;
            img = InvertColors(img);
            img = ResizeImage(img, new Size(img.Size.Width * 5, img.Size.Height * 5));
            img = MedianFiltering((Bitmap)img);
            img = BinImage((Bitmap)img, 180);

            return (Bitmap)img;
        }
    }
}