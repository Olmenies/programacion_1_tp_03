using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_03
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
                float valorIngresado, resultado = 0;
                valorIngresado = Convert.ToSingle(textBoxInput.Text);

                listBoxValores.Items.Add(valorIngresado);

                foreach (float valorIteracion in listBoxValores.Items)
                {
                    resultado += valorIteracion;
                }//fin del foreach

                textBoxInput.Clear();
                labelResultado.Text = "Sumatoria: " + Convert.ToString(resultado);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            string titulo = "Trabajo Práctico 03 - Ejercicio 03";
            string consigna = "Desarrollar un programa que permita cargar una cantidad n de números ingresados por el usuario y mostrar los números ingresados en un textbox y el resultado en un label.";

            MessageBox.Show(consigna, titulo);
        }//fin del método buttonConsigna_Click()

        private void buttonLimpiarListBox_Click(object sender, EventArgs e)
        {
            listBoxValores.Items.Clear();
            labelResultado.Text = "";
        }//fin del método buttonLimpiarListBox_Click()
    }
}
