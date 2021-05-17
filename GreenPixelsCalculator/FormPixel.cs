using System;
using System.Drawing;
using System.Windows.Forms;

namespace GreenPixelsCalculator
{
    public partial class FormPixel : Form
    {
        public FormPixel()
        {
            InitializeComponent();
        }

        private void btLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "bmp|*.bmp";
            if (file.ShowDialog() == DialogResult.OK)
                pictureBox1.ImageLocation = file.FileName;
        }

        /// <summary>
        /// pixelcolor pega a imagem
        /// Set pixel Color.Gold Marca os pixels obtidos na imagem
        private void btPixelDetect_Click(object sender, EventArgs e)
        {
            var green = Color.FromArgb(96, 192, 0);
            var count = 0;

            Bitmap img = new Bitmap(pictureBox1.Image);

            for (var x = 0; x < img.Width; x++)
            {
                for (var y = 0; y < img.Height; y++)
                {
                    Color pixelColor = img.GetPixel(x, y);
                    if (pixelColor == green)
                    {
                        count++;
                        img.SetPixel(x, y, Color.Gold);
                    }
                }
            }
            pictureBox1.Image = img;

            var percent = ((float)count / (img.Width * img.Height)) * 100;
            lblResultPixels.Text = String.Format("A quantidade de pixels verdes é {0:d} (ou seja, uma área equivalente a {1:f}%)", count, percent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}