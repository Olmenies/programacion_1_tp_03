
namespace tp_03_ejercicio_01
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
            this.buttonAgregarValor = new System.Windows.Forms.Button();
            this.buttonConsigna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgregarValor
            // 
            this.buttonAgregarValor.Location = new System.Drawing.Point(12, 12);
            this.buttonAgregarValor.Name = "buttonAgregarValor";
            this.buttonAgregarValor.Size = new System.Drawing.Size(120, 59);
            this.buttonAgregarValor.TabIndex = 0;
            this.buttonAgregarValor.Text = "Calcular";
            this.buttonAgregarValor.UseVisualStyleBackColor = true;
            this.buttonAgregarValor.Click += new System.EventHandler(this.buttonAgregarValor_Click);
            // 
            // buttonConsigna
            // 
            this.buttonConsigna.Location = new System.Drawing.Point(166, 12);
            this.buttonConsigna.Name = "buttonConsigna";
            this.buttonConsigna.Size = new System.Drawing.Size(128, 59);
            this.buttonConsigna.TabIndex = 1;
            this.buttonConsigna.Text = "Consigna";
            this.buttonConsigna.UseVisualStyleBackColor = true;
            this.buttonConsigna.Click += new System.EventHandler(this.buttonConsigna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 83);
            this.Controls.Add(this.buttonConsigna);
            this.Controls.Add(this.buttonAgregarValor);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 03 - Ejercicio 01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarValor;
        private System.Windows.Forms.Button buttonConsigna;
    }
}

