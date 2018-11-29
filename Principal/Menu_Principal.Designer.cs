namespace Principal
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresPorProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosConcluidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradoresToolStripMenuItem,
            this.proyectosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.mantenimientosToolStripMenuItem.Text = "Inicio";
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            this.colaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avancesToolStripMenuItem,
            this.proyectosToolStripMenuItem1,
            this.colaboradoresPorProyectosToolStripMenuItem,
            this.proyectosConcluidosToolStripMenuItem,
            this.proyectosPendientesToolStripMenuItem});
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // avancesToolStripMenuItem
            // 
            this.avancesToolStripMenuItem.Name = "avancesToolStripMenuItem";
            this.avancesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.avancesToolStripMenuItem.Text = "Avances";
            this.avancesToolStripMenuItem.Click += new System.EventHandler(this.avancesToolStripMenuItem_Click);
            // 
            // proyectosToolStripMenuItem1
            // 
            this.proyectosToolStripMenuItem1.Name = "proyectosToolStripMenuItem1";
            this.proyectosToolStripMenuItem1.Size = new System.Drawing.Size(227, 22);
            this.proyectosToolStripMenuItem1.Text = "Proyectos";
            this.proyectosToolStripMenuItem1.Click += new System.EventHandler(this.proyectosToolStripMenuItem1_Click);
            // 
            // colaboradoresPorProyectosToolStripMenuItem
            // 
            this.colaboradoresPorProyectosToolStripMenuItem.Name = "colaboradoresPorProyectosToolStripMenuItem";
            this.colaboradoresPorProyectosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.colaboradoresPorProyectosToolStripMenuItem.Text = "Colaboradores por Proyectos";
            this.colaboradoresPorProyectosToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresPorProyectosToolStripMenuItem_Click);
            // 
            // proyectosConcluidosToolStripMenuItem
            // 
            this.proyectosConcluidosToolStripMenuItem.Name = "proyectosConcluidosToolStripMenuItem";
            this.proyectosConcluidosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.proyectosConcluidosToolStripMenuItem.Text = "Proyectos Concluidos";
            this.proyectosConcluidosToolStripMenuItem.Click += new System.EventHandler(this.proyectosConcluidosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // proyectosPendientesToolStripMenuItem
            // 
            this.proyectosPendientesToolStripMenuItem.Name = "proyectosPendientesToolStripMenuItem";
            this.proyectosPendientesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.proyectosPendientesToolStripMenuItem.Text = "Proyectos Pendientes";
            this.proyectosPendientesToolStripMenuItem.Click += new System.EventHandler(this.proyectosPendientesToolStripMenuItem_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Principal";
            this.Text = "La Poderosa";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresPorProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosConcluidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosPendientesToolStripMenuItem;
    }
}

