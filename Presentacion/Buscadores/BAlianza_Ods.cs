using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BAlianza_Ods : Form
    {
        public BAlianza_Ods()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BAlianza_Ods_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosOds();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Nombre")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarOdsNombre(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosOds();
            }

            if (Cbo_Buscar.Text == "2. Cargo")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarOdsCargo(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosOds();
            }

            if (Cbo_Buscar.Text == "3. Organización")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarOdsOrganizacion(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosOds();
            }

        }
    }
}
