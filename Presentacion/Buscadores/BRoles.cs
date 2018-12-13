using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BRoles : Form
    {
        public BRoles()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BRoles_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosRoles();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarRol(Txt_Buscar.Text);
            else dgv.DataSource = sql.MostrarDatosRoles();
        }
    }
}
