using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BUsuarios : Form
    {
        public BUsuarios()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BUsuarios_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosUsuario();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Nombre Persona")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarUsuarioNombre(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosUsuario();
            }

            if (Cbo_Buscar.Text == "2. Cédula")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarUsuarioCedula(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosUsuario();
            }

            if (Cbo_Buscar.Text == "3. Rol")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarUsuarioRol(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosUsuario();
            }

            if (Cbo_Buscar.Text == "4. Usuario")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarUsuarioUsuario(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosRblac();
            }
        }


    }
}
