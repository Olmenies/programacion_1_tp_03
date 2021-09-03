using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTirarDados_Click(object sender, EventArgs e)
        {
            //evento para iniciar la tirada de dados
            try
            {
                int resultadoDado = tirarDado();
                MessageBox.Show(Convert.ToString(resultadoDado));
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del evento buttonTirarDados_Click()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            //evento para mostrar la consigna del ejercicio
            string consigna = "Desarrollar un programa que simule la tirada de un dado.";
            string titulo = "Trabajo Práctico 03 - Ejercicio 08";

            MessageBox.Show(consigna, titulo);
        }//fin del evento buttonConsigna_Click()

        private int tirarDado()
        {
            //método usado para simular una tirada de dados con la clase Random
            Random random = new Random();
            int resultado = random.Next(1, 7);
            return resultado;
        }//fin del método tirarDado()
    }
}
