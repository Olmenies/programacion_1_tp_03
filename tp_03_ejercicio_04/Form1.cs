using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            try
            {
                labelResultado.Text = "Resultado: " + Convert.ToString(Convert.ToSingle(textBox0.Text) + Convert.ToSingle(textBox1.Text));
                textBox0.Clear();
                textBox1.Clear();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del método buttonSuma_Click()

        private void buttonResta_Click(object sender, EventArgs e)
        {
            try
            {
                labelResultado.Text = "Resultado: " + Convert.ToString(Convert.ToSingle(textBox0.Text) - Convert.ToSingle(textBox1.Text));
                textBox0.Clear();
                textBox1.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del método buttonResta_Click()

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                labelResultado.Text = "Resultado: " + Convert.ToString(Convert.ToSingle(textBox0.Text) * Convert.ToSingle(textBox1.Text));
                textBox0.Clear();
                textBox1.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del método buttonMultiplicacion_Click

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            try
            {
                labelResultado.Text = "Resultado: " + Convert.ToString(Convert.ToSingle(textBox0.Text) / Convert.ToSingle(textBox1.Text));
                textBox0.Clear();
                textBox1.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del método buttonDivisio_Click()

        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                labelResultado.Text = "Resultado: " + Convert.ToString(Math.Pow(Convert.ToSingle(textBox0.Text), Convert.ToSingle(textBox1.Text)));
                textBox0.Clear();
                textBox1.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del método buttonPotencia_Click()

        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                labelResultado.Text = "Resultado: " + Convert.ToString(Math.Sqrt(Convert.ToSingle(textBox0.Text)));
                textBox0.Clear();
                textBox1.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del método buttonRaiz_Click()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            string title = "Trabajo Práctico 03 - Ejercicio 04";
            string consigna = "Desarrollar un programa que permita calcular la suma, resta, multiplicación, división, potencia y raíz cuadrada de dos números. Seleccione los controles que utilizará para ingresar los número y visualizar el resultado. Las operaciones se ejecutarán con botones de comando.";

            MessageBox.Show(consigna, title);
        }//fin del método buttonConsigna_Click()
    }
}
