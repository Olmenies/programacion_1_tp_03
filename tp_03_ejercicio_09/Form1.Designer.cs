
namespace tp_03_ejercicio_09
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
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonConsigna = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTirarDados
            // 
            this.buttonTirarDados.Location = new System.Drawing.Point(12, 12);
            this.buttonTirarDados.Name = "buttonTirarDados";
            this.buttonTirarDados.Size = new System.Drawing.Size(75, 23);
            this.buttonTirarDados.TabIndex = 1;
            this.buttonTirarDados.Text = "Tirar";
            this.buttonTirarDados.UseVisualStyleBackColor = true;
            this.buttonTirarDados.Click += new System.EventHandler(this.buttonTirarDados_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(93, 12);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 2;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonConsigna
            // 
            this.buttonConsigna.Location = new System.Drawing.Point(174, 12);
            this.buttonConsigna.Name = "buttonConsigna";
            this.buttonConsigna.Size = new System.Drawing.Size(75, 23);
            this.buttonConsigna.TabIndex = 3;
            this.buttonConsigna.Text = "Consigna";
            this.buttonConsigna.UseVisualStyleBackColor = true;
            this.buttonConsigna.Click += new System.EventHandler(this.buttonConsigna_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(517, 70);
            this.dataGridView2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 123);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonConsigna);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonTirarDados);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 03 - Ejercicio 09";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonTirarDados;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonConsigna;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

