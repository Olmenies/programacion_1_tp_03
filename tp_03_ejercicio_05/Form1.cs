using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_05
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
                listBox1.Items.Clear();
                calculoPrimos();
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del evento buttonCalcular_Click()

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }//fin del evento buttonLimpiar_Click()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            string titulo = "Trabajo Práctico 03 - Ejercicio 05";
            string consigna = "Desarrollar un programa que le permita al usuario indicar un número mínimo y un número máximo. Mostrar en un Listbox todos aquellos que son primos.";

            MessageBox.Show(consigna, titulo);
        }//fin del evento buttonConsigna_Click()
        private void calculoPrimos()
        {
            int _valorMin, _valorMax;
            bool _esPrimo = true;
            _valorMin = Convert.ToInt32(textBox1.Text);
            _valorMax = Convert.ToInt32(textBox2.Text);

            //Se itera desde el valor mínimo hasta el valor máximo
            for (int i = _valorMin; i < _valorMax; i++)
            {
                //Se saca el módulo del entre la iteración actual y todos los valores que le preceden
                for (int j = 2; j < i; j++)
                {
                    //Si se encuentra una división con resto cero, la iteración actual y los valores que le preceden, la iteración actual no es primo
                    if (i % j == 0)
                    {
                        _esPrimo = false;
                        break;
                    }
                }//fin del for
                if (_esPrimo)
                    listBox1.Items.Add(i);
                _esPrimo = true;
            }//fin del for
        }//fin del método calculoPrimos()
    }
}
