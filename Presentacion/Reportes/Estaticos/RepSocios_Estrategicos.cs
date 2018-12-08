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
            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        filtro = "SELECT * FROM Socios_Estrategicos WHERE Nombre_Cargo LIKE " + textBox1.Text + "%";
                        break;
                    case 1:
                        filtro = "SELECT * FROM Socios_Estrategicos WHERE Nombre_Organizacion LIKE " + textBox1.Text + "%";
                        break;
                    default:
                        filtro = "SELECT * FROM Socios_Estrategicos";
                        break;
                }
            }
            else filtro = "SELECT * FROM Socios_Estrategicos";

            SqlDataAdapter SociosEst = new SqlDataAdapter(filtro, _Conexion);
            SociosEst.Fill(dataReport);
            AOds SocEstReport = new AOds();
            SocEstReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = SocEstReport;
        }

        private void RepSocios_Estrategicos_Load(object sender, EventArgs e)
        {

        }
    }
}
