using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        String operador;

        Clases.Suma Obj = new Clases.Suma();
        Clases.Resta Obj2 = new Clases.Resta();
        Clases.Multiplicacion Obj3 = new Clases.Multiplicacion();
        Clases.Division Obj4 = new Clases.Division();

        //COMENTARIO PARA GIT
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txbScreen.Text = txbScreen.Text + ",";
        }

        //BOTONES DE OPERACION.
        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txbScreen.Text.Length < 1)
            {
                txbScreen.Clear();
            }
            else
            {
                operador = "+";
                primero = double.Parse(txbScreen.Text);
                txbScreen.Clear();
            }
            
        }

        private void btnResta_Click(object sender, EventArgs e)
        {

            if (txbScreen.Text.Length < 1)
            {
                txbScreen.Clear();
            }
            else
            {
                operador = "-";
                primero = double.Parse(txbScreen.Text);
                txbScreen.Clear();
            }
            
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (txbScreen.Text.Length < 1)
            {
                txbScreen.Clear();
            }
            else
            {
                operador = "*";
                primero = double.Parse(txbScreen.Text);
                txbScreen.Clear();
            }
            
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txbScreen.Text.Length < 1)
            {
                txbScreen.Clear();
            }
            else
            {
                operador = "/";
                primero = double.Parse(txbScreen.Text);
                txbScreen.Clear();
            }
                
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            

            double sum;
            double res;
            double mul;
            double div;
            if (txbScreen.Text.Length < 1)
            {
                txbScreen.Clear();
            } else
            {
                segundo = double.Parse(txbScreen.Text);
                switch (operador)
                {
                    case "+":
                        sum = Obj.Sumar((primero), (segundo));
                        txbScreen.Text = sum.ToString();
                        break;
                    case "-":
                        res = Obj2.Restar((primero), (segundo));
                        txbScreen.Text = res.ToString();
                        break;
                    case "*":
                        mul = Obj3.Multiplicar((primero), (segundo));
                        txbScreen.Text = mul.ToString();
                        break;
                    case "/":
                        div = Obj4.Dividir((primero), (segundo));
                        txbScreen.Text = div.ToString();
                        break;

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txbScreen.Text.Length == 1)
            {
                txbScreen.Text = "";
            } else
            {
                if (txbScreen.Text.Length > 1)
                {
                    txbScreen.Text = txbScreen.Text.Substring(0, txbScreen.Text.Length - 1);
                }
                else
                {
                    txbScreen.Clear();
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txbScreen.Clear();
        }
    }
}
