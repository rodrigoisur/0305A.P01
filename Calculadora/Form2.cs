using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        bool operacion = true;
        string operando;
        double respuesta;
        double numero;
        double numero1;
        public Form2()
        {
            InitializeComponent();
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                txtoper.Text = "";
                txtoper.Text = "7";
                operacion = false;

            }
            else
            {
                txtoper.Text = txtoper.Text + "7";
            }
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                txtoper.Text = "";
                txtoper.Text = "8";
                operacion = false;

            }
            else
            {
                txtoper.Text = txtoper.Text + "8";
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                txtoper.Text = "";
                txtoper.Text = "9";
                operacion = false;

            }
            else
            {
                txtoper.Text = txtoper.Text + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                txtoper.Text = "";
                txtoper.Text = "4";
                operacion = false;

            }
            else
            {
                txtoper.Text = txtoper.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                txtoper.Text = "";
                txtoper.Text = "5";
                operacion = false;

            }
            else
            {
                txtoper.Text = txtoper.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                txtoper.Text = "";
                txtoper.Text = "6";
                operacion = false;

            }
            else
            {
                txtoper.Text = txtoper.Text + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                txtoper.Text = "";
                txtoper.Text = "1";
                operacion = false;

            }
            else
            {
                txtoper.Text = txtoper.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                txtoper.Text = "";
                txtoper.Text = "2";
                operacion = false;

            }
            else
            {
                txtoper.Text = txtoper.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                txtoper.Text = "";
                txtoper.Text = "3";
                operacion = false;

            }
            else
            {
                txtoper.Text = txtoper.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtoper.Text == "0")
            {
                return;             
            }
                else
            {
                txtoper .Text=txtoper .Text+"0";
            }           
            
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txtoper.Text = "";

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operando = "+";
            operacion = true;
            numero = double.Parse(txtoper.Text);

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operando = "-";
            operacion = true;
            numero = double.Parse(txtoper.Text);
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operando = "*";
            operacion = true;
            numero = double.Parse(txtoper.Text);
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operando = "/";
            operacion = true;
            numero = double.Parse(txtoper.Text);
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txtoper.Text);
            operacion   = true;
            switch(operando  ) 
            
            {
                case "+":
                    respuesta =numero+numero1 ;
                    txtoper.Text=respuesta .ToString() ;
                    break;
                case "-":
                    respuesta = numero - numero1;
                    txtoper.Text=respuesta .ToString() ;
                    break;
                case "*":
                    respuesta = numero * numero1;
                    txtoper.Text = respuesta.ToString();
                    break;
                case "/":
                    respuesta = numero / numero1;
                    txtoper.Text = respuesta.ToString();
                    break;

            
            }


        }

        private void btnp_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                txtoper.Text = "";
                txtoper.Text = ".";
                operacion = false;

            }
            else
            {
                txtoper.Text = txtoper.Text + ".";
            }
        }

        

        
    }
}
