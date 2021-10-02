using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = textNomeH.Text;
            objHorista.Matricula = Convert.ToInt32(textMatriculaH.Text);
            objHorista.SalarioHora = Convert.ToDouble(textSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(textNumerosHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(textDataEntradaH.Text);
            objHorista.DiasFalta = Convert.ToInt32(textDiasFaltaH.Text);

            MessageBox.Show("Nome                 :" + objHorista.NomeEmpregado + "\n" +
                            "matricula            :" + objHorista.Matricula + "\n" +
                            "Tempo Trabalho (dias):" + objHorista.TempoTrabalho().ToString() + "\n" +
                            "Salario              :" + objHorista.SalarioBruto().ToString("N2"));
        }
    }
}
