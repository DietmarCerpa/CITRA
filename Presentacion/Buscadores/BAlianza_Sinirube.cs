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
    public partial class BAlianza_Sinirube : Form
    {
        public BAlianza_Sinirube()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BAlianza_Sinirube_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosSinirube();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text  == "1. Nombre")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarSinirubeNombre(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosSinirube();
            }

            if (Cbo_Buscar.Text == "2. Cargo")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarSinirubeCargo(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosSinirube();
            }

            if (Cbo_Buscar.Text == "3. Organización")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarSinirubeOrganizacion(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosSinirube();
            }
        }
    }
}
