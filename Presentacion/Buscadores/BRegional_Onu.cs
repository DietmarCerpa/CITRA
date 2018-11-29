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
    public partial class BRegional_Onu : Form
    {
        public BRegional_Onu()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BRegional_Onu_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosOnu();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. País")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarOnuPais(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosOnu();
            }

            if (Cbo_Buscar.Text == "2. Director")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarOnuNombre(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosOnu();
            }

            if (Cbo_Buscar.Text == "3. ADRR")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarOnuAdrr(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosOnu();
            }
        }
    }
}
