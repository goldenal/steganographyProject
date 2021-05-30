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
            if (filePath_tbx.Text != string.Empty || filePath_tbx.Text != "")
            {
                Bitmap img = new Bitmap(filePath_tbx.Text);
                int imgHeight = img.Height;
                int imgWidth = img.Width;
                int textsize = imgHeight * imgWidth;
                label3.Text = "" + imgHeight + " * " + imgWidth;
                //label5.Text = "" + textsize;
                label5.Text = "" + textsize;
                label7.Text = "" + textsize / 2;

            }
             

           // string testword = "hhjfjrrrrrrrrrrrrrrrr";
            //int word = 1;
           // for(int i = 0; i<130000; i++)
            //{
              //  testword = testword + "," + i;
            //}

            //message_tbx.Text = testword;


           
           
        }

        private void encode_btn_Click(object sender, EventArgs e)
        {
            if(message_tbx.Text == string.Empty)
            {
                MessageBox.Show("Message box cannot be empty");
            }
            else
            {
                Bitmap img;
                if (filePath_tbx.Text !=string.Empty)
                {
                    img = new Bitmap(filePath_tbx.Text);
                    int imgSize = img.Height * img.Width;
                    int wordSize = message_tbx.TextLength;
                    int shift_factor = (imgSize / 2) / wordSize;

                    int selector = 0;
                    int innerCounter = 0;
                    int c = 0;
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            selector++;
                            Color pixel = img.GetPixel(i, j);
                            if (innerCounter < message_tbx.TextLength && (selector % shift_factor) == 0)
                            {
                                innerCounter++;
                                char letter = Convert.ToChar(message_tbx.Text.Substring(innerCounter - 1, 1));
                                int intval = Convert.ToInt32(letter);
                                Console.WriteLine("Letter :" + letter + " val: " + intval);
                                if (intval < 256)
                                {
                                    img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, intval));
                                }


                            }

                            if (i == img.Width - 1 && j == img.Height - 1)
                            {
                                img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, message_tbx.TextLength));
                            }


                            if (shift_factor < 256)
                            {
                                if (i == img.Width - 2 && j == img.Height - 1)
                                {
                                    img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, shift_factor));

                                }
                                if (i == img.Width - 3 && j == img.Height - 1)
                                {
                                    img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, 0));

                                }
                            }
                            else
                            {
                                int[] a = divider(shift_factor);
                                if (i == img.Width - 2 && j == img.Height - 1)
                                {

                                    img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, a[0]));

                                }
                                if (i == img.Width - 3 && j == img.Height - 1)
                                {
                                    img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, a[1]));

                                }
                            }

                        }
                    }

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.Filter = "Image Files (*.png; *.jpg) |*.png; *.jpg";
                    savefile.InitialDirectory = @"C:\Users\ADEOSUN ADEWALE\Pictures";
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        filePath_tbx.Text = savefile.FileName.ToString();
                        pictureBox1.ImageLocation = filePath_tbx.Text;
                        img.Save(filePath_tbx.Text);
                        Console.WriteLine("encode shft fact:" + shift_factor);
                    }
                }
                else
                {
                    MessageBox.Show("File location cannot be empty");
                }

            

            }
               

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void decode_btn_Click(object sender, EventArgs e)
        {
            if (filePath_tbx.Text != string.Empty)
            {
                Bitmap img = new Bitmap(filePath_tbx.Text);
                String message = "";

                Color lastPixel = img.GetPixel(img.Width - 1, img.Height - 1);
                Color factPixel = img.GetPixel(img.Width - 2, img.Height - 1);
                Color remPixel = img.GetPixel(img.Width - 3, img.Height - 1);

                int rem = remPixel.B;
                int factor = factPixel.B;
                int msglength = lastPixel.B;

                int shift_factor = getShift_factor(rem, factor);
                // Console.WriteLine("rem:"+ rem);
                Console.WriteLine("fact:" + shift_factor);

                int counter = 0;
                int innerCounter = 0;
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        counter++;
                        Color pixel = img.GetPixel(i, j);
                        if (innerCounter < msglength && (counter % shift_factor) == 0)
                        {
                            innerCounter++;
                            int value = pixel.B;
                            char c = Convert.ToChar(value);
                            string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                            message = message + letter;

                        }
                    }
                }

                message_tbx.Text = message;
            }
            else
            {
                MessageBox.Show("Filepath cannot be empty");
            }
               
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void message_tbx_TextChanged(object sender, EventArgs e)
        {
            label8.Text = ""+message_tbx.TextLength +"/250";
            // Console.WriteLine((3%3)== 0);
           // int[] a = divider(100);
          // Console.WriteLine(getShift_factor(5,6));
        }


        private int[] divider(int shift_factor)
        {
            int no_of_times = 0;
            int remainder = 0;
            do {
                remainder = shift_factor - 255;
                shift_factor = remainder;
                no_of_times++;

            } while (255< shift_factor);

            int[] value = {no_of_times,remainder };
            return value;
        }


        private int getShift_factor(int rem, int fact)
        {
            if(fact == 0)
            {
                return rem;
            }
            else
            {
                return (fact * 255) + rem;
            }
        }
    }
}
