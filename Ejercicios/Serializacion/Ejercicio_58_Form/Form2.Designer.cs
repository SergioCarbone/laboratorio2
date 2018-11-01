namespace Ejercicio_58_Form
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoDatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoTxtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoDatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoTxtToolStripMenuItem,
            this.archivoDatToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoTxtToolStripMenuItem1,
            this.archivoDatToolStripMenuItem1});
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como..";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // archivoTxtToolStripMenuItem
            // 
            this.archivoTxtToolStripMenuItem.Name = "archivoTxtToolStripMenuItem";
            this.archivoTxtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.archivoTxtToolStripMenuItem.Text = "Archivo txt";
            this.archivoTxtToolStripMenuItem.Click += new System.EventHandler(this.archivoTxtToolStripMenuItem_Click);
            // 
            // archivoDatToolStripMenuItem
            // 
            this.archivoDatToolStripMenuItem.Name = "archivoDatToolStripMenuItem";
            this.archivoDatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.archivoDatToolStripMenuItem.Text = "Archivo dat";
            this.archivoDatToolStripMenuItem.Click += new System.EventHandler(this.archivoDatToolStripMenuItem_Click);
            // 
            // archivoTxtToolStripMenuItem1
            // 
            this.archivoTxtToolStripMenuItem1.Name = "archivoTxtToolStripMenuItem1";
            this.archivoTxtToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.archivoTxtToolStripMenuItem1.Text = "Archivo txt";
            this.archivoTxtToolStripMenuItem1.Click += new System.EventHandler(this.archivoTxtToolStripMenuItem1_Click);
            // 
            // archivoDatToolStripMenuItem1
            // 
            this.archivoDatToolStripMenuItem1.Name = "archivoDatToolStripMenuItem1";
            this.archivoDatToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.archivoDatToolStripMenuItem1.Text = "Archivo dat";
            this.archivoDatToolStripMenuItem1.Click += new System.EventHandler(this.archivoDatToolStripMenuItem1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(548, 220);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 259);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoDatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoTxtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem archivoDatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}