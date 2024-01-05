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
            if (lblResultado.Text.StartsWith("0") && !lblResultado.Text.Contains(","))
            {
                char[] numeros = renovado.ToCharArray();
                renovado = new string(numeros,1,numeros.Length -1);

            }
            lblResultado.Text = renovado;
            
        }


        private void btnSumar_Click(object sender, EventArgs e)
        {
            bandera = 1;
            intercambio();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            bandera = 2;
            intercambio();
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            bandera = 3; intercambio();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            bandera = 4; intercambio();
        }
        private void intercambio()
        {
            numeroA = float.Parse(lblResultado.Text);
            numeroB = 0;
            lblResultado.Text = numeroB.ToString();
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            numeroB = float.Parse(lblResultado.Text);
            switch (bandera)
            {
                case 1:
                    lblResultado.Text = (numeroA + numeroB).ToString();
                    break;
                case 2: 
                    lblResultado.Text = (numeroA - numeroB).ToString();
                    break;
                case 3:
                    lblResultado.Text = (numeroA * numeroB).ToString();
                    break;
                case 4:
                    lblResultado.Text = (numeroA / numeroB).ToString();
                    break;
            }
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
        private void btn3_Click(object sender, EventArgs e)
        {
            lblResultado.Text += 3;
            refreshPantalla();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            lblResultado.Text += 4;
            refreshPantalla();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblResultado.Text += 5;
            refreshPantalla();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblResultado.Text += 6;
            refreshPantalla();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblResultado.Text += 7;
            refreshPantalla();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblResultado.Text += 8;
            refreshPantalla();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblResultado.Text += 9;
            refreshPantalla();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            lblResultado.Text += 0;
            refreshPantalla();
        }



        private void btnBorraTodo_Click(object sender, EventArgs e)
        {
            numeroA = 0;
            numeroB = 0;
            lblResultado.Text = "0";
        }

        private void btnBorra_Click(object sender, EventArgs e)
        {
            if (numeroA != 0) 
            {
                numeroB = 0;
            }
            else
            {
                numeroA = 0;
            }
            lblResultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text.Length > 0 && !lblResultado.Text.Contains("."))
            {
                lblResultado.Text += ",";
            }
        }
    }
}
