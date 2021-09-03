
namespace tp_03_ejercicio_10
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRankine = new System.Windows.Forms.RadioButton();
            this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioButtonKelvin = new System.Windows.Forms.RadioButton();
            this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonConsigna = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRankine);
            this.groupBox1.Controls.Add(this.radioButtonFahrenheit);
            this.groupBox1.Controls.Add(this.radioButtonKelvin);
            this.groupBox1.Controls.Add(this.radioButtonCelsius);
            this.groupBox1.Location = new System.Drawing.Point(133, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar escala:";
            // 
            // radioButtonRankine
            // 
            this.radioButtonRankine.AutoSize = true;
            this.radioButtonRankine.Location = new System.Drawing.Point(255, 19);
            this.radioButtonRankine.Name = "radioButtonRankine";
            this.radioButtonRankine.Size = new System.Drawing.Size(65, 17);
            this.radioButtonRankine.TabIndex = 3;
            this.radioButtonRankine.TabStop = true;
            this.radioButtonRankine.Text = "Rankine";
            this.radioButtonRankine.UseVisualStyleBackColor = true;
            // 
            // radioButtonFahrenheit
            // 
            this.radioButtonFahrenheit.AutoSize = true;
            this.radioButtonFahrenheit.Location = new System.Drawing.Point(161, 19);
            this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            this.radioButtonFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.radioButtonFahrenheit.TabIndex = 2;
            this.radioButtonFahrenheit.TabStop = true;
            this.radioButtonFahrenheit.Text = "Fahrenheit";
            this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioButtonKelvin
            // 
            this.radioButtonKelvin.AutoSize = true;
            this.radioButtonKelvin.Location = new System.Drawing.Point(84, 19);
            this.radioButtonKelvin.Name = "radioButtonKelvin";
            this.radioButtonKelvin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonKelvin.TabIndex = 1;
            this.radioButtonKelvin.TabStop = true;
            this.radioButtonKelvin.Text = "Kelvin";
            this.radioButtonKelvin.UseVisualStyleBackColor = true;
            // 
            // radioButtonCelsius
            // 
            this.radioButtonCelsius.AutoSize = true;
            this.radioButtonCelsius.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCelsius.Name = "radioButtonCelsius";
            this.radioButtonCelsius.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCelsius.TabIndex = 0;
            this.radioButtonCelsius.TabStop = true;
            this.radioButtonCelsius.Text = "Celsius";
            this.radioButtonCelsius.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 72);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar temperatura:";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(12, 149);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(93, 150);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonConsigna
            // 
            this.buttonConsigna.Location = new System.Drawing.Point(174, 150);
            this.buttonConsigna.Name = "buttonConsigna";
            this.buttonConsigna.Size = new System.Drawing.Size(75, 23);
            this.buttonConsigna.TabIndex = 6;
            this.buttonConsigna.Text = "Consigna";
            this.buttonConsigna.UseVisualStyleBackColor = true;
            this.buttonConsigna.Click += new System.EventHandler(this.buttonConsigna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 196);
            this.Controls.Add(this.buttonConsigna);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 03 - Ejercicio 10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRankine;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit;
        private System.Windows.Forms.RadioButton radioButtonKelvin;
        private System.Windows.Forms.RadioButton radioButtonCelsius;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonConsigna;
    }
}

