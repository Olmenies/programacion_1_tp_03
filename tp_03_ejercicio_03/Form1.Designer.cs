
namespace tp_03_ejercicio_03
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.listBoxValores = new System.Windows.Forms.ListBox();
            this.buttonAgregarValor = new System.Windows.Forms.Button();
            this.buttonConsigna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonLimpiarListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 41);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // listBoxValores
            // 
            this.listBoxValores.FormattingEnabled = true;
            this.listBoxValores.Location = new System.Drawing.Point(129, 41);
            this.listBoxValores.Name = "listBoxValores";
            this.listBoxValores.Size = new System.Drawing.Size(120, 108);
            this.listBoxValores.TabIndex = 2;
            // 
            // buttonAgregarValor
            // 
            this.buttonAgregarValor.Location = new System.Drawing.Point(12, 67);
            this.buttonAgregarValor.Name = "buttonAgregarValor";
            this.buttonAgregarValor.Size = new System.Drawing.Size(100, 23);
            this.buttonAgregarValor.TabIndex = 3;
            this.buttonAgregarValor.Text = "Calcular";
            this.buttonAgregarValor.UseVisualStyleBackColor = true;
            this.buttonAgregarValor.Click += new System.EventHandler(this.buttonAgregarValor_Click);
            // 
            // buttonConsigna
            // 
            this.buttonConsigna.Location = new System.Drawing.Point(12, 125);
            this.buttonConsigna.Name = "buttonConsigna";
            this.buttonConsigna.Size = new System.Drawing.Size(100, 23);
            this.buttonConsigna.TabIndex = 4;
            this.buttonConsigna.Text = "Consigna";
            this.buttonConsigna.UseVisualStyleBackColor = true;
            this.buttonConsigna.Click += new System.EventHandler(this.buttonConsigna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresar un número:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(126, 152);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(60, 13);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "Sumatoria: ";
            // 
            // buttonLimpiarListBox
            // 
            this.buttonLimpiarListBox.Location = new System.Drawing.Point(12, 96);
            this.buttonLimpiarListBox.Name = "buttonLimpiarListBox";
            this.buttonLimpiarListBox.Size = new System.Drawing.Size(100, 23);
            this.buttonLimpiarListBox.TabIndex = 7;
            this.buttonLimpiarListBox.Text = "Limpiar lista";
            this.buttonLimpiarListBox.UseVisualStyleBackColor = true;
            this.buttonLimpiarListBox.Click += new System.EventHandler(this.buttonLimpiarListBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 181);
            this.Controls.Add(this.buttonLimpiarListBox);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConsigna);
            this.Controls.Add(this.buttonAgregarValor);
            this.Controls.Add(this.listBoxValores);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 03 - Ejercicio 03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ListBox listBoxValores;
        private System.Windows.Forms.Button buttonAgregarValor;
        private System.Windows.Forms.Button buttonConsigna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonLimpiarListBox;
    }
}

