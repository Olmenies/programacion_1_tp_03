using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            iniciarDataGridView();
        }

        static int CANTIDADDADOS = 1;
        static int CANTIDADPOSIBILIDADES = 6 * CANTIDADDADOS;
        public int cantidadDadosTirados = 0;
        int[] cantidadSalidaNumerosArray = new int[CANTIDADPOSIBILIDADES];
        float[] porcentajeSalidaNumerosArray = new float[CANTIDADPOSIBILIDADES];
        
        private void buttonTirarDados_Click(object sender, EventArgs e)
        {

            int[] tiradaDados = new int[CANTIDADDADOS];

            cantidadDadosTirados += 2;

            tirarDados(tiradaDados);
            calcularResultados(tiradaDados);
            mostrarResultados();
        }//fin del evento buttonTirarDados_Click()

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            iniciarDataGridView();
        }//fin del evento buttonLimpiarClick()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            //evento usado para mostrar la consigna del ejercicio
            string consigna = "Desarrollar un programa que simule la tirada de dos dados y mostrar en una grilla la cantidad " +
                "de veces que salió cada número y el porcentaje que representa esa cantidad en el total de tiradas. " +
                "\n\nLas tiradas se deben realizar al oprimir un botón.";
            string titulo = "Trabajo Práctico 03 - Ejercicio 09";

            MessageBox.Show(consigna, titulo);
        }//fin del evento buttonConsigna_Click()

        private void iniciarDataGridView()
        {
            //método usado apra definir algunas propiedades de la dataGridView
            for(int i=0; i<CANTIDADPOSIBILIDADES; i++)
            {
                //se agregan las columnas
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.Name = Convert.ToString(i+1);
                dataGridView2.Columns.Add(columna);
            }//fin del for

            for(int i=0; i<2; i++)
            {
                //se agregan las rows
                DataGridViewRow fila = new DataGridViewRow();
                dataGridView2.Rows.Add(fila);
            }//fin del for

            //se define el size de las columnas según su contenido
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //se prohibe al usuario modificar la dataGridView
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ReadOnly = true;
        }//fin del método iniciarDataGridView()

        private void mostrarResultados()
        {
            //método usado para mostrar los resultados en la dataGridView
            for (int i = 0; i < CANTIDADPOSIBILIDADES; i++)
            {
                dataGridView2[i, 0].Value = cantidadSalidaNumerosArray[i];
                dataGridView2[i, 1].Value = porcentajeSalidaNumerosArray[i];
            }//fin del for
        }//fin del método mostrarResultado()

        private void calcularResultados(int[] tiradaDados)
        {
            //método usado para calcular la cantidad de veces que salió cada dado y el porcentaje que representan en el total
            for (int i = 0; i < CANTIDADDADOS; i++)
            {
                cantidadSalidaNumerosArray[tiradaDados[i]]++;
            }//fin del for

            for (int i = 0; i < CANTIDADPOSIBILIDADES; i++)
            {
                porcentajeSalidaNumerosArray[i] = (float)Math.Round(Convert.ToSingle(cantidadSalidaNumerosArray[i]) * 100 / cantidadDadosTirados, 2);
            }//fin del for
        }//fin del método calcularResultados()

        private void tirarDados(int[] tiradaDados)
        {
            //método usado para simular una tirada de dados con la cantidad de dados definidos en la constante CANTIDADDADOS
            Random random = new Random();
            for (int i = 0; i < CANTIDADDADOS; i++)
            {
                tiradaDados[i] = random.Next(0, CANTIDADPOSIBILIDADES);
            }//fin del for
        }//fin del método tirarDados()
    }
}
