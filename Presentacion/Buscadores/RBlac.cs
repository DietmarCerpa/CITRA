using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class RBlac : Form
    {
        public RBlac()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Nombre")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarRblacNombre(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosRblac();
            }

            if (Cbo_Buscar.Text == "2. Cargo")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarRblacCargo(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosRblac();
            }

            if (Cbo_Buscar.Text == "3. Departamento")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarRblacDepartamento(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosRblac();
            }
        }

        private void RBlac_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosRblac();
        }
    }
}
