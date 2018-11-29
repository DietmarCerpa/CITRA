namespace Presentacion
{
    partial class Bitacora_ES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora_ES));
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lstdatos = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Cbo_Buscar = new System.Windows.Forms.ComboBox();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.pnl_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_lista
            // 
            this.pnl_lista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnl_lista.Controls.Add(this.pictureBox1);
            this.pnl_lista.Controls.Add(this.lbldescripcion);
            this.pnl_lista.Controls.Add(this.lbltitulo);
            this.pnl_lista.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_lista.Location = new System.Drawing.Point(0, 0);
            this.pnl_lista.Name = "pnl_lista";
            this.pnl_lista.Size = new System.Drawing.Size(484, 63);
            this.pnl_lista.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(107, 31);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(151, 13);
            this.lbldescripcion.TabIndex = 1;
            this.lbldescripcion.Text = "Bitácora de Entradas y Salidas";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(107, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(374, 13);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            // 
            // lstdatos
            // 
            this.lstdatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstdatos.Location = new System.Drawing.Point(0, 63);
            this.lstdatos.Name = "lstdatos";
            this.lstdatos.Size = new System.Drawing.Size(484, 686);
            this.lstdatos.TabIndex = 11;
            this.lstdatos.UseCompatibleStateImageBehavior = false;
            this.lstdatos.View = System.Windows.Forms.View.List;
            this.lstdatos.SelectedIndexChanged += new System.EventHandler(this.lstdatos_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(0, 134);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 615);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Cbo_Buscar
            // 
            this.Cbo_Buscar.FormattingEnabled = true;
            this.Cbo_Buscar.Items.AddRange(new object[] {
            "1. Usuario",
            "3. Fecha",
            "3. Tipo Transacción"});
            this.Cbo_Buscar.Location = new System.Drawing.Point(30, 88);
            this.Cbo_Buscar.Name = "Cbo_Buscar";
            this.Cbo_Buscar.Size = new System.Drawing.Size(143, 21);
            this.Cbo_Buscar.TabIndex = 37;
            this.Cbo_Buscar.Text = "Seleccione una opción";
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(205, 89);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(231, 20);
            this.Txt_Buscar.TabIndex = 36;
            // 
            // Bitacora_ES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 749);
            this.Controls.Add(this.Cbo_Buscar);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lstdatos);
            this.Controls.Add(this.pnl_lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bitacora_ES";
            this.Text = "Bitácora de Entradas y Salidas";
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pnl_lista;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.ListView lstdatos;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox Cbo_Buscar;
        private System.Windows.Forms.TextBox Txt_Buscar;
    }
}