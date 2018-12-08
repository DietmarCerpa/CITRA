using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Presentacion.Reportes.Estaticos
{
    public partial class RepCirculos_Sociales : Form
    {
        static SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        CITRADataSet dataReport = new CITRADataSet();
        string filtro;
        public RepCirculos_Sociales()
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
                        filtro = "SELECT * FROM Circulos_Sociales WHERE Nombre_Organizacion LIKE " + textBox1.Text + "%";
                        break;
                    case 1:
                        filtro = "SELECT * FROM Circulos_Sociales WHERE Nombre_Departamento LIKE " + textBox1.Text + "%";
                        break;
                    default:
                        filtro = "SELECT * FROM Circulos_Sociales";
                        break;
                }
            }
            else filtro = "SELECT * FROM Circulos_Sociales";
            SqlDataAdapter CirculosSoc = new SqlDataAdapter(filtro, _Conexion);
            CirculosSoc.Fill(dataReport);
            AOds CirSocReport = new AOds();
            CirSocReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = CirSocReport;
        }
    }
}
