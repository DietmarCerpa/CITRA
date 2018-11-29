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
using Negocios;

namespace Presentacion
{
    public partial class BCirculos_Sociales : Form
    {
        public BCirculos_Sociales()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BCirculos_Sociales_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosCirculos();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Nombre")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarCirculoNombre(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosCirculos();
            }

            if (Cbo_Buscar.Text == "2. Organización")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarCirculoOrganizacion(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosCirculos();
            }

            if (Cbo_Buscar.Text == "3. Departamento")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarCirculoDepartamento(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosCirculos();
            }
        }


    }
}
