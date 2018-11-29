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
    public partial class RCirculos_Sociales : Form
    {
        public RCirculos_Sociales()
        {
            InitializeComponent();
        }

        private void RCirculos_Sociales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'CITRADataSet.CirculoxDepartamento' Puede moverla o quitarla según sea necesario.
            //this.CirculoxDepartamentoTableAdapter.FillCirculoxDepartamento(this.CITRADataSet.CirculoxDepartamento);
            // TODO: esta línea de código carga datos en la tabla 'CITRADataSet.Circulos_Sociales' Puede moverla o quitarla según sea necesario.
            this.Circulos_SocialesTableAdapter.Fill(this.CITRADataSet.Circulos_Sociales);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
