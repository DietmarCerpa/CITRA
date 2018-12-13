using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BDepartamentos : Form
    {
        public BDepartamentos()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BDepartamentos_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosDepartamentos();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarDepartamentos(Txt_Buscar.Text);
            else dgv.DataSource = sql.MostrarDatosDepartamentos();
        }


    }
}
