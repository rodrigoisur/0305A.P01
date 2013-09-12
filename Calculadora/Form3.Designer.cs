namespace Calculadora
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnum = new System.Windows.Forms.TextBox();
            this.rbtncel = new System.Windows.Forms.RadioButton();
            this.rbtnfa = new System.Windows.Forms.RadioButton();
            this.rbtnkelvin = new System.Windows.Forms.RadioButton();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.lblrpta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(71, 52);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 0;
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
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(25, 183);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir.TabIndex = 2;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // lblrpta
            // 
            this.lblrpta.AutoSize = true;
            this.lblrpta.Location = new System.Drawing.Point(86, 224);
            this.lblrpta.Name = "lblrpta";
            this.lblrpta.Size = new System.Drawing.Size(0, 13);
            this.lblrpta.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnkelvin);
            this.groupBox1.Controls.Add(this.rbtnfa);
            this.groupBox1.Controls.Add(this.rbtncel);
            this.groupBox1.Location = new System.Drawing.Point(71, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convertir a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el grado de la temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Respuesta :";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(106, 183);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 7;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(187, 183);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblrpta);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtnum);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.RadioButton rbtncel;
        private System.Windows.Forms.RadioButton rbtnfa;
        private System.Windows.Forms.RadioButton rbtnkelvin;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label lblrpta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnsalir;
    }
}