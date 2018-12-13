using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BCamaras_Privadas : Form
    {
        public BCamaras_Privadas()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BCamaras_Privadas_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosCamaras();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Nombre")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarCamaraNombre(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosCamaras();
            }

            if (Cbo_Buscar.Text == "2. Cargo")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarCamaraCargo(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosCamaras();
            }

            if (Cbo_Buscar.Text == "3. Organización")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarCamaraOrganizacion(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosCamaras();
            }

        }


    }
}
