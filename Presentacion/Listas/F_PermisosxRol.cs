using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Negocios;

namespace Presentacion
{
    public partial class F_PermisosxRol : Frm_Lista_Base
    {
        SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        public F_PermisosxRol(int idusuario, int idRol, string usuario)
        {
            InitializeComponent();
            lb_usuario.Text = usuario;
            lbiduser.Text = idusuario.ToString();
            lbidrol.Text = idRol.ToString();
        }

        PermisosxRoles IPERMISOSXROLES;

        private void F_PermisosxRol_Load(object sender, EventArgs e)
        {
            IPERMISOSXROLES = new PermisosxRoles();

            DataTable dt = new DataTable();

            try
            {
                dt = IPERMISOSXROLES.LlenarLista();
                Utiles.FillListView(lstDatos, dt);
                btn_actualizar.Visible = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void F_PermisosxRol_Evento_Consultar(object sender, EventArgs e)
        {
            
            try
            {
                string CadenaSql = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Rol " +
                                   " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                                   " WHERE [CITRA].[dbo].Permisos_x_Rol.Id_Permiso = 4 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
                /*MessageBox.Show(CadenaSql);*/
                SqlCommand comando = new SqlCommand(CadenaSql, _Conexion);
                _Conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();
                int resultado = 0;
                if (leer.Read() == true) { resultado = leer.GetInt32(0);/*devuelve algo*/}
                _Conexion.Close();
                if (resultado > 0) /*Si tiene persmisos haga esto*/
                {
                    BPermisosxRol frm = new BPermisosxRol();
                    frm.ShowDialog();
                }
                else { MessageBox.Show("El usuario no tiene permisos para realizar esta acción", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); ; return; }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void F_PermisosxRol_Evento_Eliminar(object sender, EventArgs e)
        {
            try
            {
                string CadenaSql = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Rol " +
                                   " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                                   " WHERE [CITRA].[dbo].Permisos_x_Rol.Id_Permiso = 2 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
                /*MessageBox.Show(CadenaSql);*/
                SqlCommand comando = new SqlCommand(CadenaSql, _Conexion);
                _Conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();  
                int resultado = 0;
                if (leer.Read() == true) { resultado = leer.GetInt32(0);/*devuelve algo*/}
                _Conexion.Close();
                if (resultado > 0) /*Si tiene persmisos haga esto*/
                {
                    if (this.lstDatos.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Debe de seleccionar una fila de la lista", "Validación de Datos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                        return;
                    }
                    mPermisosxRol frm = new mPermisosxRol();
                    frm.Modo = "E";
                    frm.id_Rol = Convert.ToInt32(this.lstDatos.SelectedItems[0].Text);
                    frm.MostrarIngresar = false;
                    frm.MostrarConsultar = false;
                    frm.MostrarActualizar = false;
                    frm.Controls["Cbo_Id_Rol"].Enabled = false;
                    frm.Controls["Cbo_Id_Permiso"].Enabled = false;
                    frm.ShowDialog();
                    F_PermisosxRol_Load(null, null);
                }
                else { MessageBox.Show("El usuario no tiene permisos para realizar esta acción", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); ; return; }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void F_PermisosxRol_Evento_Ingresar(object sender, EventArgs e)
        {
            try
            {
                string CadenaSql = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Rol " +
                                   " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                                   " WHERE [CITRA].[dbo].Permisos_x_Rol.Id_Permiso = 1 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
                /*MessageBox.Show(CadenaSql);*/
                SqlCommand comando = new SqlCommand(CadenaSql, _Conexion);
                _Conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();
                int resultado = 0;
                if (leer.Read() == true) { resultado = leer.GetInt32(0);/*devuelve algo*/}
                _Conexion.Close();
                if (resultado > 0) /*Si tiene persmisos haga esto*/
                {
                    mPermisosxRol frm = new mPermisosxRol();
                    frm.Modo = "A";
                    frm.MostrarEliminar = false;
                    frm.MostrarActualizar = false;
                    frm.MostrarConsultar = false;
                    frm.ShowDialog();
                    F_PermisosxRol_Load(null, null);
                }
                else { MessageBox.Show("El usuario no tiene permisos para realizar esta acción", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); ; return; }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void F_PermisosxRol_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
