
namespace tp_03_ejercicio07
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.textBoxLapso = new System.Windows.Forms.TextBox();
            this.textBoxTna = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonConsigna = new System.Windows.Forms.Button();
            this.ColumnMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLapso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIntereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMonto,
            this.ColumnLapso,
            this.ColumnTna,
            this.ColumnIntereses});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(12, 59);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonto.TabIndex = 1;
            // 
            // textBoxLapso
            // 
            this.textBoxLapso.Location = new System.Drawing.Point(118, 59);
            this.textBoxLapso.Name = "textBoxLapso";
            this.textBoxLapso.Size = new System.Drawing.Size(100, 20);
            this.textBoxLapso.TabIndex = 2;
            // 
            // textBoxTna
            // 
            this.textBoxTna.Location = new System.Drawing.Point(224, 59);
            this.textBoxTna.Name = "textBoxTna";
            this.textBoxTna.Size = new System.Drawing.Size(100, 20);
            this.textBoxTna.TabIndex = 3;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(12, 12);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonConsigna
            // 
            this.buttonConsigna.Location = new System.Drawing.Point(174, 12);
            this.buttonConsigna.Name = "buttonConsigna";
            this.buttonConsigna.Size = new System.Drawing.Size(75, 23);
            this.buttonConsigna.TabIndex = 5;
            this.buttonConsigna.Text = "Consigna";
            this.buttonConsigna.UseVisualStyleBackColor = true;
            this.buttonConsigna.Click += new System.EventHandler(this.buttonConsigna_Click);
            // 
            // ColumnMonto
            // 
            this.ColumnMonto.HeaderText = "Monto";
            this.ColumnMonto.Name = "ColumnMonto";
            // 
            // ColumnLapso
            // 
            this.ColumnLapso.HeaderText = "Lapso";
            this.ColumnLapso.Name = "ColumnLapso";
            // 
            // ColumnTna
            // 
            this.ColumnTna.HeaderText = "TNA";
            this.ColumnTna.Name = "ColumnTna";
            // 
            // ColumnIntereses
            // 
            this.ColumnIntereses.HeaderText = "Intereses";
            this.ColumnIntereses.Name = "ColumnIntereses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Monto a ingresar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad de días:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TNA:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(93, 12);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 309);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConsigna);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxTna);
            this.Controls.Add(this.textBoxLapso);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 03 - Ejercicio 07";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.TextBox textBoxLapso;
        private System.Windows.Forms.TextBox textBoxTna;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonConsigna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLapso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIntereses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

