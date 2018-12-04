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
using System.Data.SqlClient;

namespace Principal
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal(int idusuario, int idRol, string usuario)
        {
            InitializeComponent();
            lb_usuario.Text = usuario;
            lbiduser.Text = idusuario.ToString();
            lbidrol.Text = idRol.ToString();

            /*if (idRol == 3)
            { //Si es Estandar ocultar esos menú
                mantenimientosToolStripMenuItem1.Visible = false;
                BitacoraToolStripMenuItem.Visible = false;
            } 
            
            MessageBox.Show("User " + idRol.ToString() + " ", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

 

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            SqlConnection _Conexion = new SqlConnection(@"Data Source=JTONYVAIO; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");

            #region "Validación Alianza Inamu(Modulo 1)"

            string CadenaSql1 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 1 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando1 = new SqlCommand(CadenaSql1, _Conexion);
            _Conexion.Open();
            SqlDataReader leer1 = comando1.ExecuteReader();
            int resultado1 = 0;
            if (leer1.Read() == true) { resultado1 = leer1.GetInt32(0);/*devuelve algo*/}

            if (resultado1 > 0) /*Si tiene persmisos haga esto*/
            {
                alianzaInamuToolStripMenuItem.Visible = true;
            }
            else
            {
                alianzaInamuToolStripMenuItem.Visible = false;
                //return;
            }
            leer1.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Alianza OBF(Modulo 2)"
            //SqlConnection _Conexion2 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql2 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 2 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando2 = new SqlCommand(CadenaSql2, _Conexion);
            _Conexion.Open();
            SqlDataReader leer2 = comando2.ExecuteReader();
            int resultado2 = 0;
            if (leer2.Read() == true) { resultado2 = leer2.GetInt32(0);/*devuelve algo*/}
        
            if (resultado2 > 0) //
            {
                oBFToolStripMenuItem.Visible = true;
            }
            else
            {
                oBFToolStripMenuItem.Visible = false;
                //return;
            }
            leer2.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Alianza ODS(Modulo 3)"
            //SqlConnection _Conexion = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql3 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 3 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando3 = new SqlCommand(CadenaSql3, _Conexion);
            _Conexion.Open();
            SqlDataReader leer3 = comando2.ExecuteReader();
            int resultado3 = 0;
            if (leer3.Read() == true) { resultado3 = leer3.GetInt32(0);/*devuelve algo*/}

            if (resultado3 > 0) /*Si tiene persmisos haga esto*/
            {
                oDSToolStripMenuItem.Visible = true;
            }
            else
            {
                oDSToolStripMenuItem.Visible = false;
                //return;
            }
            leer3.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Alianza Sinirube(Modulo 4)"
            //SqlConnection _Conexion4 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql4 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 4 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando4 = new SqlCommand(CadenaSql4, _Conexion);
            _Conexion.Open();
            SqlDataReader leer4 = comando4.ExecuteReader();
            int resultado4 = 0;
            if (leer4.Read() == true) { resultado4 = leer4.GetInt32(0);/*devuelve algo*/}

            if (resultado4 > 0) /*Si tiene persmisos haga esto*/
            {
                SinirubeToolStripMenuItem.Visible = true;
            }
            else
            {
                SinirubeToolStripMenuItem.Visible = false;
                //return;
            }
            leer4.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Cámaras Privadas(Modulo 5)"
            //SqlConnection _Conexion5 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql5 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 5 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando5 = new SqlCommand(CadenaSql5, _Conexion);
            _Conexion.Open();
            SqlDataReader leer5 = comando4.ExecuteReader();
            int resultado5 = 0;
            if (leer5.Read() == true) { resultado5 = leer5.GetInt32(0);/*devuelve algo*/}

            if (resultado5 > 0) /*Si tiene persmisos haga esto*/
            {
                cámarasPrivadasToolStripMenuItem1.Visible = true;
            }
            else
            {
                cámarasPrivadasToolStripMenuItem1.Visible = false;
                //return;
            }
            leer5.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Cargos(Modulo 6)"
            //SqlConnection _Conexion6 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql6 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 6 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando6 = new SqlCommand(CadenaSql6, _Conexion);
            _Conexion.Open();
            SqlDataReader leer6 = comando6.ExecuteReader();
            int resultado6 = 0;
            if (leer6.Read() == true) { resultado6 = leer6.GetInt32(0);/*devuelve algo*/}

            if (resultado6 > 0) /*Si tiene persmisos haga esto*/
            {
                cargosToolStripMenuItem.Visible = true;
            }
            else {
                cargosToolStripMenuItem.Visible = false;
                //return; 
            }
            leer6.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Círculos Sociales(Modulo 7)"
            //SqlConnection _Conexion7 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql7 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 7 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando7 = new SqlCommand(CadenaSql7, _Conexion);
            _Conexion.Open();
            SqlDataReader leer7 = comando7.ExecuteReader();
            int resultado7 = 0;
            if (leer7.Read() == true) { resultado7 = leer7.GetInt32(0);/*devuelve algo*/}

            if (resultado7 > 0) /*Si tiene persmisos haga esto*/
            {
                cículosSocialesToolStripMenuItem.Visible = true;
            }
            else
            {
                cículosSocialesToolStripMenuItem.Visible = false;
                //return;
            }
            leer7.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Departamentos(Modulo 8)"
            //SqlConnection _Conexion8 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql8 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 8 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando8 = new SqlCommand(CadenaSql8, _Conexion);
            _Conexion.Open();
            SqlDataReader leer8 = comando8.ExecuteReader();
            int resultado8 = 0;
            if (leer8.Read() == true) { resultado8 = leer8.GetInt32(0);/*devuelve algo*/}

            if (resultado8 > 0) /*Si tiene persmisos haga esto*/
            {
                departamentosToolStripMenuItem.Visible = true;
            }
            else
            {
                departamentosToolStripMenuItem.Visible = false;
                //return;
            }
            leer8.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Organizaciones(Modulo 9)"
            //SqlConnection _Conexion9 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql9 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 9 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando9 = new SqlCommand(CadenaSql9, _Conexion);
            _Conexion.Open();
            SqlDataReader leer9 = comando9.ExecuteReader();
            int resultado9 = 0;
            if (leer9.Read() == true) { resultado9 = leer9.GetInt32(0);/*devuelve algo*/}

            if (resultado9 > 0) /*Si tiene persmisos haga esto*/
            {
                organizacionesToolStripMenuItem.Visible = true;
            }
            else
            {
                organizacionesToolStripMenuItem.Visible = false;
                //return;
            }
            leer9.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Países(Modulo 10)"
            //SqlConnection _Conexion10 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql10 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 10 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando10 = new SqlCommand(CadenaSql10, _Conexion);
            _Conexion.Open();
            SqlDataReader leer10 = comando10.ExecuteReader();
            int resultado10 = 0;
            if (leer10.Read() == true) { resultado10 = leer10.GetInt32(0);/*devuelve algo*/}

            if (resultado10 > 0) /*Si tiene persmisos haga esto*/
            {
                paísesToolStripMenuItem1.Visible = true;
            }
            else
            {
                paísesToolStripMenuItem1.Visible = false;
                //return;
            }
            leer10.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Permisos x Modulo(Modulo 11)"
            //SqlConnection _Conexion11 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql11 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 11 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando11 = new SqlCommand(CadenaSql11, _Conexion);
            _Conexion.Open();
            SqlDataReader leer11 = comando11.ExecuteReader();
            int resultado11 = 0;
            if (leer11.Read() == true) { resultado11 = leer11.GetInt32(0);/*devuelve algo*/}

            if (resultado11 > 0) /*Si tiene persmisos haga esto*/
            {
                permisosPorMóduloToolStripMenuItem.Visible = true;
            }
            else
            {
                permisosPorMóduloToolStripMenuItem.Visible = false;
                //return;
            }
            leer11.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Permisos x Rol(Modulo 12)"
            //SqlConnection _Conexion12 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql12 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 12 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando12 = new SqlCommand(CadenaSql12, _Conexion);
            _Conexion.Open();
            SqlDataReader leer12 = comando12.ExecuteReader();
            int resultado12 = 0;
            if (leer12.Read() == true) { resultado12 = leer12.GetInt32(0);/*devuelve algo*/}

            if (resultado12 > 0) /*Si tiene persmisos haga esto*/
            {
                permisosPorRolesToolStripMenuItem.Visible = true;
            }
            else
            {
                permisosPorRolesToolStripMenuItem.Visible = false;
                //return;
            }
            leer12.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Rblac(Modulo 13)"
            //SqlConnection _Conexion13 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql13 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 13 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando13 = new SqlCommand(CadenaSql13, _Conexion);
            _Conexion.Open();
            SqlDataReader leer13 = comando13.ExecuteReader();
            int resultado13 = 0;
            if (leer13.Read() == true) { resultado13 = leer13.GetInt32(0);/*devuelve algo*/}

            if (resultado13 > 0) /*Si tiene persmisos haga esto*/
            {
                rblacToolStripMenuItem.Visible = true;
            }
            else
            {
                rblacToolStripMenuItem.Visible = false;
                //return;
            }
            leer13.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Regional ONU(Modulo 14)"
            //SqlConnection _Conexion14 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql14 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 14 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando14 = new SqlCommand(CadenaSql14, _Conexion);
            _Conexion.Open();
            SqlDataReader leer14 = comando14.ExecuteReader();
            int resultado14 = 0;
            if (leer14.Read() == true) { resultado14 = leer14.GetInt32(0);/*devuelve algo*/}

            if (resultado14 > 0) /*Si tiene persmisos haga esto*/
            {
                regionalONUToolStripMenuItem.Visible = true;
            }
            else
            {
                regionalONUToolStripMenuItem.Visible = false;
                //return;
            }
            leer14.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Roles(Modulo 15)"
            //SqlConnection _Conexion15 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql15 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 15 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando15 = new SqlCommand(CadenaSql15, _Conexion);
            _Conexion.Open();
            SqlDataReader leer15 = comando15.ExecuteReader();
            int resultado15 = 0;
            if (leer15.Read() == true) { resultado15 = leer15.GetInt32(0);/*devuelve algo*/}

            if (resultado15 > 0) /*Si tiene persmisos haga esto*/
            {
                rolesDeUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                rolesDeUsuarioToolStripMenuItem.Visible = false;
                //return;
            }
            leer15.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Sectores(Modulo 16)"
            //SqlConnection _Conexion16 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql16 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 16 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando16 = new SqlCommand(CadenaSql16, _Conexion);
            _Conexion.Open();
            SqlDataReader leer16 = comando16.ExecuteReader();
            int resultado16 = 0;
            if (leer16.Read() == true) { resultado16 = leer16.GetInt32(0);/*devuelve algo*/}

            if (resultado16 > 0) /*Si tiene persmisos haga esto*/
            {
                sectoresToolStripMenuItem.Visible = true;
            }
            else
            {
                sectoresToolStripMenuItem.Visible = false;
                //return;
            }
            leer16.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Socios Estratégicos(Modulo 17)"
            //SqlConnection _Conexion17 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql17 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 17 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando17 = new SqlCommand(CadenaSql17, _Conexion);
            _Conexion.Open();
            SqlDataReader leer17 = comando17.ExecuteReader();
            int resultado17 = 0;
            if (leer17.Read() == true) { resultado17 = leer17.GetInt32(0);/*devuelve algo*/}

            if (resultado17 > 0) /*Si tiene persmisos haga esto*/
            {
                sociosEstratégicosToolStripMenuItem.Visible = true;
            }
            else
            {
                sociosEstratégicosToolStripMenuItem.Visible = false;
                //return;
            }
            leer17.Close();
            _Conexion.Close();
            #endregion

            #region "Validación Usuarios(Modulo 18)"
            //SqlConnection _Conexion18 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql18 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 18 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando18 = new SqlCommand(CadenaSql18, _Conexion);
            _Conexion.Open();
            SqlDataReader leer18 = comando18.ExecuteReader();
            int resultado18 = 0;
            if (leer18.Read() == true) { resultado18 = leer18.GetInt32(0);/*devuelve algo*/}

            if (resultado18 > 0) /*Si tiene persmisos haga esto*/
            {
                usuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                usuariosToolStripMenuItem.Visible = false;
                //return;
            }
            leer18.Close();
            _Conexion.Close();
            
            #endregion

            #region "Validación Bitácora Entradas y Salidas(Modulo 19)"
            //SqlConnection _Conexion19 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql19 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 19 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando19 = new SqlCommand(CadenaSql19, _Conexion);
            _Conexion.Open();
            SqlDataReader leer19 = comando19.ExecuteReader();
            int resultado19 = 0;
            if (leer19.Read() == true) { resultado19 = leer19.GetInt32(0);/*devuelve algo*/}

            if (resultado19 > 0) /*Si tiene persmisos haga esto*/
            {
                entradasYSalidasToolStripMenuItem.Visible = true;
            }
            else
            {
                entradasYSalidasToolStripMenuItem.Visible = false;
                //return;
            }
            leer19.Close();
            _Conexion.Close();

            #endregion

            #region "Validación Bitácora Sucesos o Transacciones(Modulo 20)"
            //SqlConnection _Conexion20 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql20 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 20 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando20 = new SqlCommand(CadenaSql20, _Conexion);
            _Conexion.Open();
            SqlDataReader leer20 = comando20.ExecuteReader();
            int resultado20 = 0;
            if (leer20.Read() == true) { resultado20 = leer20.GetInt32(0);/*devuelve algo*/}

            if (resultado20 > 0) /*Si tiene persmisos haga esto*/
            {
                transaccionesToolStripMenuItem.Visible = true;
            }
            else
            {
                transaccionesToolStripMenuItem.Visible = false;
                //return;
            }
            leer20.Close();
            _Conexion.Close();

            #endregion

            #region "Validación Reportes(Modulo 21)"
            //SqlConnection _Conexion21 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");
            string CadenaSql21 = "SELECT  [CITRA].[dbo].Usuarios.Id_Usuario from [CITRA].[dbo].Permisos_x_Modulo " +
                               " INNER JOIN [CITRA].[dbo].Usuarios ON [CITRA].[dbo].Usuarios.Roles = Id_Rol " +
                               " WHERE [CITRA].[dbo].Permisos_x_Modulo.Id_Modulo = 21 and [CITRA].[dbo].Usuarios.Id_Usuario = " + lbiduser.Text;
            SqlCommand comando21 = new SqlCommand(CadenaSql21, _Conexion);
            _Conexion.Open();
            SqlDataReader leer21 = comando21.ExecuteReader();
            int resultado21 = 0;
            if (leer21.Read() == true) { resultado21 = leer21.GetInt32(0);/*devuelve algo*/}

            if (resultado21 > 0) /*Si tiene persmisos haga esto*/
            {
                reportesToolStripMenuItem.Visible = true;
            }
            else
            {
                reportesToolStripMenuItem.Visible = false;
                //return;
            }
            leer20.Close();
            _Conexion.Close();

            #endregion




        }
        private void controlDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void alianzaInamuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Alianza_Inamu Frm_add = new F_Alianza_Inamu(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void cámarasPrivadasToolStripMenuItem_Click(object sender, EventArgs e)//Alianza Sinirube
        {
            F_Alianza_Sinirube Frm_add = new F_Alianza_Sinirube(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void oBFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Alianza_Obf Frm_add = new F_Alianza_Obf(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void oDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Alianza_Ods Frm_add = new F_Alianza_Ods(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void cámarasPrivadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Camaras_Privadas Frm_add = new F_Camaras_Privadas(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void cículosSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Circulos_Sociales Frm_add = new F_Circulos_Sociales(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void rblacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Rblac Frm_add = new F_Rblac(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void regionalONUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Regional_Onu Frm_add = new F_Regional_Onu(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void sociosEstratégicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Socios_Estrategicos Frm_add = new F_Socios_Estrategicos(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void entradasYSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora_Sucesos Frm_add = new Bitacora_Sucesos();
            Frm_add.ShowDialog(this);
        }

        public void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Cargos Frm_add = new F_Cargos(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }
     

        private void DepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Departamentos Frm_add = new F_Departamentos(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Organizaciones Frm_add = new F_Organizaciones(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void paísesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Paises Frm_add = new F_Paises(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Acceso_Manual_Usuario Frm_add = new F_Acceso_Manual_Usuario();
            Frm_add.ShowDialog(this);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Acerca_De Frm_add = new F_Acerca_De();
            Frm_add.ShowDialog(this);
        }

        private void sectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Sectores Frm_add = new F_Sectores(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);

        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            F_Usuarios Frm_add = new F_Usuarios(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void rolesDeUsuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            F_Roles Frm_add = new F_Roles(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void permisosPorRolesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            F_PermisosxRol Frm_add = new F_PermisosxRol(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void círculosSocialesToolStripMenuItem_Click(object sender, EventArgs e)//reporte
        {
            RCirculos_Sociales Frm_add = new RCirculos_Sociales();
            Frm_add.ShowDialog(this);
        }

        private void sociosEstratégicosToolStripMenuItem1_Click(object sender, EventArgs e)//reporte
        {
            RSocios_Estrategicos Frm_add = new RSocios_Estrategicos();
            Frm_add.ShowDialog(this);
        }

        private void alianzaODSToolStripMenuItem_Click(object sender, EventArgs e)//reporte
        {
            RAlianza_Ods Frm_add = new RAlianza_Ods();
            Frm_add.ShowDialog(this);
        }

        private void permisosPorMóduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PermisosxModulo Frm_add = new F_PermisosxModulo(Convert.ToInt32(lbiduser.Text), Convert.ToInt32(lbidrol.Text), lb_usuario.Text);
            Frm_add.ShowDialog(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
