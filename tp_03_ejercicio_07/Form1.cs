using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio07
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
                float monto = Convert.ToSingle(textBoxMonto.Text);
                int lapso = Convert.ToInt32(textBoxLapso.Text);
                float tna = Convert.ToSingle(textBoxTna.Text);

                float resultado = calculoIntereses(monto, lapso, tna);

                dataGridView1.Rows.Add(monto, lapso, tna, resultado);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del evento buttonCalcular_Click()
        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            string consigna = "Desarrollar un programa que permita calcular los intereses de un plazo fijo.Para ello nos informan que la manera de obtenerlo es" +
                "haciendo M *T * D / 36500.Donde: M = Monto, T = Tasa Nominal Anual, D = Días que dura la imposición. Mostrar los valores ingresados" +
                "y los resultados en una Grilla del tipo DataGridView.";
            string titulo = "Trabajo Práctico 03 - Ejercicio 07";

            MessageBox.Show(consigna, titulo);
        }//fin del evento buttonConsigna_Click()
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }//fin del evento buttonLimpiar_Click()
        private float calculoIntereses(float _monto, int _lapso, float _tna)
        {
            float _resultado = (_monto * _lapso * _tna) / 36500;
            return _resultado;
        }//fin del método calculoIntereses()
    }
}
