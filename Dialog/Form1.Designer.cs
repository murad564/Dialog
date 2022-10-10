namespace Dialog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_openImage = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_fontDialog = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lbl_font = new System.Windows.Forms.Label();
            this.lbl_folderPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_openFolder = new System.Windows.Forms.Button();
            this.lbl_color = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_openColorDialog = new System.Windows.Forms.Button();
            this.lbl_shortCut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 238);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(482, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 137);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_openImage
            // 
            this.btn_openImage.Location = new System.Drawing.Point(482, 192);
            this.btn_openImage.Name = "btn_openImage";
            this.btn_openImage.Size = new System.Drawing.Size(172, 23);
            this.btn_openImage.TabIndex = 4;
            this.btn_openImage.Text = "Select Picture";
            this.btn_openImage.UseVisualStyleBackColor = true;
            this.btn_openImage.Click += new System.EventHandler(this.btn_openImage_Click_1);
            // 
            // btn_fontDialog
            // 
            this.btn_fontDialog.Location = new System.Drawing.Point(409, 382);
            this.btn_fontDialog.Name = "btn_fontDialog";
            this.btn_fontDialog.Size = new System.Drawing.Size(116, 23);
            this.btn_fontDialog.TabIndex = 5;
            this.btn_fontDialog.Text = "Open Font Dialog";
            this.btn_fontDialog.UseVisualStyleBackColor = true;
            this.btn_fontDialog.Click += new System.EventHandler(this.btn_fontDialog_Click_1);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(363, 347);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 20);
            this.lbl.TabIndex = 6;
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.Location = new System.Drawing.Point(455, 352);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(31, 15);
            this.lbl_font.TabIndex = 7;
            this.lbl_font.Text = "Font";
            // 
            // lbl_folderPath
            // 
            this.lbl_folderPath.AutoSize = true;
            this.lbl_folderPath.Location = new System.Drawing.Point(232, 352);
            this.lbl_folderPath.Name = "lbl_folderPath";
            this.lbl_folderPath.Size = new System.Drawing.Size(99, 15);
            this.lbl_folderPath.TabIndex = 10;
            this.lbl_folderPath.Text = "Open Folder Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(357, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // btn_openFolder
            // 
            this.btn_openFolder.Location = new System.Drawing.Point(223, 382);
            this.btn_openFolder.Name = "btn_openFolder";
            this.btn_openFolder.Size = new System.Drawing.Size(125, 23);
            this.btn_openFolder.TabIndex = 8;
            this.btn_openFolder.Text = "Open";
            this.btn_openFolder.UseVisualStyleBackColor = true;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(71, 352);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(36, 15);
            this.lbl_color.TabIndex = 13;
            this.lbl_color.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 12;
            // 
            // btn_openColorDialog
            // 
            this.btn_openColorDialog.Location = new System.Drawing.Point(29, 382);
            this.btn_openColorDialog.Name = "btn_openColorDialog";
            this.btn_openColorDialog.Size = new System.Drawing.Size(129, 23);
            this.btn_openColorDialog.TabIndex = 11;
            this.btn_openColorDialog.Text = "Open Color Dialog";
            this.btn_openColorDialog.UseVisualStyleBackColor = true;
            this.btn_openColorDialog.Click += new System.EventHandler(this.btn_openColorDialog_Click);
            // 
            // lbl_shortCut
            // 
            this.lbl_shortCut.AutoSize = true;
            this.lbl_shortCut.Location = new System.Drawing.Point(639, 352);
            this.lbl_shortCut.Name = "lbl_shortCut";
            this.lbl_shortCut.Size = new System.Drawing.Size(32, 15);
            this.lbl_shortCut.TabIndex = 14;
            this.lbl_shortCut.Text = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_shortCut);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_openColorDialog);
            this.Controls.Add(this.lbl_folderPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_openFolder);
            this.Controls.Add(this.lbl_font);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_fontDialog);
            this.Controls.Add(this.btn_openImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button btn_openImage;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btn_fontDialog;
        private Label lbl;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private Label lbl_font;
        private Label lbl_folderPath;
        private Label label3;
        private Button btn_openFolder;
        private Label lbl_color;
        private Label label5;
        private Button btn_openColorDialog;
        private Label lbl_shortCut;
    }
}