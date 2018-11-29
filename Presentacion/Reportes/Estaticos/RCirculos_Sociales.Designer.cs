namespace Presentacion
{
    partial class RCirculos_Sociales
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
            this.CirculoxDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CITRADataSet = new Presentacion.CITRADataSet();
            this.Circulos_SocialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Circulos_SocialesTableAdapter = new Presentacion.CITRADataSetTableAdapters.Circulos_SocialesTableAdapter();
            this.circulosSocialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cITRADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CirculoxDepartamentoTableAdapter = new Presentacion.CITRADataSetTableAdapters.CirculoxDepartamentoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CirculoxDepartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CITRADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circulos_SocialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulosSocialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITRADataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CirculoxDepartamentoBindingSource
            // 
            this.CirculoxDepartamentoBindingSource.DataMember = "CirculoxDepartamento";
            this.CirculoxDepartamentoBindingSource.DataSource = this.CITRADataSet;
            // 
            // CITRADataSet
            // 
            this.CITRADataSet.DataSetName = "CITRADataSet";
            this.CITRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Circulos_SocialesBindingSource
            // 
            this.Circulos_SocialesBindingSource.DataMember = "Circulos_Sociales";
            this.Circulos_SocialesBindingSource.DataSource = this.CITRADataSet;
            // 
            // Circulos_SocialesTableAdapter
            // 
            this.Circulos_SocialesTableAdapter.ClearBeforeFill = true;
            // 
            // circulosSocialesBindingSource
            // 
            this.circulosSocialesBindingSource.DataMember = "Circulos_Sociales";
            this.circulosSocialesBindingSource.DataSource = this.CITRADataSet;
            // 
            // cITRADataSetBindingSource
            // 
            this.cITRADataSetBindingSource.DataSource = this.CITRADataSet;
            this.cITRADataSetBindingSource.Position = 0;
            // 
            // CirculoxDepartamentoTableAdapter
            // 
            this.CirculoxDepartamentoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Circulos_SocialesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(664, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // RCirculos_Sociales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RCirculos_Sociales";
            this.Text = "Reporte Circulos Sociales";
            this.Load += new System.EventHandler(this.RCirculos_Sociales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CirculoxDepartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CITRADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circulos_SocialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulosSocialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITRADataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource Circulos_SocialesBindingSource;
        private CITRADataSet CITRADataSet;
        private CITRADataSetTableAdapters.Circulos_SocialesTableAdapter Circulos_SocialesTableAdapter;
        private System.Windows.Forms.BindingSource circulosSocialesBindingSource;
        private System.Windows.Forms.BindingSource cITRADataSetBindingSource;
        private System.Windows.Forms.BindingSource CirculoxDepartamentoBindingSource;
        private CITRADataSetTableAdapters.CirculoxDepartamentoTableAdapter CirculoxDepartamentoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}