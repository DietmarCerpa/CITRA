namespace Presentacion
{
    partial class RSocios_Estrategicos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CITRADataSet = new Presentacion.CITRADataSet();
            this.Socios_EstrategicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Socios_EstrategicosTableAdapter = new Presentacion.CITRADataSetTableAdapters.Socios_EstrategicosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CITRADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Socios_EstrategicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Socios_EstrategicosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(608, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // CITRADataSet
            // 
            this.CITRADataSet.DataSetName = "CITRADataSet";
            this.CITRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Socios_EstrategicosBindingSource
            // 
            this.Socios_EstrategicosBindingSource.DataMember = "Socios_Estrategicos";
            this.Socios_EstrategicosBindingSource.DataSource = this.CITRADataSet;
            // 
            // Socios_EstrategicosTableAdapter
            // 
            this.Socios_EstrategicosTableAdapter.ClearBeforeFill = true;
            // 
            // RSocios_Estrategicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RSocios_Estrategicos";
            this.Text = "Reporte Socios Estratégicos";
            this.Load += new System.EventHandler(this.RSocios_Estrategicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CITRADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Socios_EstrategicosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Socios_EstrategicosBindingSource;
        private CITRADataSet CITRADataSet;
        private CITRADataSetTableAdapters.Socios_EstrategicosTableAdapter Socios_EstrategicosTableAdapter;
    }
}