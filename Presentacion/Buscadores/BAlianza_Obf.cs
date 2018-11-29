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
    public partial class BAlianza_Obf : Form
    {
        public BAlianza_Obf()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BAlianza_Obf_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosObf();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Nombre")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarObfNombre(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosObf();
            }

            if (Cbo_Buscar.Text == "2. Organización")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarObfOrganizacion(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosObf();
            }
        }
    }
}
