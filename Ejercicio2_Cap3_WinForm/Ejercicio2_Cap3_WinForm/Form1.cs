using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio2_Cap3_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string respuesta = comboBox1.SelectedItem.ToString().Trim().ToLower();

            if (respuesta == "grados")
            {
                double grados;
                if (!double.TryParse(textBox1.Text, out grados))
                {
                    MessageBox.Show("Valor inválido. Por favor, ingrese un número válido.");
                    return;
                }
                MostrarResultado(ConvertirRadianesAGrados(grados));
            }
            else if (respuesta == "radianes")
            {
                double radianes;
                if (!double.TryParse(textBox2.Text, out radianes))
                {
                    MessageBox.Show("Valor inválido. Por favor, ingrese un número válido.");
                    return;
                }
                MostrarResultado(ConvertirGradosARadianes(radianes));
            }
            else
            {
                MessageBox.Show("Respuesta no válida. Por favor, ingrese 'grados' o 'radianes'.");
            }
        }


        private double ConvertirRadianesAGrados(double radianes)
        {
            return (radianes * 180) / Math.PI;
        }

        private double ConvertirGradosARadianes(double grados)
        {
            return (grados * Math.PI) / 180;
        }

        private void MostrarResultado(double resultado)
        {
            labelResultado.Text = resultado.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
