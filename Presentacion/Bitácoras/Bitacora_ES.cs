using System;
using System.Windows.Forms;
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
        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Buscar.Text != "")
            {
                if (Cbo_Buscar.Text == "1. Usuario") dgvES.DataSource = sql.BuscarIDUsuario(Txt_Buscar.Text);
                if (Cbo_Buscar.Text == "2. Fecha") dgvES.DataSource = sql.BuscarFechaES(Txt_Buscar.Text);
                if (Cbo_Buscar.Text == "3. Tipo Transacción") dgvES.DataSource = sql.BuscarTransaccionES(Txt_Buscar.Text);
            
            }
            else dgvES.DataSource = sql.MostrarDatosES();
        }
        private void Bitacora_ES_Load(object sender, EventArgs e)
        {
            dgvES.DataSource = sql.MostrarDatosES();
        }
    }
}
