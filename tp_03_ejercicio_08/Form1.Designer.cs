
namespace tp_03_ejercicio_08
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
            this.buttonTirarDados = new System.Windows.Forms.Button();
            this.buttonConsigna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTirarDados
            // 
            this.buttonTirarDados.Location = new System.Drawing.Point(12, 12);
            this.buttonTirarDados.Name = "buttonTirarDados";
            this.buttonTirarDados.Size = new System.Drawing.Size(126, 120);
            this.buttonTirarDados.TabIndex = 0;
            this.buttonTirarDados.Text = "Tirar";
            this.buttonTirarDados.UseVisualStyleBackColor = true;
            this.buttonTirarDados.Click += new System.EventHandler(this.buttonTirarDados_Click);
            // 
            // buttonConsigna
            // 
            this.buttonConsigna.Location = new System.Drawing.Point(158, 12);
            this.buttonConsigna.Name = "buttonConsigna";
            this.buttonConsigna.Size = new System.Drawing.Size(126, 120);
            this.buttonConsigna.TabIndex = 1;
            this.buttonConsigna.Text = "Consigna";
            this.buttonConsigna.UseVisualStyleBackColor = true;
            this.buttonConsigna.Click += new System.EventHandler(this.buttonConsigna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 141);
            this.Controls.Add(this.buttonConsigna);
            this.Controls.Add(this.buttonTirarDados);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 03 - Ejercicio 08";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTirarDados;
        private System.Windows.Forms.Button buttonConsigna;
    }
}

