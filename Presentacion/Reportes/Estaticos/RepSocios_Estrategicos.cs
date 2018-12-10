using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Presentacion.Reportes.Estaticos
{
    public partial class RepSocios_Estrategicos : Form
    {
        static SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        CITRADataSet dataReport = new CITRADataSet();
        string filtro;

        public RepSocios_Estrategicos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Filtrar.Text != "")
            {
                switch (CB_SE.SelectedIndex)
                {
                    case 0:
                        filtro = "SELECT * FROM [dbo].[Socios_Estrategicos] WHERE Nombre_Cargo LIKE %" + txt_Filtrar.Text + "%";
                        break;
                    case 1:
                        filtro = "SELECT * FROM [dbo].[Socios_Estrategicos] WHERE Nombre_Organizacion LIKE %" + txt_Filtrar.Text + "%";
                        break;
                    default:
                        filtro = "SELECT * FROM [dbo].[Socios_Estrategicos]";
                        break;
                }
            }
            else filtro = "SELECT * FROM [dbo].[Socios_Estrategicos]";

            SqlDataAdapter SociosEst = new SqlDataAdapter(filtro, _Conexion);
            SociosEst.Fill(dataReport);
            AOds SocEstReport = new AOds();
            SocEstReport.SetDataSource(dataReport);
            CR_SE.ReportSource = SocEstReport;
        }

        private void RepSocios_Estrategicos_Load(object sender, EventArgs e)
        {

        }
    }
}
