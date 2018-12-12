namespace Presentacion.Reportes.Estaticos
{
    partial class RepAlianza_Ods
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
            this.CR_AO = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.CB_Filtros = new System.Windows.Forms.ComboBox();
            this.txt_Filtrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CR_AO
            // 
            this.CR_AO.ActiveViewIndex = -1;
            this.CR_AO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CR_AO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CR_AO.Cursor = System.Windows.Forms.Cursors.Default;
            this.CR_AO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CR_AO.Location = new System.Drawing.Point(0, 45);
            this.CR_AO.Name = "CR_AO";
            this.CR_AO.Size = new System.Drawing.Size(831, 419);
            this.CR_AO.TabIndex = 0;
            this.CR_AO.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CB_Filtros
            // 
            this.CB_Filtros.FormattingEnabled = true;
            this.CB_Filtros.Items.AddRange(new object[] {
            "Organización",
            "Cargo",
            "Sector",
            "Sin Filtro"});
            this.CB_Filtros.Location = new System.Drawing.Point(16, 14);
            this.CB_Filtros.Name = "CB_Filtros";
            this.CB_Filtros.Size = new System.Drawing.Size(121, 21);
            this.CB_Filtros.TabIndex = 2;
            this.CB_Filtros.Text = "Seleccionar Filtro";
            // 
            // txt_Filtrar
            // 
            this.txt_Filtrar.Location = new System.Drawing.Point(156, 14);
            this.txt_Filtrar.Name = "txt_Filtrar";
            this.txt_Filtrar.Size = new System.Drawing.Size(100, 20);
            this.txt_Filtrar.TabIndex = 3;
            // 
            // RepAlianza_Ods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 464);
            this.Controls.Add(this.txt_Filtrar);
            this.Controls.Add(this.CB_Filtros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CR_AO);
            this.Name = "RepAlianza_Ods";
            this.Text = "RepAlianza_Ods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CR_AO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_Filtros;
        private System.Windows.Forms.TextBox txt_Filtrar;
    }
}