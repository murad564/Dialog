namespace Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*|Text Files|*txt";
            openFileDialog1.FilterIndex = 2;

            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //[]string fileNames = OpemFileDialog1/FileName
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG |.png *|JPG |*jpg; *jpeg *|GIF |.gif";
            
                pictureBox1.Load(openFileDialog1.FileName);
            

        }

        private void btn_openImage_Click_1(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "PNG|*.png|JPG|*.jpg; *.jpeg;|GIF|*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
            }
        }



        private void btn_openFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lbl_folderPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btn_openColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowHelp = true;
            colorDialog1.HelpRequest += (s, e) => { };


            colorDialog1.ShowDialog();
            lbl_color.ForeColor = colorDialog1.Color;
        }

        private void btn_fontDialog_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lbl_font.Font = fontDialog1.Font;
        }

        private void btn_openFolder_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lbl_folderPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.S)
                lbl_shortCut.Text = "ctrl + s";
        }

        

    }
}