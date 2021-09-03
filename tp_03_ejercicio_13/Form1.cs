using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSeleccionarImagen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }//fin del evento buttonSeleccinoarImagen_Click()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            string consigna = "Desarrolle un programa utilizando el control FileDialog y seleccionar una imagen que se vea en un control PictureBox.";
            string titulo = "Trabajo Práctico 03 - Ejercicio 13";

            MessageBox.Show(consigna, titulo);
        }//fin del evento buttonConsigna_Click()
    }
}
