using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            double num1, num2;
            int numero1, numero2;
            Random random = new Random();

            if (double.TryParse(txtNum1.Text, out num1) &&
                double.TryParse(txtNum2.Text, out num2))
            {
                numero1 = Convert.ToInt32(num1);
                numero2 = Convert.ToInt32(num2);

                if (numero1 < numero2)
                {
                    double r = random.Next(numero1, numero2);
                    MessageBox.Show(r.ToString());
                }
                else
                    MessageBox.Show("Número 1 não pode ser maior que número 2");
            }

            else
                MessageBox.Show("Números Inválidos");
        }
    }
}
