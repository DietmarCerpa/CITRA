using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace Presentacion.Reportes.Estaticos
{
    public partial class RepAlianza_Ods : Form
    {
        static SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());      
        CITRADataSet dataReport = new CITRADataSet();
        string filtro;
        public RepAlianza_Ods()
        {
            InitializeComponent();
        }

        private void RepAlianza_Ods_Load(object sender, EventArgs e)
        {    
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        filtro = "SELECT * FROM Alianza_Ods WHERE Nombre_Organizacion LIKE " + textBox1.Text + "%";
                        break;
                    case 1:
                        filtro = "SELECT * FROM Alianza_Ods WHERE Nombre_Cargo LIKE " + textBox1.Text + "%";
                        break;
                    case 2:
                        filtro = "SELECT * FROM Alianza_Ods WHERE Nombre_Sector LIKE " + textBox1.Text + "%";
                        break;
                    default:
                        filtro = "SELECT * FROM Alianza_Ods";
                        break;
                }
            }
            else filtro = "SELECT * FROM Alianza_Ods";

            SqlDataAdapter AlianzaOds = new SqlDataAdapter(filtro, _Conexion);
            AlianzaOds.Fill(dataReport);
            AOds AlianzaOdsReport = new AOds();
            AlianzaOdsReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = AlianzaOdsReport;
        }
    }
}
