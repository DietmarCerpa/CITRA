namespace Presentacion.Reportes.Estaticos
{
    partial class RepCirculos_Sociales
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
            this.CB_CS = new System.Windows.Forms.ComboBox();
            this.txt_Filtrar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CR_CS = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CB_CS
            // 
            this.CB_CS.FormattingEnabled = true;
            this.CB_CS.Location = new System.Drawing.Point(12, 12);
            this.CB_CS.Name = "CB_CS";
            this.CB_CS.Size = new System.Drawing.Size(121, 21);
            this.CB_CS.TabIndex = 0;
            // 
            // txt_Filtrar
            // 
            this.txt_Filtrar.Location = new System.Drawing.Point(151, 12);
            this.txt_Filtrar.Name = "txt_Filtrar";
            this.txt_Filtrar.Size = new System.Drawing.Size(100, 20);
            this.txt_Filtrar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CR_CS
            // 
            this.CR_CS.ActiveViewIndex = -1;
            this.CR_CS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CR_CS.Cursor = System.Windows.Forms.Cursors.Default;
            this.CR_CS.Location = new System.Drawing.Point(-3, 39);
            this.CR_CS.Name = "CR_CS";
            this.CR_CS.Size = new System.Drawing.Size(764, 410);
            this.CR_CS.TabIndex = 3;
            this.CR_CS.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RepCirculos_Sociales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CR_CS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Filtrar);
            this.Controls.Add(this.CB_CS);
            this.Name = "RepCirculos_Sociales";
            this.Text = "RepCirculos_Sociales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_CS;
        private System.Windows.Forms.TextBox txt_Filtrar;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CR_CS;
    }
}