
namespace tp_03_ejercicio_02
{
    partial class Form1
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
            this.textBoxValor00 = new System.Windows.Forms.TextBox();
            this.textBoxValor01 = new System.Windows.Forms.TextBox();
            this.buttonAgregarValor = new System.Windows.Forms.Button();
            this.buttonConsigna = new System.Windows.Forms.Button();
            this.labelValor00 = new System.Windows.Forms.Label();
            this.labelValor01 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxValor00
            // 
            this.textBoxValor00.Location = new System.Drawing.Point(104, 46);
            this.textBoxValor00.Name = "textBoxValor00";
            this.textBoxValor00.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor00.TabIndex = 0;
            // 
            // textBoxValor01
            // 
            this.textBoxValor01.Location = new System.Drawing.Point(104, 72);
            this.textBoxValor01.Name = "textBoxValor01";
            this.textBoxValor01.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor01.TabIndex = 1;
            // 
            // buttonAgregarValor
            // 
            this.buttonAgregarValor.Location = new System.Drawing.Point(210, 41);
            this.buttonAgregarValor.Name = "buttonAgregarValor";
            this.buttonAgregarValor.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarValor.TabIndex = 2;
            this.buttonAgregarValor.Text = "Calcular";
            this.buttonAgregarValor.UseVisualStyleBackColor = true;
            this.buttonAgregarValor.Click += new System.EventHandler(this.buttonAgregarValor_Click);
            // 
            // buttonConsigna
            // 
            this.buttonConsigna.Location = new System.Drawing.Point(210, 70);
            this.buttonConsigna.Name = "buttonConsigna";
            this.buttonConsigna.Size = new System.Drawing.Size(75, 23);
            this.buttonConsigna.TabIndex = 3;
            this.buttonConsigna.Text = "Consigna";
            this.buttonConsigna.UseVisualStyleBackColor = true;
            this.buttonConsigna.Click += new System.EventHandler(this.buttonConsigna_Click);
            // 
            // labelValor00
            // 
            this.labelValor00.AutoSize = true;
            this.labelValor00.Location = new System.Drawing.Point(12, 49);
            this.labelValor00.Name = "labelValor00";
            this.labelValor00.Size = new System.Drawing.Size(89, 13);
            this.labelValor00.TabIndex = 4;
            this.labelValor00.Text = "Ingresar un valor:";
            // 
            // labelValor01
            // 
            this.labelValor01.AutoSize = true;
            this.labelValor01.Location = new System.Drawing.Point(12, 75);
            this.labelValor01.Name = "labelValor01";
            this.labelValor01.Size = new System.Drawing.Size(89, 13);
            this.labelValor01.TabIndex = 5;
            this.labelValor01.Text = "Ingresar un valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "---------------------------------";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(136, 108);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 178);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelValor01);
            this.Controls.Add(this.labelValor00);
            this.Controls.Add(this.buttonConsigna);
            this.Controls.Add(this.buttonAgregarValor);
            this.Controls.Add(this.textBoxValor01);
            this.Controls.Add(this.textBoxValor00);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 03 - Ejercicio 02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValor00;
        private System.Windows.Forms.TextBox textBoxValor01;
        private System.Windows.Forms.Button buttonAgregarValor;
        private System.Windows.Forms.Button buttonConsigna;
        private System.Windows.Forms.Label labelValor00;
        private System.Windows.Forms.Label labelValor01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultado;
    }
}

