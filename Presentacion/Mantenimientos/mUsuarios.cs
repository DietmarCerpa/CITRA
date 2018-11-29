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
using Microsoft.VisualBasic;
using System.Globalization;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class mUsuarios : Frm_mantenimiento
    {
        public mUsuarios()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        Usuarios IUsuarios;
        Usuario VUsuario;
        Roles IRoles;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Usuario { get; set; }
        #endregion

        private void mUsuarios_Load(object sender, EventArgs e)
        {
             try
            {
                #region "Muestra campo sugerido"
                dgv.DataSource = sql.CSUsuario();
                #endregion

                IUsuarios = new Usuarios();
                IRoles = new Roles();

                LlenarComboIdRol();

                if (Modo != "A")
                {
                    Leer();
                    LlenarComboIdRol();

                }

            }

             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
        }

        private void mUsuarios_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Txt_Id_Usuario.Text == "")
            {
                MessageBox.Show("El campo Id Usuario no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Persona.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Cedula.Text == "")
            {
                MessageBox.Show("El campo Cédula no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Cbo_Rol.Text == "")
            {
                MessageBox.Show("El campo Rol no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Email.Text == "")
            {
                MessageBox.Show("El campo Correo no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Usuario.Text == "")
            {
                MessageBox.Show("El campo Usuario no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Contraseña.Text == "")
            {
                MessageBox.Show("El campo Contraseña no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }




            #endregion

            VUsuario = new Usuario();

            try
            {
                VUsuario.Id_Usuario = Convert.ToInt32(this.Txt_Id_Usuario.Text);
                VUsuario.Nombre_Persona = this.Txt_Nombre_Persona.Text;
                VUsuario.Cedula = this.Txt_Cedula.Text;
                VUsuario.Roles = Convert.ToInt32(this.Cbo_Rol.Text);
                VUsuario.Email = this.Txt_Email.Text;
                VUsuario.Nombre_Usuario = this.Txt_Usuario.Text;
                VUsuario.Contraseña = this.Txt_Contraseña.Text;

                switch (Modo)
                {
                    case "A":
                        #region "Valida campos repetidos en BD"
                        SqlConnection _Conexion = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");
                        string CadenaSql = "SELECT Id_Usuario,Nombre_Usuario,Nombre_Persona from Usuarios where Id_Usuario= '" + Txt_Id_Usuario.Text + "' OR Nombre_Usuario = '" + Txt_Usuario.Text + "'OR Nombre_Persona = '" + Txt_Nombre_Persona.Text + "'";
                        SqlCommand comando = new SqlCommand(CadenaSql, _Conexion);

                        _Conexion.Open();
                        SqlDataReader leer = comando.ExecuteReader();


                        if (leer.Read() == true)
                        {
                            MessageBox.Show("El dato ya existe, Favor ingresar datos de nuevo", "Validación de Datos", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
                            return;
                        }

                        else
                        {
                        }
                        _Conexion.Close();

                        #endregion
                        IUsuarios.Insertar(VUsuario);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;
                    case "M":
                        if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            #region "Valida campos repetidos en BD"
                            SqlConnection _Conexion1 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");
                            string CadenaSql1 = "SELECT Id_Usuario,Nombre_Persona, Nombre_Usuario from Usuarios where Id_Usuario= '" + Txt_Id_Usuario.Text + "' OR Nombre_Persona = '" + Txt_Nombre_Persona.Text + "' OR Nombre_Usuario '" + Txt_Usuario.Text ;
                            SqlCommand comando1 = new SqlCommand(CadenaSql1, _Conexion1);
                            _Conexion1.Open();
                            SqlDataReader leer1 = comando1.ExecuteReader();


                            if (leer1.Read() == true)
                            {
                                MessageBox.Show("El dato ya existe, Favor ingresar datos de nuevo", "Validación de Datos", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
                                return;
                            }

                            else
                            {
                            }
                            _Conexion1.Close();

                            #endregion
                            IUsuarios.Modificar(VUsuario);
                            MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();

                        }
                        break;
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IUsuarios.Eliminar(VUsuario);
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

        private void mUsuarios_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VUsuario = new Usuario();

            try
            {
                VUsuario = IUsuarios.LeerCodigoLlave(Convert.ToInt32(Id_Usuario));

                if (VUsuario != null)
                {
                    this.Txt_Id_Usuario.Text = Convert.ToString(VUsuario.Id_Usuario);
                    this.Txt_Nombre_Persona.Text = VUsuario.Nombre_Persona;
                    this.Txt_Cedula.Text = VUsuario.Cedula;
                    this.Cbo_Rol.SelectedValue = VUsuario.Roles;
                    this.Txt_Email.Text = VUsuario.Email;
                    this.Txt_Usuario.Text = VUsuario.Nombre_Usuario;
                    this.Txt_Contraseña.Text = VUsuario.Contraseña;
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

                 this.Cbo_Rol.DataSource = dt;
                 this.Cbo_Rol.DisplayMember = "Id";
                 this.Cbo_Rol.ValueMember = "Id";

             }
             catch (Exception)
             {

                 throw;
             }

         }

        #region "Validaciones KeyPress"

        private void Txt_Id_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txt_Nombre_Persona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion



    }
}
