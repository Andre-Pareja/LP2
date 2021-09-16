using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        double Peso, Altura, IMC;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Peso = Convert.ToDouble(maskedTextBox1.Text);
            Altura = Convert.ToDouble(maskedTextBox2.Text);

            IMC = Peso / (Altura * Altura);
            
            
            maskedTextBox3.Text = Convert.ToString(Math.Round(IMC, 2));

            if (IMC <= 18.5)
            {
                MessageBox.Show("A Classificação do seu IMC é : Magreza" , "Calculo do IMC" );
            }
            else
            {
                if(IMC <= 24.9)
                {
                    MessageBox.Show("A Classificação do seu IMC é : Normal" , "Calculo do IMC");
                }
                else
                {
                    if(IMC <= 29.9)
                    {
                        MessageBox.Show("A Classificação do seu IMC é : Sobrepeso", "Calculo do IMC");
                    }
                    else
                    {
                        if(IMC <= 39.9)
                        {
                            MessageBox.Show("A Classificação do seu IMC é : Obesidade", "Calculo do IMC");
                        }
                        else
                        {
                            MessageBox.Show("A Classificação do seu IMC é : Obesidade Grave", "Calculo do IMC");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
        }
    }
}
