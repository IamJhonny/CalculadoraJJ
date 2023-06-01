using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraJJ
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int.TryParse(txtNum1.Text, out num1);
            int.TryParse(txtNum2.Text, out num2);

            int res = num1 + num2;

            txtResultado.Text = res.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int.TryParse(txtNum1.Text, out num1);
            int.TryParse(txtNum2.Text, out num2);

            int res = num1 - num2;

            txtResultado.Text = res.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int.TryParse(txtNum1.Text, out num1);
            int.TryParse(txtNum2.Text, out num2);

            int res = num1 * num2;

            txtResultado.Text = res.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int.TryParse(txtNum1.Text, out num1);
            int.TryParse(txtNum2.Text, out num2);

            int res = num1 / num2;

            txtResultado.Text = res.ToString();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int.TryParse(txtNum1.Text, out num1);
            int.TryParse(txtNum2.Text, out num2);

            int res = (num1 + num2) / 2;

            txtResultado.Text = res.ToString();
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int.TryParse(txtNum1.Text, out num1);
            int.TryParse(txtNum2.Text, out num2);

            int res = num1 - num2;

            if (res < 0)
            {
                txtResultado.Text = "Este es un número negativo (menor a -0)";

            }
            else
            {
                txtResultado.Text = "Es un número positivo (mayor a +0)";
            }
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int.TryParse(txtNum1.Text, out num1);
            int.TryParse(txtNum2.Text, out num2);

            int res = num1 + num2;

            if (res > 0)
            {
                txtResultado.Text = "Este es un número positivo (mayor a +0)";

            }
            else
            {
                txtResultado.Text = "Es un número negativo (menor a -0)";
            }
        }

        private void btnEQL_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int.TryParse(txtNum1.Text, out num1);
            int.TryParse(txtNum2.Text, out num2);

            int res = (num1 + num2) / 2;

            txtResultado.Text = res.ToString();

            if (res >= 90 || res == 100)
            {
             txtResultado.Text = "Excelente, su calificación es una 'A' :) ";
            }
            else if (res <= 89 && res >= 80)
            {
             txtResultado.Text = "Felicidades, su calificación es una 'B' ";
            }
            else if (res <= 79 && res >= 70)
            {
             txtResultado.Text = "Bien, su calificación es una 'C' ";
            }
            else if (res <= 69)
            {
             txtResultado.Text = "Lo siento, su calificación es una 'F' has reprobado :( ";
            }
            else
            {
                Console.WriteLine("Este es su equivalente literal");
            }
        }
    }
}
