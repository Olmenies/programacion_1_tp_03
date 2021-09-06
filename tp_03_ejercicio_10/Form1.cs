using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            iniciarDataGridView();
        }

        static int CANTIDADESCALAS = 4;
        static string[] escalas = new string[] { "Celsius", "Kelvin", "Fahrenheit", "Rankine" };
        float[] resultadosConversiones = new float[CANTIDADESCALAS];


        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float valorIngresado = Convert.ToSingle(textBox1.Text);

                if (radioButtonCelsius.Checked)
                {
                    resultadosConversiones[0] = valorIngresado;
                    resultadosConversiones[1] = celsiusXKelvin(valorIngresado);
                    resultadosConversiones[2] = celsiusXFahrenheit(valorIngresado);
                    resultadosConversiones[3] = celsiusXRankine(valorIngresado);
                }
                else if (radioButtonKelvin.Checked)
                {
                    resultadosConversiones[0] = kelvinXCelsius(valorIngresado);
                    resultadosConversiones[1] = valorIngresado;
                    resultadosConversiones[2] = kelvinXFahrenheit(valorIngresado);
                    resultadosConversiones[3] = kelvinXRankine(valorIngresado);
                }
                else if (radioButtonFahrenheit.Checked)
                {
                    resultadosConversiones[0] = fahrnenheitXCelsius(valorIngresado);
                    resultadosConversiones[1] = fahrenheitXKelvin(valorIngresado);
                    resultadosConversiones[2] = valorIngresado;
                    resultadosConversiones[3] = fahrenheitXRankine(valorIngresado);
                }
                else if (radioButtonRankine.Checked)
                {
                    resultadosConversiones[0] = rankineXCelsius(valorIngresado);
                    resultadosConversiones[1] = rankineXKelvin(valorIngresado);
                    resultadosConversiones[2] = rankineXFahrenheit(valorIngresado);
                    resultadosConversiones[3] = valorIngresado;
                }
                else
                    MessageBox.Show("Por favor, seleccionar una escala de input.");

                mostrarResultado();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del evento buttonCalcular_Click()

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            //evento usado para vaciar la dataGridView
            dataGridView1.Rows.Clear();
            textBox1.Focus();
        }//fin del evento buttonLimpiar_Click()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            //método usado para mostrar la consigna del ejercicio
            string consigna = "Desarrollar un programa que permita transformar temperaturas  entre las siguientes escalas: " +
                "Celsius,  Fahrenheit, Kelvin, Rankine. el programa deberá permitir indicar: la escala inicial, la escala final " +
                "y la cantidad a transformar. Se debe obtener la cantidad en la escala final. Los valores ingresados y calculados " +
                "deberán permaneces visibles en una grilla";
            string titulo = "Trabajo Práctico 03 - Ejercicio 10";

            MessageBox.Show(consigna, titulo);
        }//fin del método buttonConsigna_Click()

        private void iniciarDataGridView()
        {
            //método usado para iniciar la dataGridView con las columnas y rows según corresponde
            for (int i=0; i<CANTIDADESCALAS; i++)
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.Name = escalas[i];
                dataGridView1.Columns.Add(columna);
            }

            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.ReadOnly = true;
            //dataGridView1.AllowUserToResizeRows = false;
            //dataGridView1.AllowUserToAddRows = false;
        }//fin del método iniciarDataGridView()

        private void mostrarResultado()
        {
            //método usado para mostrar el resultado de las conversiones en la dataGridView
            for(int i=0; i<CANTIDADESCALAS; i++)
            {
                dataGridView1[i, 0].Value = resultadosConversiones[i];
            }//fin del for
        }//fin del método mostrarResultado()

        private float celsiusXKelvin(float valorIngresado)
        {
            //método usado para convertir Celsius a Kelvin
            float resultado = valorIngresado + (float)273.15;
            return resultado;
        }//fin del método celsiusXKelvin()

        private float celsiusXFahrenheit(float valorIngresado)
        {
            //método usado para convertir Celsius a Fahrenheint
            float resultado = valorIngresado * (float)1.8 + (float)32;
            return resultado;
        }//fin del método celsiusXFahrenheit()

        private float celsiusXRankine(float valorIngresado)
        {
            //método usado para convertir de Celsius a Rankine
            float resultado = valorIngresado * (float)1.8 + (float)32 + (float)459.67;
            return resultado;
        }//fin del método celsiusXRankine()
        
        private float kelvinXCelsius(float valorIngresado)
        {
            //método usado para convertir de Kelvin a Celsius
            float resultado = valorIngresado - (float)273.15;
            return resultado;
        }//fin del método kelvinXCelsius()

        private float kelvinXFahrenheit(float valorIngresado)
        {
            //método usado para convertir de Kelvin a Fahrenheit
            float resultado = valorIngresado * (float)1.8 - (float)459.67;
            return resultado;
        }//fin del método kelvinXFahrenheit()

        private float kelvinXRankine(float valorIngresado)
        {
            //método usado para convertir de Kelvin a Rankine
            float resultado = valorIngresado * (float)1.8;
            return resultado;
        }//fin del método kelvinXRankine()

        private float fahrnenheitXCelsius(float valorIngresado)
        {
            //métod usado para convertir de Fahrenheit a Celsius
            float resultado = (valorIngresado - (float)32) / (float)1.8;
            return resultado;
        }//fin del método fahrenheitXCelsius()

        private float fahrenheitXKelvin(float valorIngresado)
        {
            //método usado para convertir de Fahrenheit a Kelvin
            float resultado = (valorIngresado + (float)459.67) / (float)1.8;
            return resultado;
        }//fin del método fahrenheitXKelvin

        private float fahrenheitXRankine(float valorIngresado)
        {
            //método usado para convertir de Fahrenheit a Rankine
            float resultado = valorIngresado + (float)459.67;
            return resultado;
        }//fin del método fahrenheitXRankine()

        private float rankineXCelsius(float valorIngresado)
        {
            //método usado para convertir de Rankine a Celsius
            float resultado = (valorIngresado - (float)32 - (float)459.67) / (float)1.8;
            return resultado;
        }//fin del método rankineXCelsius()

        private float rankineXKelvin(float valorIngresado)
        {
            //método usado para convertir de Rankine a Kelvin
            float resultado = valorIngresado / (float)1.8;
            return resultado;
        }//fin del método rankineXKelvin()
        
        private float rankineXFahrenheit(float valorIngresado)
        {
            //método usado para convertir de Rankine a Fahrenheit
            float resultado = valorIngresado - (float)459.67;
            return resultado;
        }//fin del método rankineXFahrenheit()
    }
}
