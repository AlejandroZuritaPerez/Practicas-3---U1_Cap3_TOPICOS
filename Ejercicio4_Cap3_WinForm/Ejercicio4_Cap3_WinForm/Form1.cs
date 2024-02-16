using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_Cap3_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int numeroDia = comboBox1.SelectedIndex + 1;
            if (numeroDia < 1 || numeroDia > 7)
            {
                MessageBox.Show("Número inválido. Por favor, ingrese un número del 1 al 7.");
                return;
            }
            MostrarDiaSemana(numeroDia);
        }

        private void MostrarDiaSemana(int numeroDia)
        {
            string nombreDia;
            switch (numeroDia)
            {
                case 1:
                    nombreDia = "Lunes";
                    break;
                case 2:
                    nombreDia = "Martes";
                    break;
                case 3:
                    nombreDia = "Miércoles";
                    break;
                case 4:
                    nombreDia = "Jueves";
                    break;
                case 5:
                    nombreDia = "Viernes";
                    break;
                case 6:
                    nombreDia = "Sábado";
                    break;
                case 7:
                    nombreDia = "Domingo";
                    break;
                default:
                    nombreDia = "Día no válido";
                    break;
            }
            label3.Text = ($"El número {numeroDia} corresponde al día {nombreDia}.");

        }
    }
}

