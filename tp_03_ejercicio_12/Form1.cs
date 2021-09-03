using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSeleccionarColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }//fin del evento buttonSeleccionarColor_Click()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            string consigna = "Desarrolle un programa utilizando el control ColorDialog y que el color seleccionado se le asigne al color de fondo del formulario. ";
            string titulo = "Trabajo Práctico 03 - Ejercicio 12";

            MessageBox.Show(consigna, titulo);
        }//fin del evento buttonConsigna_Click()
    }
}
