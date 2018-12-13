using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BAlianza_Inamu : Form
    {
        public BAlianza_Inamu()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BAlianza_Inamu_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosInamu();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Nombre")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarInamuNombre(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosInamu();
            }

            if (Cbo_Buscar.Text == "2. Cargo")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarInamuCargo(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosInamu();
            }

            if (Cbo_Buscar.Text == "3. Organización")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarInamuOrganizacion(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosInamu();
            }
        }
    }
}
