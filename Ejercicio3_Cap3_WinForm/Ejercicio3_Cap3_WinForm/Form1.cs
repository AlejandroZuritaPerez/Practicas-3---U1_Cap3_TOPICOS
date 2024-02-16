using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_Cap3_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una opción válida.");
                return;
            }

            string respuesta = comboBox1.SelectedItem.ToString().Trim().ToLower();

            if (respuesta == "si")
            {
                MessageBox.Show("El producto es medicina. El impuesto es del 0%.");
                return;
            }
            else if (respuesta == "no")
            {
                double precio;
                if (!double.TryParse(textBox1.Text, out precio) || precio < 0)
                {
                    MessageBox.Show("Precio inválido. Por favor, ingrese un número válido mayor o igual a 0:");
                    return;
                }
                CalcularImpuesto(precio);
            }
            else
            {
                MessageBox.Show("Respuesta no válida. Por favor, responda 'si' o 'no'.");
                return;
            }
        }

        private void CalcularImpuesto(double precio)
        {
            // Si el producto no es medicina, el impuesto es del 16%
            double impuesto = precio * 0.16;
            double precioTotal = precio + impuesto;
            label4.Text = ($"El impuesto del producto es del 16%.");
            label5.Text = ($"El impuesto a pagar es: {impuesto:C}");
            label6.Text = ($"El precio total a pagar es: {precioTotal:C}");

            // Llama al método MostrarResultado con el precio total calculado
            MostrarResultado(precioTotal);
        }

        // Mostrar resultado
        private void MostrarResultado(double resultado)
        {
             resultado.ToString();
             resultado.ToString();
             resultado.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
