using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinarImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label label1 = new Label();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string ruta = @"C:\Users\ionut\source\repos\AdivinarImagen\AdivinarImagen\Imagenes\";

            pictureBox1.Image = Image.FromFile(ruta + random.Next(1,3).ToString() + ".jpg");

            //img_anden.ImageUrl = "~/images/gallery/Img" + rand.Next(1, 100).ToString() + ".jpg";
            /*
             *  int rInt = r.Next(1, 21);
                 string path = @"C:/Users/User/Desktop/Badges/Badges/";
                int i = r.Next();
                 pictureBox1.Image = Image.FromFile(path + rInt.ToString() + ".png");

                 // store the random number in the pictureBox
                 pictureBox1.Tag = rInt;
             */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkMagenta, ButtonBorderStyle.Solid);
            
        }
    }
}
