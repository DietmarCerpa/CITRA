using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class RAlianza_Ods : Form
    {
        public RAlianza_Ods()
        {
            InitializeComponent();
        }

        private void RAlianza_Ods_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cITRADataSet.Alianza_Ods' Puede moverla o quitarla según sea necesario.
            this.alianza_OdsTableAdapter.Fill(this.cITRADataSet.Alianza_Ods);

            this.reportViewer1.RefreshReport();
        }
    }
}
