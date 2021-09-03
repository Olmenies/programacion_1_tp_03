
//Título: Trabajo Práctico 03 - Ejercicio 01
//Consigna: Desarrollar un programa que permita ingresar dos números por medio de inputbox y retorne la suma de los mismos en un messagebox. 
//Alumno: Nicolás Esteban Olmedo
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace tp_03_ejercicio_01
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
                float valor00 = Convert.ToSingle(Interaction.InputBox("Ingresar un número:", "Trabajo Práctico 03 - Ejercicio 01"));
                float valor01 = Convert.ToSingle(Interaction.InputBox("Ingresar un número:", "Trabajo Práctico 03 - Ejercicio 01"));

                float resultado = valor00 + valor01;

                MessageBox.Show(valor00 + " + " + valor01 + " = " + resultado );
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }//fin del método buttonAgregarValor_Clic()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            string mensaje = "Desarrollar un programa que permita ingresar dos números por medio de inputbox y retorne la suma de los mismos en un messagebox. ";
            string titulo = "Trabajo Práctico 03 - Ejercicio 01";
            MessageBox.Show(mensaje, titulo);
        }//fin del método buttonConsigna_Click()
    }
}
