namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnkelvin = new System.Windows.Forms.RadioButton();
            this.rbtnfa = new System.Windows.Forms.RadioButton();
            this.rbtncel = new System.Windows.Forms.RadioButton();
            this.lblrpta = new System.Windows.Forms.Label();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnk1 = new System.Windows.Forms.RadioButton();
            this.rbtnf1 = new System.Windows.Forms.RadioButton();
            this.rbtnc1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(259, 182);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(155, 182);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 15;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Respuesta :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese el grado de la temperatura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnkelvin);
            this.groupBox1.Controls.Add(this.rbtnfa);
            this.groupBox1.Controls.Add(this.rbtncel);
            this.groupBox1.Location = new System.Drawing.Point(199, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 90);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convertir a:";
            // 
            // rbtnkelvin
            // 
            this.rbtnkelvin.AutoSize = true;
            this.rbtnkelvin.Location = new System.Drawing.Point(18, 67);
            this.rbtnkelvin.Name = "rbtnkelvin";
            this.rbtnkelvin.Size = new System.Drawing.Size(54, 17);
            this.rbtnkelvin.TabIndex = 1;
            this.rbtnkelvin.TabStop = true;
            this.rbtnkelvin.Text = "Kelvin";
            this.rbtnkelvin.UseVisualStyleBackColor = true;
            // 
            // rbtnfa
            // 
            this.rbtnfa.AutoSize = true;
            this.rbtnfa.Location = new System.Drawing.Point(18, 44);
            this.rbtnfa.Name = "rbtnfa";
            this.rbtnfa.Size = new System.Drawing.Size(75, 17);
            this.rbtnfa.TabIndex = 1;
            this.rbtnfa.TabStop = true;
            this.rbtnfa.Text = "Fahrenheit";
            this.rbtnfa.UseVisualStyleBackColor = true;
            // 
            // rbtncel
            // 
            this.rbtncel.AutoSize = true;
            this.rbtncel.Location = new System.Drawing.Point(18, 19);
            this.rbtncel.Name = "rbtncel";
            this.rbtncel.Size = new System.Drawing.Size(58, 17);
            this.rbtncel.TabIndex = 1;
            this.rbtncel.TabStop = true;
            this.rbtncel.Text = "Celsius";
            this.rbtncel.UseVisualStyleBackColor = true;
            // 
            // lblrpta
            // 
            this.lblrpta.AutoSize = true;
            this.lblrpta.Location = new System.Drawing.Point(196, 226);
            this.lblrpta.Name = "lblrpta";
            this.lblrpta.Size = new System.Drawing.Size(0, 13);
            this.lblrpta.TabIndex = 11;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(57, 182);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir.TabIndex = 10;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(39, 44);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnk1);
            this.groupBox2.Controls.Add(this.rbtnf1);
            this.groupBox2.Controls.Add(this.rbtnc1);
            this.groupBox2.Location = new System.Drawing.Point(39, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // rbtnk1
            // 
            this.rbtnk1.AutoSize = true;
            this.rbtnk1.Location = new System.Drawing.Point(18, 67);
            this.rbtnk1.Name = "rbtnk1";
            this.rbtnk1.Size = new System.Drawing.Size(54, 17);
            this.rbtnk1.TabIndex = 1;
            this.rbtnk1.TabStop = true;
            this.rbtnk1.Text = "Kelvin";
            this.rbtnk1.UseVisualStyleBackColor = true;
            // 
            // rbtnf1
            // 
            this.rbtnf1.AutoSize = true;
            this.rbtnf1.Location = new System.Drawing.Point(18, 44);
            this.rbtnf1.Name = "rbtnf1";
            this.rbtnf1.Size = new System.Drawing.Size(75, 17);
            this.rbtnf1.TabIndex = 1;
            this.rbtnf1.TabStop = true;
            this.rbtnf1.Text = "Fahrenheit";
            this.rbtnf1.UseVisualStyleBackColor = true;
            // 
            // rbtnc1
            // 
            this.rbtnc1.AutoSize = true;
            this.rbtnc1.Location = new System.Drawing.Point(18, 19);
            this.rbtnc1.Name = "rbtnc1";
            this.rbtnc1.Size = new System.Drawing.Size(58, 17);
            this.rbtnc1.TabIndex = 1;
            this.rbtnc1.TabStop = true;
            this.rbtnc1.Text = "Celsius";
            this.rbtnc1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingrese la temperatura e indique su escala";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblrpta);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtnum);
            this.Name = "Form1";
            this.Text = "Calculadora1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnkelvin;
        private System.Windows.Forms.RadioButton rbtnfa;
        private System.Windows.Forms.RadioButton rbtncel;
        private System.Windows.Forms.Label lblrpta;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnk1;
        private System.Windows.Forms.RadioButton rbtnf1;
        private System.Windows.Forms.RadioButton rbtnc1;
        private System.Windows.Forms.Label label3;

    }
}

