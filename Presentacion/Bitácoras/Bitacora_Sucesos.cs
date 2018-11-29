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
    public partial class Bitacora_Sucesos : Form
    {
        public Bitacora_Sucesos()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Transacción")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarTransaccion(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosSucesos();
            }

            if (Cbo_Buscar.Text == "2. Tabla Afectada")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarTabla(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosSucesos();
            }

            if (Cbo_Buscar.Text == "3. Fecha")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarFecha(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarDatosSucesos();
            }
        }

        private void Bitacora_Sucesos_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosSucesos();
        }

        

       


    }
}
