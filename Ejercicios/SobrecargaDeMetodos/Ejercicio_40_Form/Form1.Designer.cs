namespace Ejercicio_40_Form
{
    partial class FrmMenu
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
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFactTotal = new System.Windows.Forms.Button();
            this.btnFactLocal = new System.Windows.Forms.Button();
            this.btnFacProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarLlamada.Location = new System.Drawing.Point(42, 12);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(154, 37);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = true;
            this.btnGenerarLlamada.Click += new System.EventHandler(this.btnGenerarLlamada_Click);
            // 
            // btnFactTotal
            // 
            this.btnFactTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactTotal.Location = new System.Drawing.Point(42, 67);
            this.btnFactTotal.Name = "btnFactTotal";
            this.btnFactTotal.Size = new System.Drawing.Size(154, 37);
            this.btnFactTotal.TabIndex = 1;
            this.btnFactTotal.Text = "Facturacion Total";
            this.btnFactTotal.UseVisualStyleBackColor = true;
            this.btnFactTotal.Click += new System.EventHandler(this.btnFactTotal_Click);
            // 
            // btnFactLocal
            // 
            this.btnFactLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactLocal.Location = new System.Drawing.Point(42, 123);
            this.btnFactLocal.Name = "btnFactLocal";
            this.btnFactLocal.Size = new System.Drawing.Size(154, 37);
            this.btnFactLocal.TabIndex = 2;
            this.btnFactLocal.Text = "Facturacion Local";
            this.btnFactLocal.UseVisualStyleBackColor = true;
            this.btnFactLocal.Click += new System.EventHandler(this.btnFactLocal_Click);
            // 
            // btnFacProvincial
            // 
            this.btnFacProvincial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacProvincial.Location = new System.Drawing.Point(42, 179);
            this.btnFacProvincial.Name = "btnFacProvincial";
            this.btnFacProvincial.Size = new System.Drawing.Size(154, 38);
            this.btnFacProvincial.TabIndex = 3;
            this.btnFacProvincial.Text = "Facturacion Provincial";
            this.btnFacProvincial.UseVisualStyleBackColor = true;
            this.btnFacProvincial.Click += new System.EventHandler(this.btnFacProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(42, 236);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 297);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacProvincial);
            this.Controls.Add(this.btnFactLocal);
            this.Controls.Add(this.btnFactTotal);
            this.Controls.Add(this.btnGenerarLlamada);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.Load += new System.EventHandler(this.FrmMenu_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFactTotal;
        private System.Windows.Forms.Button btnFactLocal;
        private System.Windows.Forms.Button btnFacProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}

