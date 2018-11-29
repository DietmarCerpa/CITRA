using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion;

namespace Principal
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

 

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Colaboradores ListaSistema = new L_Colaboradores();
            ListaSistema.titulo = "Mantenimiento de Colaboradores";
            ListaSistema.Descripcion = "Formulario en el cual se pueden realizar funciones acerca de los empleados de la institución";
            ListaSistema.PieFormulario = "Colaboradores Empresa La Poderosa";
            //ListaSistema.MdiParent = this;
            ListaSistema.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void avancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Avances_Proyectos ListaSistema = new L_Avances_Proyectos();
            ListaSistema.titulo = "Mantenimiento para Avances de Proyectos";
            ListaSistema.Descripcion = "Formulario en el cual se pueden realizar funciones acerca de los avances de proyectos en la institución";
            ListaSistema.PieFormulario = "Avances de Proyectos Empresa La Poderosa";
            //ListaSistema.MdiParent = this;
            ListaSistema.Show();

        }

        private void proyectosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            L_Proyectos ListaSistema = new L_Proyectos();
            ListaSistema.titulo = "Mantenimiento para Proyectos";
            ListaSistema.Descripcion = "Formulario en el cual se pueden realizar funciones acerca de proyectos en la institución";
            ListaSistema.PieFormulario = "Proyectos Empresa La Poderosa";
            //ListaSistema.MdiParent = this;
            ListaSistema.Show();
        }

        private void colaboradoresPorProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Colaboradores_Proyectos ListaSistema = new L_Colaboradores_Proyectos();
            ListaSistema.titulo = "Mantenimiento para Colaboradores de Proyectos";
            ListaSistema.Descripcion = "Formulario en el cual se pueden realizar funciones acerca de los Colaboradores por Proyecto";
            ListaSistema.PieFormulario = "Colaboradores-Proyectos Empresa La Poderosa";
            //ListaSistema.MdiParent = this;
            ListaSistema.Show();
        }

        private void proyectosConcluidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Proyectos_Concluidos ListaSistema = new L_Proyectos_Concluidos();
            ListaSistema.titulo = "Proyectos Concluidos La Poderosa";
            ListaSistema.Descripcion = "Formulario en el cual se pueden ver los proyectos acabados de la institucion";
            ListaSistema.PieFormulario = "Proyectos Concluidos Empresa La Poderosa";
            //ListaSistema.MdiParent = this;
            ListaSistema.Show();
        }

        private void proyectosPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*L_Proyectos_Pendientes ListaSistema = new L_Proyectos_Pendientes();
            ListaSistema.titulo = "Proyectos Pendientes La Poderosa";
            ListaSistema.Descripcion = "Formulario en el cual se pueden ver los proyectos que estan pendientes de finalizacion";
            ListaSistema.PieFormulario = "Proyectos Pendientes Empresa La Poderosa";
            //ListaSistema.MdiParent = this;
            ListaSistema.Show();*/
        }

        
    }
}
