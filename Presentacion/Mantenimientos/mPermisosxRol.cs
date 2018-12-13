using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class mPermisosxRol : Frm_mantenimiento
    {
        SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        public mPermisosxRol()
        {
            InitializeComponent();
        }
        #region "Declaracion de Variables"
        PermisosxRoles IPermisosxRoles;
        PermisoxRol VPermisoxRol;
        Roles IRoles;
        Permisos IPermisos;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int id_Rol { get; set; }
        #endregion

        private void mPermisosxRol_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Muestra campo sugerido"
                    dgv.DataSource = sql.MostrarDatosPermisos();
                #endregion

                IPermisosxRoles = new PermisosxRoles();
                IRoles = new Roles();
                IPermisos = new Permisos();
                LlenarComboIdRol();
                LlenarComboIdPermiso();

                if (Modo != "A")
                {
                    LlenarComboIdRol();
                    LlenarComboIdPermiso();
                    Leer();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mPermisosxRol_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Cbo_Id_Rol.Text == "")
            {
                MessageBox.Show("El campo Id Rol no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Cbo_Id_Permiso.Text == "")
            {
                MessageBox.Show("El campo Id Permiso no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            VPermisoxRol = new PermisoxRol();

            try
            {
                VPermisoxRol.id_Rol = Convert.ToInt32(this.Cbo_Id_Rol.SelectedValue);
                VPermisoxRol.id_Permiso = Convert.ToInt32(this.Cbo_Id_Permiso.SelectedValue);

                switch (Modo)
                {
                    case "A":
                        #region "Valida campos repetidos en BD"
                        string CadenaSql = "SELECT id_Rol,id_Permiso from Permisos_x_Rol where id_Rol= '" + Cbo_Id_Rol.Text + "' AND id_Permiso = '" + Cbo_Id_Permiso.Text + "'";
                        SqlCommand comando = new SqlCommand(CadenaSql, _Conexion);
                        _Conexion.Open();
                        SqlDataReader leer = comando.ExecuteReader();
                        if (leer.Read() == true)
                        {
                            MessageBox.Show("El dato ya existe, Favor ingresar datos de nuevo", "Validación de Datos", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
                            _Conexion.Close();
                            return;
                        }
                        _Conexion.Close();

                        #endregion
                        IPermisosxRoles.Insertar(VPermisoxRol);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;
                    /*case "M":
                        if (MessageBox.Show("Esta seguro que desea actualizar los datos seleccionados", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IPermisosxRoles.Modificar(VPermisoxRol);
                            MessageBox.Show("Datos actualizados satisfactoriamente");
                            Limpiar(this);
                            this.Close();

                        }
                        break;*/
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IPermisosxRoles.Eliminar(VPermisoxRol);
                            MessageBox.Show("Datos eliminados satisfactoriamente", "Eliminación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();
                        }
                        break;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mPermisosxRol_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VPermisoxRol = new PermisoxRol();

            try
            {
                VPermisoxRol = IPermisosxRoles.LeerCodigoLlave(Convert.ToInt32(id_Rol));

                if (VPermisoxRol != null)
                {
                    this.Cbo_Id_Rol.SelectedValue = VPermisoxRol.id_Rol;
                    this.Cbo_Id_Permiso.SelectedValue = VPermisoxRol.id_Permiso;

                }
                else
                {
                    MessageBox.Show("No se pudieron recuperar los datos", "Recuperación de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public static void Limpiar(Form ofrm)
        {
            // Checar todos los textbox del formulario
            foreach (Control oControls in ofrm.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
            }
        }
        
        private void LlenarComboIdRol()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = IRoles.LlenarLista();

                this.Cbo_Id_Rol.DataSource = dt;
                this.Cbo_Id_Rol.DisplayMember = "Id";
                this.Cbo_Id_Rol.ValueMember = "Id";
                //SelectedValue
            }
            catch (Exception)
            {

                throw;
            }

        }
        
         private void LlenarComboIdPermiso()
         {
             DataTable dt = new DataTable();

             try
             {
                 dt = IPermisos.LlenarLista();

                 this.Cbo_Id_Permiso.DataSource = dt;
                 this.Cbo_Id_Permiso.DisplayMember = "Id";
                 this.Cbo_Id_Permiso.ValueMember = "Id";

             }
             catch (Exception)
             {

                 throw;
             }

         }



    }
}
