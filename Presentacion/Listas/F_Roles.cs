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
    public partial class F_Roles : Frm_Lista_Base
    {
        public F_Roles(int idusuario, int idRol, string usuario)
        {
            InitializeComponent();
            lb_usuario.Text = usuario;
            lbiduser.Text = idusuario.ToString();
            lbidrol.Text = idRol.ToString();
        }

        Roles IROLES;

        private void F_Roles_Load(object sender, EventArgs e)
        {
            IROLES = new Roles();

            DataTable dt = new DataTable();

            try
            {
                dt = IROLES.LlenarLista();
                Utiles.FillListView(lstDatos, dt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void F_Roles_Evento_Actualizar_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection _Conexion = new SqlConnection(@"Data Source=JTONYVAIO; Initial Catalog= CITRA; Integrated Security= true");
                string CadenaSql = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Rol " +
                                   " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                                   " WHERE [CITRA].[dbo].Permisos_x_Rol.Id_Permiso = 3 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
                /*MessageBox.Show(CadenaSql);*/
                SqlCommand comando = new SqlCommand(CadenaSql, _Conexion);
                _Conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();
                int resultado = 0;
                if (leer.Read() == true) { resultado = leer.GetInt32(0);/*devuelve algo*/}

                if (resultado > 0) /*Si tiene persmisos haga esto*/
                {
                    if (this.lstDatos.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Debe de seleccionar una fila de la lista", "Validación de Datos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                        return;
                    }
                    mRoles frm = new mRoles();
                    frm.Modo = "M";
                    frm.Id_Rol = Convert.ToInt32(this.lstDatos.SelectedItems[0].Text);//.ToString
                    frm.MostrarIngresar = false;
                    frm.MostrarEliminar = false;
                    frm.MostrarConsultar = false;
                    frm.Controls["Txt_Id_Rol"].Enabled = false;
                    frm.ShowDialog();
                    F_Roles_Load(null, null);
                }
                else { MessageBox.Show("El usuario no tiene permisos para realizar esta acción", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); ; return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void F_Roles_Evento_Consultar(object sender, EventArgs e)
        {
            try
            {
                SqlConnection _Conexion = new SqlConnection(@"Data Source=JTONYVAIO; Initial Catalog= CITRA; Integrated Security= true");
                string CadenaSql = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Rol " +
                                   " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                                   " WHERE [CITRA].[dbo].Permisos_x_Rol.Id_Permiso = 4 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
                /*MessageBox.Show(CadenaSql);*/
                SqlCommand comando = new SqlCommand(CadenaSql, _Conexion);
                _Conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();
                int resultado = 0;
                if (leer.Read() == true) { resultado = leer.GetInt32(0);/*devuelve algo*/}

                if (resultado > 0) /*Si tiene persmisos haga esto*/
                {
                    BRoles frm = new BRoles();
                    frm.ShowDialog();
                }
                else { MessageBox.Show("El usuario no tiene permisos para realizar esta acción", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); ; return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void F_Roles_Evento_Eliminar(object sender, EventArgs e)
        {
            try
            {
                SqlConnection _Conexion = new SqlConnection(@"Data Source=JTONYVAIO; Initial Catalog= CITRA; Integrated Security= true");
                string CadenaSql = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Rol " +
                                   " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                                   " WHERE [CITRA].[dbo].Permisos_x_Rol.Id_Permiso = 2 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
                /*MessageBox.Show(CadenaSql);*/
                SqlCommand comando = new SqlCommand(CadenaSql, _Conexion);
                _Conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();
                int resultado = 0;
                if (leer.Read() == true) { resultado = leer.GetInt32(0);/*devuelve algo*/}

                if (resultado > 0) /*Si tiene persmisos haga esto*/
                {
                    if (this.lstDatos.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Debe de seleccionar una fila de la lista", "Validación de Datos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                        return;
                    }
                    mRoles frm = new mRoles();
                    frm.Modo = "E";
                    frm.Id_Rol = Convert.ToInt32(this.lstDatos.SelectedItems[0].Text);
                    frm.MostrarIngresar = false;
                    frm.MostrarConsultar = false;
                    frm.MostrarActualizar = false;
                    frm.Controls["Txt_Id_Rol"].Enabled = false;
                    frm.Controls["Txt_Nombre_Rol"].Enabled = false;
                    frm.Controls["Txt_Nivel"].Enabled = false;
                    frm.ShowDialog();
                    F_Roles_Load(null, null);
                }
                else { MessageBox.Show("El usuario no tiene permisos para realizar esta acción", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); ; return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void F_Roles_Evento_Ingresar(object sender, EventArgs e)
        {
            try
            {
                SqlConnection _Conexion = new SqlConnection(@"Data Source=JTONYVAIO; Initial Catalog= CITRA; Integrated Security= true");
                string CadenaSql = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Rol " +
                                   " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                                   " WHERE [CITRA].[dbo].Permisos_x_Rol.Id_Permiso = 1 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
                /*MessageBox.Show(CadenaSql);*/
                SqlCommand comando = new SqlCommand(CadenaSql, _Conexion);
                _Conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();
                int resultado = 0;
                if (leer.Read() == true) { resultado = leer.GetInt32(0);/*devuelve algo*/}

                if (resultado > 0) /*Si tiene persmisos haga esto*/
                {
                    mRoles frm = new mRoles();
                    frm.Modo = "A";
                    frm.MostrarEliminar = false;
                    frm.MostrarActualizar = false;
                    frm.MostrarConsultar = false;
                    frm.ShowDialog();
                    F_Roles_Load(null, null);
                }
                else { MessageBox.Show("El usuario no tiene permisos para realizar esta acción", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); ; return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void F_Roles_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
