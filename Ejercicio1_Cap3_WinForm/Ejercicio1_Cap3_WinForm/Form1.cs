using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Cap3_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int X;

            //Leer el número dado por el usuario

            while (!int.TryParse(textBox1.Text, out X) || X < 0)
            {
                MessageBox.Show("El numero dado por el usuario es invalido. Favor de ingresar un numero mayor a 0");
                MessageBox.Show("Digame otro numero:");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X;

            if (!int.TryParse(textBox1.Text, out X))
            {
                MessageBox.Show("NÚMERO INVALIDO. FAVOR DE INGRESAR OTRO NUMERO.");
                return;
            }

            //Detención Par e Impar
            if ((X % 2) == 0)
            {
                MessageBox.Show("El numero es Par");
            }
            else
            {
                MessageBox.Show("El numero es Impar");
            }
        }
    }
}
