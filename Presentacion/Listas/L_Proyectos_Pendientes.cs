using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Listas
{
    public partial class L_Proyectos_Pendientes : Frm_Lista_Base
    {
        public L_Proyectos_Pendientes()
        {
            InitializeComponent();
        }

        private void L_Proyectos_Pendientes_Load(object sender, EventArgs e)
        {
            btn_ingresar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_consultar.Enabled = false;
        }

        private void L_Proyectos_Pendientes_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
