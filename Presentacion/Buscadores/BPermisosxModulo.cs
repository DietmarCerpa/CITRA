﻿using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class BPermisosxModulo : Form
    {
        public BPermisosxModulo()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void BPermisosxModulo_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarPermisoModulo();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbo_Buscar.Text == "1. Rol")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarRolModulo(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarPermisoModulo();
            }

            if (Cbo_Buscar.Text == "2. Módulo")
            {
                if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarModuloRol(Txt_Buscar.Text);
                else dgv.DataSource = sql.MostrarPermisoModulo();
            }

        }




    }
}
