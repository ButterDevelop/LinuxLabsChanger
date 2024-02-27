namespace LinuxLabsChanger
{
    public partial class MainForm : Form
    {
        private PictureBox _chosenPictureBox;

        public MainForm()
        {
            InitializeComponent();

            _chosenPictureBox = pictureBoxScreenshotToModify;

            pictureBoxScreenshotToModify.GotFocus += PictureBox_GotFocus;
            pictureBoxScreenshotToPaste.GotFocus  += PictureBox_GotFocus;
            pictureBoxScreenshotToModify.Click    += PictureBox_GotFocus;
            pictureBoxScreenshotToPaste.Click     += PictureBox_GotFocus;
        }

        private void PictureBox_GotFocus(object? sender, EventArgs e)
        {
            pictureBoxScreenshotToModify.SuspendLayout();
            pictureBoxScreenshotToPaste.SuspendLayout();

            pictureBoxScreenshotToModify.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxScreenshotToPaste.BorderStyle = BorderStyle.FixedSingle;

            if (sender == null) return;
            _chosenPictureBox = (PictureBox)sender;
            _chosenPictureBox.BorderStyle = BorderStyle.Fixed3D;

            pictureBoxScreenshotToModify.ResumeLayout();
            pictureBoxScreenshotToPaste.ResumeLayout();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Проверяем, нажата ли комбинация Ctrl + V
            if (keyData == (Keys.Control | Keys.V))
            {
                PasteImageFromClipboard();
                return true; // Возвращаем true, указывая, что комбинация обработана
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PasteImageFromClipboard()
        {
            if (Clipboard.ContainsImage())
            {
                Image image = Clipboard.GetImage();
                if (_chosenPictureBox != null) _chosenPictureBox.Image = image; // Устанавливаем изображение в PictureBox
            }
            else
            {
                MessageBox.Show("There is no image in your clipboard.", "Linux Labs Changer: Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBoxResult_Click(object sender, EventArgs e)
        {
            if (pictureBoxResult.Image == null) return;
            Clipboard.SetImage(pictureBoxResult.Image);
            MessageBox.Show("The result copied successfully.", "Linux Labs Changer: Copied.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (pictureBoxScreenshotToModify.Image == null || pictureBoxScreenshotToPaste.Image == null)
            {
                MessageBox.Show("It looks like we have no image somewhere.", "Linux Labs Changer: Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = Work.Process(pictureBoxScreenshotToModify.Image, pictureBoxScreenshotToPaste.Image, textBoxTextKeyword.Text);
            pictureBoxResult.Image = result;

            MessageBox.Show("Work is done!", "Linux Labs Changer: Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
