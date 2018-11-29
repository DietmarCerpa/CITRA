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
    public partial class BSocios_Estrategicos : Form
    {
        public BSocios_Estrategicos()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BSocios_Estrategicos_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosSocios();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Nombre")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarSocioNombre(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosSocios();
            }

            if (Cbo_Buscar.Text == "2. Cargo")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarSocioCargo(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosSocios();
            }

            if (Cbo_Buscar.Text == "3. Organización")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarSocioOrganizacion(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosSocios();
            }
        }


    }
}
