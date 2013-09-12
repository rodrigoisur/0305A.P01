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
    public partial class Form3 : Form
    {

        string operacion;
        double numero;
        public Form3()
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
            
            operacion = Convert.ToString(rbtncel.Checked  );
            if (rbtncel.Checked)
            {
                numero  = double.Parse(txtnum.Text);
                numero  = 5.0 / 9.0 * ( numero - 32);
                lblrpta.Text = numero.ToString();
                            
            }


            operacion = Convert.ToString(rbtnfa.Checked);
            if (rbtnfa.Checked)
            {
                numero  = double.Parse(txtnum.Text);
                numero  = numero  * 9 / 5 + 32;
                lblrpta.Text = numero.ToString();

            }



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();


        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnum.Text = "";
            lblrpta.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rbtncel.Checked = true;

        }

        
    }
}
