using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;


namespace Presentacion.Reportes.Estaticos
{
    public partial class RepAlianza_Ods : Form
    {
        static SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        SqlDataAdapter AlianzaOds = new SqlDataAdapter("SELECT * FROM Alianza_Ods", _Conexion);
        CITRADataSet dataReport = new CITRADataSet();

        public RepAlianza_Ods()
        {
            InitializeComponent();
        }

        private void RepAlianza_Ods_Load(object sender, EventArgs e)
        {    
            AlianzaOds.Fill(dataReport);
            AOds AlianzaOdsReport = new AOds();
            AlianzaOdsReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = AlianzaOdsReport;
        }
    }
}
