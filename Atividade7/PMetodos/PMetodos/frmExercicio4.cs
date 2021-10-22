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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnnumero_Click(object sender, EventArgs e)
        {
            int i;
            double qtdeNum = 0;
            char[] vetorTexto = rchtxtTexto.Text.ToCharArray();

            for (i = 0; i < rchtxtTexto.Text.Length; i++)
            {
                if (char.IsNumber(vetorTexto[i]))
                    qtdeNum++;
            }
            MessageBox.Show("No texto há " + qtdeNum.ToString() + " números");
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            int i = 0, qtdeBranco = 0;
            char[] vetorBranco = rchtxtTexto.Text.ToCharArray();
            bool x = true;

            while (x)
            {
                if (Char.IsWhiteSpace(vetorBranco[i]))
                {
                    qtdeBranco = i;
                    x = false;
                }

                i++;
            }
            MessageBox.Show("O primeiro espaço está na casa número: " + qtdeBranco);
        }

        private void btnCaracteres_Click(object sender, EventArgs e)
        {
            int i = 0, qtdeletras = 0;
            char[] vetorLetras = rchtxtTexto.Text.ToCharArray();

            foreach (char c in vetorLetras)
            {
                if (char.IsLetter(c))
                {
                    qtdeletras++;
                }
            }
            MessageBox.Show("A quatidade de caracteres do texto é: " + qtdeletras);
        }
    }
    
}
