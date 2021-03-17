using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalyear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg) |*.png; *.jpg";
            openFileDialog.InitialDirectory = @"C:\Users\ADEOSUN ADEWALE\Pictures";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                filePath_tbx.Text = openFileDialog.FileName.ToString();
                pictureBox1.ImageLocation = filePath_tbx.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
          
            }
              
        }

        private void encode_btn_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(filePath_tbx.Text);
            for(int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++) {

                    Color pixel = img.GetPixel(i,j);
                    if (j < 10)
                    {

                        Console.WriteLine("R = [" + i + "][" + j + "]" + pixel.R);
                        Console.WriteLine("G = [" + i + "][" + j + "]" + pixel.G);
                        Console.WriteLine("B = [" + i + "][" + j + "]" + pixel.B);

                    }


                }
                   

            }
        }
    }
}
