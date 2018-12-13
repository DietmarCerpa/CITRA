using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BPermisosxRol : Form
    {
        public BPermisosxRol()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BPermisosxRol_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosPermisoxRol();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Rol")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarRolxPermiso(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosPermisoxRol();
            }

            if (Cbo_Buscar.Text == "2. Permiso")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarPermisoxRol(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosPermisoxRol();
            }

        }




    }
}
