using System;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
            double Salario , SalLiq , DescontInss, DescontIrpf , SalFamilia , filhos;
            SalFamilia = 0;
            DescontInss = 0;

            if (!double.TryParse(maskedTextBox1.Text, out Salario))
            {
                MessageBox.Show("Os valores devem ser numerais");
            }
            else { 
                if (Salario <= 800.47)
                {
                    textBox2.Text = "7.65%";
                    DescontInss = (Salario * 0.0765);
                    textBox3.Text = Convert.ToString(DescontInss);


                }
                else
                {
                    if (Salario <= 1050)
                    {
                        textBox2.Text = "8.65%";
                        DescontInss = (Salario * 0.0865);
                        textBox3.Text = Convert.ToString(DescontInss);

                    }
                    else
                    {
                        if (Salario <= 1400.77)
                        {
                            textBox2.Text = "9.00%";
                            DescontInss = (Salario * 0.09);
                            textBox3.Text = Convert.ToString(DescontInss);

                        }
                        else
                        {
                            if (Salario <= 2801.56)
                            {
                                textBox2.Text = "11.00%";
                                DescontInss = (Salario * 0.011);
                                textBox3.Text = Convert.ToString(DescontInss);


                            }
                            else
                            {
                                textBox2.Text = "TETO(308.17)";
                                DescontInss = 308.617;
                                textBox3.Text = Convert.ToString(DescontInss);

                            }
                        }
                    }
                }
            }
           
            if(Salario <= 1257.12)
            {
                textBox4.Text = "Isento";
                DescontIrpf = 0;
                textBox5.Text = Convert.ToString(DescontIrpf);
            }
            else
            {
                if(Salario <= 2512.08)
                {
                    textBox4.Text = "15%";
                    DescontIrpf = Salario * 0.15;
                    textBox5.Text = Convert.ToString(DescontIrpf);
                }
                else
                {
                    textBox4.Text = "27.5%";
                    DescontIrpf = Salario * 0.275;
                    textBox5.Text = Convert.ToString(DescontIrpf);
                }
            }
            if (!double.TryParse(maskedTextBox2.Text, out filhos))
            {
                MessageBox.Show("Os valores devem ser preenchidos com numerais");
            }
            else
            {
                if(Salario <= 435.52)
                {
                    SalFamilia = filhos * 22.33;
                    textBox7.Text = Convert.ToString(SalFamilia);
                }
                else
                {
                    if(Salario <= 654.61)
                    {
                        SalFamilia = filhos * 15.74;
                        textBox7.Text = Convert.ToString(SalFamilia);

                    }
                    else
                    {
                        SalFamilia = 0 * 0;
                        textBox7.Text = Convert.ToString(SalFamilia);

                    }
                }
            }
            SalLiq = (Salario + SalFamilia) - (DescontInss + DescontIrpf);
            textBox6.Text = Convert.ToString(SalLiq);
            

            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
