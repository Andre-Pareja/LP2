using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        double Valor1, Valor2, Total;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Valor1 = Convert.ToDouble(textBox1.Text);
                Valor2 = Convert.ToDouble(textBox2.Text);

                Total = Valor1 - Valor2;

                textBox3.Text = Convert.ToString(Total);
            }
            else
            {
                MessageBox.Show("Informe valores nos campos 'Numero1' e 'Numero2'", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Valor1 = Convert.ToDouble(textBox1.Text);
                Valor2 = Convert.ToDouble(textBox2.Text);

                Total = Valor1 * Valor2;

                textBox3.Text = Convert.ToString(Total);
            }
            else
            {
                MessageBox.Show("Informe valores nos campos 'Numero1' e 'Numero2'", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
         
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Valor1 = Convert.ToDouble(textBox1.Text);
                Valor2 = Convert.ToDouble(textBox2.Text);
               
                Total = Valor1 / Valor2;

                textBox3.Text = Convert.ToString(Total);
            }
            else
            {
                MessageBox.Show("Informe valores nos campos 'Numero1' e 'Numero2'", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Valor1 = Convert.ToDouble(textBox1.Text);
                Valor2 = Convert.ToDouble(textBox2.Text);

                Total = Valor1 + Valor2;

                textBox3.Text = Convert.ToString(Total);
            }
            else
            {
                MessageBox.Show("Informe valores nos campos 'Numero1' e 'Numero2'" , "Calculadora" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }
}
