namespace VistaForm
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelExperiencia = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDni = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExperiencia = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(43, 32);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(63, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(43, 75);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(66, 16);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(43, 118);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(45, 16);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "Edad";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(43, 168);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(34, 16);
            this.labelDni.TabIndex = 3;
            this.labelDni.Text = "DNI";
            // 
            // labelExperiencia
            // 
            this.labelExperiencia.AutoSize = true;
            this.labelExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExperiencia.Location = new System.Drawing.Point(43, 213);
            this.labelExperiencia.Name = "labelExperiencia";
            this.labelExperiencia.Size = new System.Drawing.Size(90, 16);
            this.labelExperiencia.TabIndex = 4;
            this.labelExperiencia.Text = "Experiencia";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(194, 31);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(143, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(194, 71);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(143, 20);
            this.textBoxApellido.TabIndex = 6;
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(194, 113);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(143, 20);
            this.numericUpDownEdad.TabIndex = 7;
            // 
            // numericUpDownDni
            // 
            this.numericUpDownDni.Location = new System.Drawing.Point(194, 164);
            this.numericUpDownDni.Name = "numericUpDownDni";
            this.numericUpDownDni.Size = new System.Drawing.Size(143, 20);
            this.numericUpDownDni.TabIndex = 8;
            // 
            // numericUpDownExperiencia
            // 
            this.numericUpDownExperiencia.Location = new System.Drawing.Point(194, 209);
            this.numericUpDownExperiencia.Name = "numericUpDownExperiencia";
            this.numericUpDownExperiencia.Size = new System.Drawing.Size(143, 20);
            this.numericUpDownExperiencia.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(46, 267);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(262, 267);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 11;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 304);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.numericUpDownExperiencia);
            this.Controls.Add(this.numericUpDownDni);
            this.Controls.Add(this.numericUpDownEdad);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelExperiencia);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDT";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelExperiencia;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.NumericUpDown numericUpDownDni;
        private System.Windows.Forms.NumericUpDown numericUpDownExperiencia;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
    }
}

