namespace Presentacion
{
    partial class RAlianza_Ods
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
            this.cITRADataSet = new Presentacion.CITRADataSet();
            this.alianzaOdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alianza_OdsTableAdapter = new Presentacion.CITRADataSetTableAdapters.Alianza_OdsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cITRADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alianzaOdsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.alianzaOdsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(553, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // cITRADataSet
            // 
            this.cITRADataSet.DataSetName = "CITRADataSet";
            this.cITRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alianzaOdsBindingSource
            // 
            this.alianzaOdsBindingSource.DataMember = "Alianza_Ods";
            this.alianzaOdsBindingSource.DataSource = this.cITRADataSet;
            // 
            // alianza_OdsTableAdapter
            // 
            this.alianza_OdsTableAdapter.ClearBeforeFill = true;
            // 
            // RAlianza_Ods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RAlianza_Ods";
            this.Text = "Reporte Alianza  ODS";
            this.Load += new System.EventHandler(this.RAlianza_Ods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cITRADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alianzaOdsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CITRADataSet cITRADataSet;
        private System.Windows.Forms.BindingSource alianzaOdsBindingSource;
        private CITRADataSetTableAdapters.Alianza_OdsTableAdapter alianza_OdsTableAdapter;
    }
}