using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int valorIngresado = Convert.ToInt32(textBox1.Text);
                calculoFibonacci(valorIngresado);
                textBox1.Focus();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del evento buttonCalcular_Click()

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Focus();
        }//fin del evento buttonLimpiar_Click()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            string consigna = "Desarrollar un programa que permita calcular los primeros n números de la serie de Fibonacci. El número n es ingresado por el usuario";
            string titulo = "Trabajo Práctico 03 - Ejercicio 06";

            MessageBox.Show(consigna, titulo);
        }//fin del evento buttonConsigna_Click()

        private void calculoFibonacci(int _valorIngresado)
        {
            int _resultado, _termino1 = 0, _termino2 = 1;

            for(int i=0; i<_valorIngresado; i++)
            {
                _resultado = _termino1 + _termino2;
                _termino1 = _termino2;
                _termino2 = _resultado;
                listBox1.Items.Add(_resultado);
            }//fin del for
        }//fin del método calculoFibonacci()
    }
}
