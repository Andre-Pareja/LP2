using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_4
{
    public partial class Form1 : Form
    {
        double LadoA, LadoB, LadoC ;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(textBox1.Text, out LadoA) ||
                !double.TryParse(textBox2.Text, out LadoB) ||
                !double.TryParse(textBox3.Text, out LadoC))
            {
                MessageBox.Show("Os valores devem ser numerais");
            }
            else
            {
                if(LadoA < (LadoB + LadoC) && 
                    LadoA > Math.Abs(LadoB - LadoC) && 
                    LadoB < (LadoA + LadoC) && 
                    LadoB > Math.Abs (LadoA - LadoC) && 
                    LadoC < (LadoA + LadoB) && 
                    LadoC > Math.Abs (LadoA - LadoB))
                {
                    if( LadoA == LadoB && LadoB == LadoC)
                    {
                        MessageBox.Show("O triângulo é equilatero" , "Exercicio 4");

                    }
                    else
                    {
                        if(LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
                        {
                            MessageBox.Show("O triângulo é isoceles", "Exercicio 4");
                        }
                        else
                        {
                            MessageBox.Show("O triângulo é escaleno", "Exercicio 4");
                        }
                        
                    }

                }
                else
                {
                    MessageBox.Show("Os valores inseridos não formam um triangulo!" , "Exercicio 4");
                }
            }


        }
    }
}
