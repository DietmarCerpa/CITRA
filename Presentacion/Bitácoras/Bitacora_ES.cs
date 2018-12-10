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
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class Bitacora_ES : Form
    {
        public Bitacora_ES()
        {
            InitializeComponent();
        }
        ConsultasSQL sql = new ConsultasSQL();
        private void lstdatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
       {
            if (Cbo_Buscar.Text == "1. Usuario")
            {
                if (Txt_Buscar.Text != "") dgvES.DataSource = sql.BuscarIDUsuario(Txt_Buscar.Text);
                else dgvES.DataSource = sql.MostrarDatosES();
            }

            if (Cbo_Buscar.Text == "2. Fecha")
            {
                if (Txt_Buscar.Text != "") dgvES.DataSource = sql.BuscarFechaES(Txt_Buscar.Text);
                else dgvES.DataSource = sql.MostrarDatosES();
            }

            if (Cbo_Buscar.Text == "3. Tipo Transacción")
            {
                if (Txt_Buscar.Text != "") dgvES.DataSource = sql.BuscarTransaccionES(Txt_Buscar.Text);
                else dgvES.DataSource = sql.MostrarDatosES();
            }
        }

        private void Bitacora_ES_Load(object sender, EventArgs e)
        {
            dgvES.DataSource = sql.MostrarDatosES();
        }
    }
}
