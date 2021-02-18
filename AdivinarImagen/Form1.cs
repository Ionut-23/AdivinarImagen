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

        private int selecImagen;
        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            string ruta = "Ionut-23/AdivinarImagen/AdivinarImagen/Resources/";
            selecImagen = random.Next(1, 6);
           
            Console.WriteLine("AdivinarImagen/AdivinarImagen/Resources/"+selecImagen.ToString() + ".jpg");
            pictureBox1.Image = Image.FromFile("Ionut-23/AdivinarImagen/AdivinarImagen/Resources/"+selecImagen.ToString() + ".jpg");



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkMagenta, ButtonBorderStyle.Solid);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == selecImagen.ToString())
            {
                label3.Text = "Correcto!!";
            }
            else
            {
                label3.Text = "Prueba otra vez..";
            }
        }
    }
}
