using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregarValor_Click(object sender, EventArgs e)
        {
            try
            {
                float valor00 = Convert.ToInt32(textBoxValor00.Text);
                float valor01 = Convert.ToInt32(textBoxValor01.Text);

                float resultado = valor00 + valor01;

                labelResultado.Text = Convert.ToString(resultado);

                textBoxValor00.Clear();
                textBoxValor01.Clear();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del método buttonAgregarValor_Click()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            string titulo = "Trabajo Práctico 03 - Ejercicio 02";
            string consigna = "Desarrollar un programa que permita ingresar dos números por medio de cajas de texto y retorne la suma de los mismos en un label.";

            MessageBox.Show(consigna, titulo);
        }//fin del método buttonConsigna_Click()
    }
}
