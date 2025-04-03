namespace Ejercicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribaAquíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaDoblToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaDobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.escribaAquíToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaEnlazadaSimpleToolStripMenuItem,
            this.listaEnlazadaDoblToolStripMenuItem,
            this.listaEnlazadaDobleToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // escribaAquíToolStripMenuItem
            // 
            this.escribaAquíToolStripMenuItem.Name = "escribaAquíToolStripMenuItem";
            this.escribaAquíToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.escribaAquíToolStripMenuItem.Text = "Escriba aquí";
            // 
            // listaEnlazadaSimpleToolStripMenuItem
            // 
            this.listaEnlazadaSimpleToolStripMenuItem.Name = "listaEnlazadaSimpleToolStripMenuItem";
            this.listaEnlazadaSimpleToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listaEnlazadaSimpleToolStripMenuItem.Text = "Lista enlazada simple";
            this.listaEnlazadaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaSimpleToolStripMenuItem_Click);
            // 
            // listaEnlazadaDoblToolStripMenuItem
            // 
            this.listaEnlazadaDoblToolStripMenuItem.Name = "listaEnlazadaDoblToolStripMenuItem";
            this.listaEnlazadaDoblToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listaEnlazadaDoblToolStripMenuItem.Text = "Lista enlazada circular";
            this.listaEnlazadaDoblToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaDoblToolStripMenuItem_Click);
            // 
            // listaEnlazadaDobleToolStripMenuItem
            // 
            this.listaEnlazadaDobleToolStripMenuItem.Name = "listaEnlazadaDobleToolStripMenuItem";
            this.listaEnlazadaDobleToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listaEnlazadaDobleToolStripMenuItem.Text = "Lista enlazada doble";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Datos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaDoblToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribaAquíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaDobleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

