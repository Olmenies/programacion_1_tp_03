
namespace tp_03_ejercicio_12
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonSeleccionarColor = new System.Windows.Forms.Button();
            this.buttonConsigna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSeleccionarColor
            // 
            this.buttonSeleccionarColor.Location = new System.Drawing.Point(12, 12);
            this.buttonSeleccionarColor.Name = "buttonSeleccionarColor";
            this.buttonSeleccionarColor.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionarColor.TabIndex = 0;
            this.buttonSeleccionarColor.Text = "¡Color!";
            this.buttonSeleccionarColor.UseVisualStyleBackColor = true;
            this.buttonSeleccionarColor.Click += new System.EventHandler(this.buttonSeleccionarColor_Click);
            // 
            // buttonConsigna
            // 
            this.buttonConsigna.Location = new System.Drawing.Point(12, 41);
            this.buttonConsigna.Name = "buttonConsigna";
            this.buttonConsigna.Size = new System.Drawing.Size(75, 23);
            this.buttonConsigna.TabIndex = 1;
            this.buttonConsigna.Text = "Consigna";
            this.buttonConsigna.UseVisualStyleBackColor = true;
            this.buttonConsigna.Click += new System.EventHandler(this.buttonConsigna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.buttonConsigna);
            this.Controls.Add(this.buttonSeleccionarColor);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 03 - Ejercicio 12";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonSeleccionarColor;
        private System.Windows.Forms.Button buttonConsigna;
    }
}

