using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_Cap3_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBox1.SelectedItem.ToString().Trim().ToLower();

            if (opcion == "perímetro")
            {
                CalcularPerimetro();
            }
            else if (opcion == "área")
            {
                CalcularArea();
            }
            else
            {
                MessageBox.Show("Opción no válida. Por favor, escriba 'perímetro' o 'área'.");
                return;
            }
        }
            private void CalcularPerimetro()
            {
                
                int numeroLados;
                if (!int.TryParse(textBox4.Text, out numeroLados) || numeroLados < 3)
                {
                MessageBox.Show("Número de lados inválido. Por favor, ingrese un número entero mayor o igual a 3:");
                return;
                }

                
                double longitudLado;
                if (!double.TryParse(textBox5.Text, out longitudLado) || longitudLado <= 0)
                {
                MessageBox.Show("Longitud de lado inválida. Por favor, ingrese un número real mayor que 0:");
                return;
                }

                double perimetro = numeroLados * longitudLado;
               label10.Text = ($"El perímetro del polígono es: {perimetro}");
            }

            private void CalcularArea()
            {
               
                int numeroLados;
                if (!int.TryParse(textBox1.Text, out numeroLados) || numeroLados < 3)
                {
                    MessageBox.Show("Número de lados inválido. Por favor, ingrese un número entero mayor o igual a 3:");
                return;
                }

                
                double longitudLado;
                if (!double.TryParse(textBox2.Text, out longitudLado) || longitudLado <= 0)
                {
                    MessageBox.Show("Longitud de lado inválida. Por favor, ingrese un número real mayor que 0:");
                return;
                }

                double apotema;
                
                if (!double.TryParse(textBox3.Text, out apotema) || apotema <= 0)
                {
                    MessageBox.Show("Longitud de apotema inválida. Por favor, ingrese un número real mayor que 0:");
                return;
                }

                double area = (numeroLados * longitudLado * apotema) / 2;
                label9.Text = ($"El área del polígono es: {area}");

            }
    }
}
