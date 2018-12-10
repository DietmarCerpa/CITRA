using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Presentacion.Reportes.Estaticos
{
    public partial class RepAlianza_Ods : Form
    {
        public RepAlianza_Ods()
        {
            InitializeComponent();
        }
        static SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());      
        CITRADataSet dataReport = new CITRADataSet();
        string filtro;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Filtrar.Text != "")
            {
                switch (CB_Filtros.SelectedIndex)
                {
                     case 0:
                     filtro = "SELECT * FROM [dbo].[Alianza_Ods] WHERE Nombre_Organizacion LIKE %" + txt_Filtrar.Text + "%";
                     break;
                     case 1:
                     filtro = "SELECT * FROM [dbo].[Alianza_Ods] WHERE Nombre_Cargo LIKE %" + txt_Filtrar.Text + "%";
                     break;
                     case 2:
                     filtro = "SELECT * FROM [dbo].[Alianza_Ods] WHERE Nombre_Sector LIKE %" + txt_Filtrar.Text + "%";
                     break;
                     default: 
                     filtro = "SELECT * FROM [dbo].[Alianza_Ods]";
                     break;
                }
            }
            else filtro = "SELECT * FROM [dbo].[Alianza_Ods]";

            SqlDataAdapter AlianzaOds = new SqlDataAdapter(filtro, _Conexion);
            AlianzaOds.Fill(dataReport);
            AOds AlianzaOdsReport = new AOds();
            AlianzaOdsReport.SetDataSource(dataReport);
            CR_AO.ReportSource = AlianzaOdsReport;
        }
    }
}
