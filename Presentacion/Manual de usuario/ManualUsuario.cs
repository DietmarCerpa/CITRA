using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Manual_de_usuario
{
    public partial class ManualUsuario : Form
    {
        public ManualUsuario()
        {
            InitializeComponent();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void ManualUsuario_Load(object sender, EventArgs e)
        {
         
            axAcroPDF1.LoadFile("MANUALDEUSUARIO.pdf");
        }
    }
}
