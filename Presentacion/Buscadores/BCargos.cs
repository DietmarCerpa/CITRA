using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BCargos : Form
    {
        public BCargos()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();


        private void BCargos_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatos();
            
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Buscar.Text != "") dgv.DataSource = sql.Buscar(Txt_Buscar.Text);
            else dgv.DataSource = sql.MostrarDatos();
        }


    }
}
