
namespace tp_03_ejercicio_04
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
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonMultiplicacion = new System.Windows.Forms.Button();
            this.buttonPotencia = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonRaiz = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonConsigna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSuma
            // 
            this.buttonSuma.Location = new System.Drawing.Point(12, 38);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(83, 23);
            this.buttonSuma.TabIndex = 0;
            this.buttonSuma.Text = "Suma";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // buttonMultiplicacion
            // 
            this.buttonMultiplicacion.Location = new System.Drawing.Point(12, 67);
            this.buttonMultiplicacion.Name = "buttonMultiplicacion";
            this.buttonMultiplicacion.Size = new System.Drawing.Size(83, 23);
            this.buttonMultiplicacion.TabIndex = 1;
            this.buttonMultiplicacion.Text = "Multiplicación";
            this.buttonMultiplicacion.UseVisualStyleBackColor = true;
            this.buttonMultiplicacion.Click += new System.EventHandler(this.buttonMultiplicacion_Click);
            // 
            // buttonPotencia
            // 
            this.buttonPotencia.Location = new System.Drawing.Point(12, 96);
            this.buttonPotencia.Name = "buttonPotencia";
            this.buttonPotencia.Size = new System.Drawing.Size(83, 23);
            this.buttonPotencia.TabIndex = 2;
            this.buttonPotencia.Text = "Potencia";
            this.buttonPotencia.UseVisualStyleBackColor = true;
            this.buttonPotencia.Click += new System.EventHandler(this.buttonPotencia_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.Location = new System.Drawing.Point(101, 38);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(82, 23);
            this.buttonResta.TabIndex = 3;
            this.buttonResta.Text = "Resta";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(101, 67);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(82, 23);
            this.buttonDivision.TabIndex = 4;
            this.buttonDivision.Text = "División";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonRaiz
            // 
            this.buttonRaiz.Location = new System.Drawing.Point(101, 96);
            this.buttonRaiz.Name = "buttonRaiz";
            this.buttonRaiz.Size = new System.Drawing.Size(82, 23);
            this.buttonRaiz.TabIndex = 5;
            this.buttonRaiz.Text = "Raíz";
            this.buttonRaiz.UseVisualStyleBackColor = true;
            this.buttonRaiz.Click += new System.EventHandler(this.buttonRaiz_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(189, 15);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 6;
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(12, 12);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(83, 20);
            this.textBox0.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 8;
            // 
            // buttonConsigna
            // 
            this.buttonConsigna.Location = new System.Drawing.Point(189, 67);
            this.buttonConsigna.Name = "buttonConsigna";
            this.buttonConsigna.Size = new System.Drawing.Size(82, 23);
            this.buttonConsigna.TabIndex = 9;
            this.buttonConsigna.Text = "Consigna";
            this.buttonConsigna.UseVisualStyleBackColor = true;
            this.buttonConsigna.Click += new System.EventHandler(this.buttonConsigna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 139);
            this.Controls.Add(this.buttonConsigna);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonRaiz);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonPotencia);
            this.Controls.Add(this.buttonMultiplicacion);
            this.Controls.Add(this.buttonSuma);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 03 - Ejercicio 04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonMultiplicacion;
        private System.Windows.Forms.Button buttonPotencia;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonRaiz;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonConsigna;
    }
}

