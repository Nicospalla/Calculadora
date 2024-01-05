using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmPrincipal : Form
    {

        float numeroA;
        float numeroB;
        int bandera;
        public frmPrincipal()
        {
            InitializeComponent();
            lblResultado.Text = lblResultado.Text == "NUMERO" ? "0" : lblResultado.Text;
        }
        private void refreshPantalla()
        {
            var renovado = lblResultado.Text;
            if (lblResultado.Text.StartsWith("0"))
            {
                char[] numeros = renovado.ToCharArray();
                renovado = new string(numeros,1,numeros.Length -1);

            }
            lblResultado.Text = renovado;
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblResultado.Text += 1;
            refreshPantalla();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblResultado.Text += 2;
            refreshPantalla();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            bandera = 1;
            numeroA =int.Parse(lblResultado.Text);
            numeroB = 0;
            lblResultado.Text = numeroB.ToString();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numeroB = int.Parse(lblResultado.Text);
            switch (bandera)
            {
                case 1:
                    lblResultado.Text = (numeroA + numeroB).ToString();
                    break;

            }
        }
    }
}
