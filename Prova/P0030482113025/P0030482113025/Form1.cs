using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P0030482113025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] Semana = new double[4];
            double TotalMes = 0, Total = 0, aux1 = 0;
            int i, j;
            string aux2 = "";
            double aux3 = 0;



            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    aux2 = Interaction.InputBox("Total vendido na " +
                     (j + 1) + "ª semana".ToString(), (i + 1) + "º mês");

                    if (!double.TryParse(aux2, out Semana[j]))

                    {
                        MessageBox.Show("Numero invalido,digite novamente!");
                        j--;

                    }
                    else
                    {
                        aux1 = Semana[j];
                        TotalMes += Semana[j];
                        aux3 = TotalMes;



                    }

                    Total += aux1;
                    listBox1.Items.Insert(0, "Total do mês " + (i + 1).ToString() + " Semana " + (j + 1).ToString() + " " + aux1.ToString("C2"));


                }


                listBox1.Items.Insert(0, " " + "Total do mês " + " " + TotalMes.ToString("C2"));
                listBox1.Items.Insert(0, "------------------------------------------------------");
                TotalMes -= aux3;

            }
        }

    }
}
