
namespace tp_03_ejercicio_13
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSeleccionarImagen = new System.Windows.Forms.Button();
            this.buttonConsigna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 193);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSeleccionarImagen
            // 
            this.buttonSeleccionarImagen.Location = new System.Drawing.Point(12, 12);
            this.buttonSeleccionarImagen.Name = "buttonSeleccionarImagen";
            this.buttonSeleccionarImagen.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionarImagen.TabIndex = 1;
            this.buttonSeleccionarImagen.Text = "Seleccionar";
            this.buttonSeleccionarImagen.UseVisualStyleBackColor = true;
            this.buttonSeleccionarImagen.Click += new System.EventHandler(this.buttonSeleccionarImagen_Click);
            // 
            // buttonConsigna
            // 
            this.buttonConsigna.Location = new System.Drawing.Point(12, 41);
            this.buttonConsigna.Name = "buttonConsigna";
            this.buttonConsigna.Size = new System.Drawing.Size(75, 23);
            this.buttonConsigna.TabIndex = 2;
            this.buttonConsigna.Text = "Consigna";
            this.buttonConsigna.UseVisualStyleBackColor = true;
            this.buttonConsigna.Click += new System.EventHandler(this.buttonConsigna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 223);
            this.Controls.Add(this.buttonConsigna);
            this.Controls.Add(this.buttonSeleccionarImagen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 03 - Ejercicio 13";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSeleccionarImagen;
        private System.Windows.Forms.Button buttonConsigna;
    }
}

