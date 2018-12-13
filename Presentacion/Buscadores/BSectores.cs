using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BSectores : Form
    {
        public BSectores()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarSectores(Txt_Buscar.Text);
            else dgv.DataSource = sql.MostrarDatosSectores(); 
        }

        private void BSectores_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosSectores();
        }


    }
}
