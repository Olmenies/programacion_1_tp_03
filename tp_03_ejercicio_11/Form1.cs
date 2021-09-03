using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Turno: " + definicionTurno();
        }

        int contadorTurnos = 0;

        private void chequearCondicionesVictoria()
        {
            //Función que chequea las condiciones de victoria
            /*
            * 
            * Condiciones de victoria:
            *  
            *  1 == 2 == 3
            *  4 == 5 == 6
            *  7 == 8 == 9
            *  
            *  1 == 4 == 7
            *  2 == 5 == 8
            *  3 == 6 == 9
            *  
            *  1 == 5 == 9
            *  3 == 5 == 7
            *  
            */

            //victoria en líneas horizontales
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button1.Text != "-"))
                finDelJuego();
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button4.Text != "-"))
                finDelJuego();
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (button7.Text != "-"))
                finDelJuego();

            //victoria en líneas verticales
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button1.Text != "-"))
                finDelJuego();
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (button2.Text != "-"))
                finDelJuego();
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (button3.Text != "-"))
                finDelJuego();

            //victoria en líneas diagonales
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (button1.Text != "-"))
                finDelJuego();
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (button3.Text != "-"))
                finDelJuego();
        }//fin del método chequearCondicionesVictoria()

        private void finDelJuego()
        {
            MessageBox.Show("Fin del juego");
            foreach(Button button in groupBox1.Controls)
            {
                button.Enabled = false;
            }//fom del foreach
        }//fin del método finDelJuego()

        private string definicionTurno()
        {
            if (contadorTurnos % 2 == 0)
                return "X";
            else
                return "O";
        }//fin del método defniciónTurno()

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Turno: " + definicionTurno();
            button1.Text = definicionTurno();
            button1.Enabled = false;
            contadorTurnos++;
            label1.Text = "Turno: " + definicionTurno();
            chequearCondicionesVictoria();
        }//fin del evento button1_Click()

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Turno: " + definicionTurno();
            button2.Text = definicionTurno();
            button2.Enabled = false;
            contadorTurnos++;
            label1.Text = "Turno: " + definicionTurno();
            chequearCondicionesVictoria();
        }//fin del evento button1_Click()

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Turno: " + definicionTurno();
            button3.Text = definicionTurno();
            button3.Enabled = false;
            contadorTurnos++;
            label1.Text = "Turno: " + definicionTurno();
            chequearCondicionesVictoria();
        }//fin del evento button1_Click()

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Turno: " + definicionTurno();
            button4.Text = definicionTurno();
            button4.Enabled = false;
            contadorTurnos++;
            label1.Text = "Turno: " + definicionTurno();
            chequearCondicionesVictoria();
        }//fin del evento button1_Click()

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Turno: " + definicionTurno();
            button5.Text = definicionTurno();
            button5.Enabled = false;
            contadorTurnos++;
            label1.Text = "Turno: " + definicionTurno();
            chequearCondicionesVictoria();
        }//fin del evento button1_Click()

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Turno: " + definicionTurno();
            button6.Text = definicionTurno();
            button6.Enabled = false;
            contadorTurnos++;
            label1.Text = "Turno: " + definicionTurno();
            chequearCondicionesVictoria();
        }//fin del evento button1_Click()

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Turno: " + definicionTurno();
            button7.Text = definicionTurno();
            button7.Enabled = false;
            contadorTurnos++;
            label1.Text = "Turno: " + definicionTurno();
            chequearCondicionesVictoria();
        }//fin del evento button1_Click()

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Turno: " + definicionTurno();
            button8.Text = definicionTurno();
            button8.Enabled = false;
            contadorTurnos++;
            label1.Text = "Turno: " + definicionTurno();
            chequearCondicionesVictoria();
        }//fin del evento button1_Click()

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "Turno: " + definicionTurno();
            button9.Text = definicionTurno();
            button9.Enabled = false;
            contadorTurnos++;
            label1.Text = "Turno: " + definicionTurno();
            chequearCondicionesVictoria();
        }//fin del evento button1_Click()

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            foreach(Button button in groupBox1.Controls)
            {
                button.Text = "-";
                button.Enabled = true;
            }//fin del foreach
            contadorTurnos = 0;
        }//fin del evento buttonReiniciar_Click()

        private void buttonConsigna_Click(object sender, EventArgs e)
        {
            string consigna = "Desarrolle un programa que simule el juego del TA-TE-TI ";
            string titulo = "Trabajo Práctico 03 - Ejercicio 11";

            MessageBox.Show(consigna, titulo);
        }//fin del evento buttonConsigna_Click()
    }
}
