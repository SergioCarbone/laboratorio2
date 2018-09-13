namespace Ejercicio_23
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEuro = new System.Windows.Forms.TextBox();
            this.textDolar = new System.Windows.Forms.TextBox();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.textEuroAEuro = new System.Windows.Forms.TextBox();
            this.textEuroADolar = new System.Windows.Forms.TextBox();
            this.textEuroAPeso = new System.Windows.Forms.TextBox();
            this.textDolarAEuro = new System.Windows.Forms.TextBox();
            this.textDolarADolar = new System.Windows.Forms.TextBox();
            this.textDolarAPeso = new System.Windows.Forms.TextBox();
            this.textPesoAEuro = new System.Windows.Forms.TextBox();
            this.textPesoADolar = new System.Windows.Forms.TextBox();
            this.textPesoAPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso";
            // 
            // textEuro
            // 
            this.textEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEuro.Location = new System.Drawing.Point(151, 95);
            this.textEuro.Multiline = true;
            this.textEuro.Name = "textEuro";
            this.textEuro.Size = new System.Drawing.Size(110, 31);
            this.textEuro.TabIndex = 6;
            // 
            // textDolar
            // 
            this.textDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDolar.Location = new System.Drawing.Point(151, 165);
            this.textDolar.Multiline = true;
            this.textDolar.Name = "textDolar";
            this.textDolar.Size = new System.Drawing.Size(110, 31);
            this.textDolar.TabIndex = 7;
            // 
            // textPeso
            // 
            this.textPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPeso.Location = new System.Drawing.Point(151, 250);
            this.textPeso.Multiline = true;
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(110, 32);
            this.textPeso.TabIndex = 8;
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertEuro.Location = new System.Drawing.Point(311, 95);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(110, 31);
            this.btnConvertEuro.TabIndex = 18;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertDolar.Location = new System.Drawing.Point(311, 169);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(110, 32);
            this.btnConvertDolar.TabIndex = 19;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertPeso.Location = new System.Drawing.Point(311, 250);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(110, 31);
            this.btnConvertPeso.TabIndex = 20;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            // 
            // textEuroAEuro
            // 
            this.textEuroAEuro.Enabled = false;
            this.textEuroAEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEuroAEuro.Location = new System.Drawing.Point(493, 94);
            this.textEuroAEuro.Multiline = true;
            this.textEuroAEuro.Name = "textEuroAEuro";
            this.textEuroAEuro.Size = new System.Drawing.Size(144, 32);
            this.textEuroAEuro.TabIndex = 21;
            // 
            // textEuroADolar
            // 
            this.textEuroADolar.Enabled = false;
            this.textEuroADolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEuroADolar.Location = new System.Drawing.Point(673, 92);
            this.textEuroADolar.Multiline = true;
            this.textEuroADolar.Name = "textEuroADolar";
            this.textEuroADolar.Size = new System.Drawing.Size(140, 32);
            this.textEuroADolar.TabIndex = 22;
            // 
            // textEuroAPeso
            // 
            this.textEuroAPeso.Enabled = false;
            this.textEuroAPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEuroAPeso.Location = new System.Drawing.Point(845, 92);
            this.textEuroAPeso.Multiline = true;
            this.textEuroAPeso.Name = "textEuroAPeso";
            this.textEuroAPeso.Size = new System.Drawing.Size(141, 32);
            this.textEuroAPeso.TabIndex = 23;
            // 
            // textDolarAEuro
            // 
            this.textDolarAEuro.Enabled = false;
            this.textDolarAEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDolarAEuro.Location = new System.Drawing.Point(493, 170);
            this.textDolarAEuro.Multiline = true;
            this.textDolarAEuro.Name = "textDolarAEuro";
            this.textDolarAEuro.Size = new System.Drawing.Size(144, 32);
            this.textDolarAEuro.TabIndex = 24;
            // 
            // textDolarADolar
            // 
            this.textDolarADolar.Enabled = false;
            this.textDolarADolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDolarADolar.Location = new System.Drawing.Point(673, 170);
            this.textDolarADolar.Multiline = true;
            this.textDolarADolar.Name = "textDolarADolar";
            this.textDolarADolar.Size = new System.Drawing.Size(140, 32);
            this.textDolarADolar.TabIndex = 25;
            // 
            // textDolarAPeso
            // 
            this.textDolarAPeso.Enabled = false;
            this.textDolarAPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDolarAPeso.Location = new System.Drawing.Point(845, 169);
            this.textDolarAPeso.Multiline = true;
            this.textDolarAPeso.Name = "textDolarAPeso";
            this.textDolarAPeso.Size = new System.Drawing.Size(141, 32);
            this.textDolarAPeso.TabIndex = 26;
            // 
            // textPesoAEuro
            // 
            this.textPesoAEuro.Enabled = false;
            this.textPesoAEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesoAEuro.Location = new System.Drawing.Point(493, 250);
            this.textPesoAEuro.Multiline = true;
            this.textPesoAEuro.Name = "textPesoAEuro";
            this.textPesoAEuro.Size = new System.Drawing.Size(144, 32);
            this.textPesoAEuro.TabIndex = 27;
            // 
            // textPesoADolar
            // 
            this.textPesoADolar.Enabled = false;
            this.textPesoADolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesoADolar.Location = new System.Drawing.Point(673, 250);
            this.textPesoADolar.Multiline = true;
            this.textPesoADolar.Name = "textPesoADolar";
            this.textPesoADolar.Size = new System.Drawing.Size(140, 32);
            this.textPesoADolar.TabIndex = 28;
            // 
            // textPesoAPeso
            // 
            this.textPesoAPeso.Enabled = false;
            this.textPesoAPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesoAPeso.Location = new System.Drawing.Point(845, 249);
            this.textPesoAPeso.Multiline = true;
            this.textPesoAPeso.Name = "textPesoAPeso";
            this.textPesoAPeso.Size = new System.Drawing.Size(141, 32);
            this.textPesoAPeso.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 30;
            this.label4.Text = "Euro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(705, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 31;
            this.label5.Text = "Dolar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(900, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 355);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPesoAPeso);
            this.Controls.Add(this.textPesoADolar);
            this.Controls.Add(this.textPesoAEuro);
            this.Controls.Add(this.textDolarAPeso);
            this.Controls.Add(this.textDolarADolar);
            this.Controls.Add(this.textDolarAEuro);
            this.Controls.Add(this.textEuroAPeso);
            this.Controls.Add(this.textEuroADolar);
            this.Controls.Add(this.textEuroAEuro);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.textDolar);
            this.Controls.Add(this.textEuro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversor de dinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEuro;
        private System.Windows.Forms.TextBox textDolar;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.TextBox textEuroAEuro;
        private System.Windows.Forms.TextBox textEuroADolar;
        private System.Windows.Forms.TextBox textEuroAPeso;
        private System.Windows.Forms.TextBox textDolarAEuro;
        private System.Windows.Forms.TextBox textDolarADolar;
        private System.Windows.Forms.TextBox textDolarAPeso;
        private System.Windows.Forms.TextBox textPesoAEuro;
        private System.Windows.Forms.TextBox textPesoADolar;
        private System.Windows.Forms.TextBox textPesoAPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

