using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operacion;
        double numero;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            if (txtnum.Text == "")
            {
                MessageBox.Show("Ingrese un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
                    
            operacion = Convert.ToString(rbtnkelvin.Checked);
            if (rbtnc1.Checked & rbtnkelvin.Checked )
            {
                lblrpta .Text = Convert.ToString(Convert.ToDouble(Convert.ToDouble  (txtnum.Text) + 273));                
            }

            operacion = Convert.ToString(rbtncel.Checked);
            if (rbtnk1.Checked & rbtncel.Checked)
            {
                lblrpta.Text = Convert.ToString(Convert.ToDouble(Convert.ToDouble(txtnum.Text) - 273));
            }

            operacion = Convert.ToString(rbtncel.Checked);
            if (rbtnf1.Checked & rbtncel.Checked)
            {
                lblrpta.Text = Convert.ToString(Convert.ToDouble(Convert.ToDouble(txtnum.Text) - 32)/1.8);
            }

            operacion = Convert.ToString(rbtnfa.Checked);
            if (rbtnc1.Checked & rbtnfa.Checked)
            {
                lblrpta.Text = Convert.ToString(Convert.ToDouble(1.8*Convert.ToDouble(txtnum.Text) + 32));
            }

            operacion = Convert.ToString(rbtnkelvin.Checked);
            if (rbtnf1.Checked & rbtnkelvin.Checked)
            {
                lblrpta.Text = Convert.ToString(Convert.ToDouble((5 / 9) * (Convert.ToDouble(txtnum.Text) - 32) + 273));
            }

            operacion = Convert.ToString(rbtnfa.Checked);
            if (rbtnk1.Checked & rbtnfa.Checked)
            {
                lblrpta.Text = Convert.ToString(Convert.ToDouble((9 / 5) * (Convert.ToDouble(txtnum.Text) - 273) + 32));
            }          
           
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnum.Text = "";
            lblrpta.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtncel.Checked = true;

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        
   
    }
}
