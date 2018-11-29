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
    public partial class RSocios_Estrategicos : Form
    {
        public RSocios_Estrategicos()
        {
            InitializeComponent();
        }

        private void RSocios_Estrategicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'CITRADataSet.Socios_Estrategicos' Puede moverla o quitarla según sea necesario.
            this.Socios_EstrategicosTableAdapter.Fill(this.CITRADataSet.Socios_Estrategicos);

            this.reportViewer1.RefreshReport();
        }
    }
}
