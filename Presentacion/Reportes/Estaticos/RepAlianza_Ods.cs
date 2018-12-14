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
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            dataReport.Circulos_Sociales.Clear();//limpia lo que estaba antes en el reporte
            _Conexion.Open();
            if (txt_Filtrar.Text != "")
            {
                switch (CB_Filtros.SelectedIndex)
                {
                    //Filtro por organizacion
                    case 0:
                        filtro = "SELECT * FROM [dbo].[Alianza_Ods] WHERE Nombre_Organizacion LIKE '%" + txt_Filtrar.Text + "%'";
                        break;
                    //Filtro por Cargo
                    case 1:
                        filtro = "SELECT * FROM [dbo].[Alianza_Ods] WHERE Nombre_Cargo LIKE '%" + txt_Filtrar.Text + "%'";
                        break;
                    //Filtro por Sector
                    case 2:
                        filtro = "SELECT * FROM [dbo].[Alianza_Ods] WHERE Nombre_Sector LIKE '%" + txt_Filtrar.Text + "%'";
                        break;
                    //Sin filtro
                    case 3:
                        filtro = "SELECT * FROM [dbo].[Alianza_Ods]";
                        break;
                    //si noo se selecciona nada
                    default:
                        filtro = "SELECT * FROM [dbo].[Alianza_Ods]";
                        break;
                }
            }
            else filtro = "SELECT * FROM [dbo].[Alianza_Ods]";
            //Llena los datos de la base de datos al data set para ser mostrado en el crystar report viewer
            SqlDataAdapter AlianzaOds = new SqlDataAdapter(filtro, _Conexion);
            AlianzaOds.Fill(dataReport.Alianza_Ods);
            AOds AlianzaOdsReport = new AOds();
            AlianzaOdsReport.SetDataSource(dataReport);
            CR_AO.ReportSource = AlianzaOdsReport;
            _Conexion.Close();
        }
    }
}
