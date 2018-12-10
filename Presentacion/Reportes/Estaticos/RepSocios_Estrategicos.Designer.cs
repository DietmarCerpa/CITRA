namespace Presentacion.Reportes.Estaticos
{
    partial class RepSocios_Estrategicos
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
            this.CB_SE = new System.Windows.Forms.ComboBox();
            this.txt_Filtrar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CR_SE = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CB_SE
            // 
            this.CB_SE.FormattingEnabled = true;
            this.CB_SE.Items.AddRange(new object[] {
            "Cargo",
            "Organizacion"});
            this.CB_SE.Location = new System.Drawing.Point(13, 13);
            this.CB_SE.Name = "CB_SE";
            this.CB_SE.Size = new System.Drawing.Size(121, 21);
            this.CB_SE.TabIndex = 0;
            // 
            // txt_Filtrar
            // 
            this.txt_Filtrar.Location = new System.Drawing.Point(140, 14);
            this.txt_Filtrar.Name = "txt_Filtrar";
            this.txt_Filtrar.Size = new System.Drawing.Size(100, 20);
            this.txt_Filtrar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CR_SE
            // 
            this.CR_SE.ActiveViewIndex = -1;
            this.CR_SE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CR_SE.Cursor = System.Windows.Forms.Cursors.Default;
            this.CR_SE.Location = new System.Drawing.Point(0, 54);
            this.CR_SE.Name = "CR_SE";
            this.CR_SE.Size = new System.Drawing.Size(800, 396);
            this.CR_SE.TabIndex = 3;
            this.CR_SE.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RepSocios_Estrategicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CR_SE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Filtrar);
            this.Controls.Add(this.CB_SE);
            this.Name = "RepSocios_Estrategicos";
            this.Text = "RepSocios_Estrategicos";
            this.Load += new System.EventHandler(this.RepSocios_Estrategicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_SE;
        private System.Windows.Forms.TextBox txt_Filtrar;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CR_SE;
    }
}