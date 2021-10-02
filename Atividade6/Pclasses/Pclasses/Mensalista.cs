using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    class Mensalista : Empregado // especialização -> herança 
    {
        public double SalarioMensal { get; set; }

        // sobreescrevendo o metodo
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
        // construto -> new
        public Mensalista()
        {
            System.Windows.Forms.MessageBox.Show("Passei por aqui");

        }
        public Mensalista(double x)
        {

        }
        public Mensalista(int matx , string nomex , DateTime datax , double salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }

        public int soma (int x , int y)
        {
            return x + y;
        }

        public int soma (int a , int b , int c)
        {
            return a + b + c;
        }

    }
}
