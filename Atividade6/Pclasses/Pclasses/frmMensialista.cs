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
    public partial class frmMensialista : Form
    {
        public frmMensialista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // criar ou instancial o objeto mensalista
            Mensalista objMensalista = new Mensalista();

            MessageBox.Show(objMensalista.soma(2 , 3).ToString());


            objMensalista.Matricula = Convert.ToInt32(textMatricula.Text);
            objMensalista.NomeEmpregado = textNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(textDataEntrada.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(textSalarioMensal.Text);


            MessageBox.Show("Matricula      : " + objMensalista.Matricula + "\n" +
                            "Nome           : " + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada   : " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salario Bruto  : " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa(D):" + objMensalista.TempoTrabalho());
                            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(
                Convert.ToInt32(textMatricula.Text),
                textNome.Text,
                Convert.ToDateTime(textDataEntrada.Text),
                Convert.ToDouble(textSalarioMensal.Text));

            MessageBox.Show("Matricula      : " + objMensalista.Matricula + "\n" +
                            "Nome           : " + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada   : " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salario Bruto  : " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa(D):" + objMensalista.TempoTrabalho());

        }
    }
}
