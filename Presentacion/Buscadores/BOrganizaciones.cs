using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BOrganizaciones : Form
    {
        public BOrganizaciones()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BOrganizaciones_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosOrganizaciones();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarOrganizaciones(Txt_Buscar.Text);
            else dgv.DataSource = sql.MostrarDatosOrganizaciones();
        }
    }
}
