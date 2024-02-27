namespace LinuxLabsChanger
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel = new TableLayoutPanel();
            labelTextToFindKeyword = new Label();
            pictureBoxResult = new PictureBox();
            labelResult = new Label();
            labelSecondPictureBox = new Label();
            pictureBoxScreenshotToPaste = new PictureBox();
            labelFirstPictureBox = new Label();
            labelCtrlV = new Label();
            pictureBoxScreenshotToModify = new PictureBox();
            buttonStart = new Button();
            textBoxTextKeyword = new TextBox();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxScreenshotToPaste).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxScreenshotToModify).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 10;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.Controls.Add(labelTextToFindKeyword, 0, 13);
            tableLayoutPanel.Controls.Add(pictureBoxResult, 0, 10);
            tableLayoutPanel.Controls.Add(labelResult, 0, 9);
            tableLayoutPanel.Controls.Add(labelSecondPictureBox, 0, 6);
            tableLayoutPanel.Controls.Add(pictureBoxScreenshotToPaste, 0, 8);
            tableLayoutPanel.Controls.Add(labelFirstPictureBox, 0, 2);
            tableLayoutPanel.Controls.Add(labelCtrlV, 0, 0);
            tableLayoutPanel.Controls.Add(pictureBoxScreenshotToModify, 0, 3);
            tableLayoutPanel.Controls.Add(buttonStart, 4, 14);
            tableLayoutPanel.Controls.Add(textBoxTextKeyword, 7, 13);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 15;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.Size = new Size(864, 744);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelTextToFindKeyword
            // 
            labelTextToFindKeyword.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(labelTextToFindKeyword, 7);
            labelTextToFindKeyword.Dock = DockStyle.Fill;
            labelTextToFindKeyword.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextToFindKeyword.Location = new Point(3, 637);
            labelTextToFindKeyword.Name = "labelTextToFindKeyword";
            labelTextToFindKeyword.Size = new Size(596, 49);
            labelTextToFindKeyword.TabIndex = 8;
            labelTextToFindKeyword.Text = "Neural network find fragment of text - nickname will be replaced:";
            labelTextToFindKeyword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxResult
            // 
            pictureBoxResult.BackColor = SystemColors.ButtonHighlight;
            pictureBoxResult.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel.SetColumnSpan(pictureBoxResult, 10);
            pictureBoxResult.Dock = DockStyle.Fill;
            pictureBoxResult.Location = new Point(3, 494);
            pictureBoxResult.Margin = new Padding(3, 4, 3, 4);
            pictureBoxResult.Name = "pictureBoxResult";
            tableLayoutPanel.SetRowSpan(pictureBoxResult, 3);
            pictureBoxResult.Size = new Size(858, 139);
            pictureBoxResult.TabIndex = 7;
            pictureBoxResult.TabStop = false;
            pictureBoxResult.Click += pictureBoxResult_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(labelResult, 10);
            labelResult.Dock = DockStyle.Fill;
            labelResult.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelResult.Location = new Point(3, 441);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(858, 49);
            labelResult.TabIndex = 6;
            labelResult.Text = "This is the result (click to copy):";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSecondPictureBox
            // 
            labelSecondPictureBox.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(labelSecondPictureBox, 10);
            labelSecondPictureBox.Dock = DockStyle.Fill;
            labelSecondPictureBox.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSecondPictureBox.Location = new Point(3, 343);
            labelSecondPictureBox.Name = "labelSecondPictureBox";
            labelSecondPictureBox.Size = new Size(858, 49);
            labelSecondPictureBox.TabIndex = 4;
            labelSecondPictureBox.Text = "This is for image to paste on the first screenshot:";
            labelSecondPictureBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxScreenshotToPaste
            // 
            pictureBoxScreenshotToPaste.BackColor = SystemColors.ButtonHighlight;
            pictureBoxScreenshotToPaste.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel.SetColumnSpan(pictureBoxScreenshotToPaste, 10);
            pictureBoxScreenshotToPaste.Dock = DockStyle.Fill;
            pictureBoxScreenshotToPaste.Location = new Point(3, 396);
            pictureBoxScreenshotToPaste.Margin = new Padding(3, 4, 3, 4);
            pictureBoxScreenshotToPaste.Name = "pictureBoxScreenshotToPaste";
            pictureBoxScreenshotToPaste.Size = new Size(858, 41);
            pictureBoxScreenshotToPaste.TabIndex = 3;
            pictureBoxScreenshotToPaste.TabStop = false;
            // 
            // labelFirstPictureBox
            // 
            labelFirstPictureBox.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(labelFirstPictureBox, 10);
            labelFirstPictureBox.Dock = DockStyle.Fill;
            labelFirstPictureBox.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFirstPictureBox.Location = new Point(3, 98);
            labelFirstPictureBox.Name = "labelFirstPictureBox";
            labelFirstPictureBox.Size = new Size(858, 49);
            labelFirstPictureBox.TabIndex = 2;
            labelFirstPictureBox.Text = "This is for screenshot to modify:";
            labelFirstPictureBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCtrlV
            // 
            labelCtrlV.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(labelCtrlV, 10);
            labelCtrlV.Dock = DockStyle.Fill;
            labelCtrlV.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCtrlV.Location = new Point(3, 0);
            labelCtrlV.Name = "labelCtrlV";
            tableLayoutPanel.SetRowSpan(labelCtrlV, 2);
            labelCtrlV.Size = new Size(858, 98);
            labelCtrlV.TabIndex = 0;
            labelCtrlV.Text = "Click on the necessary element and use Ctrl + V to paste copied screenshot.\r\nYou should understand, that the amount of letters in your username should be equal to the your original screenshot.";
            labelCtrlV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxScreenshotToModify
            // 
            pictureBoxScreenshotToModify.BackColor = SystemColors.ButtonHighlight;
            pictureBoxScreenshotToModify.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel.SetColumnSpan(pictureBoxScreenshotToModify, 10);
            pictureBoxScreenshotToModify.Dock = DockStyle.Fill;
            pictureBoxScreenshotToModify.Location = new Point(3, 151);
            pictureBoxScreenshotToModify.Margin = new Padding(3, 4, 3, 4);
            pictureBoxScreenshotToModify.Name = "pictureBoxScreenshotToModify";
            tableLayoutPanel.SetRowSpan(pictureBoxScreenshotToModify, 4);
            pictureBoxScreenshotToModify.Size = new Size(858, 188);
            pictureBoxScreenshotToModify.TabIndex = 1;
            pictureBoxScreenshotToModify.TabStop = false;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.WhiteSmoke;
            tableLayoutPanel.SetColumnSpan(buttonStart, 2);
            buttonStart.Dock = DockStyle.Fill;
            buttonStart.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(347, 690);
            buttonStart.Margin = new Padding(3, 4, 3, 4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(166, 50);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxTextKeyword
            // 
            textBoxTextKeyword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBoxTextKeyword, 3);
            textBoxTextKeyword.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTextKeyword.Location = new Point(605, 646);
            textBoxTextKeyword.Name = "textBoxTextKeyword";
            textBoxTextKeyword.Size = new Size(256, 30);
            textBoxTextKeyword.TabIndex = 9;
            textBoxTextKeyword.Text = "desktop";
            textBoxTextKeyword.TextAlign = HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(864, 744);
            Controls.Add(tableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(886, 800);
            Name = "MainForm";
            Text = "Linux Labs Changer by ButterDevelop";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxScreenshotToPaste).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxScreenshotToModify).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelCtrlV;
        private System.Windows.Forms.PictureBox pictureBoxScreenshotToModify;
        private System.Windows.Forms.Label labelFirstPictureBox;
        private System.Windows.Forms.Label labelSecondPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxScreenshotToPaste;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label labelResult;
        private Label labelTextToFindKeyword;
        private TextBox textBoxTextKeyword;
    }
}

