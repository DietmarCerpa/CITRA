using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class mAlianza_Sinirube : Frm_mantenimiento
    {
        SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        public mAlianza_Sinirube()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        Sinirubes ISinirubes;
        Sinirube VSinirube;
        Organizaciones IOrganizaciones;
        Cargos ICargos;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Contacto_Sinirube { get; set; }
        #endregion

        private void mAlianza_Sinirube_Load(object sender, EventArgs e)
        {
             try
            {
                /*     #region "Muestra campo sugerido"
                     if (Modo == "A")
                     {
                         dgv.Visible = true;
                         dgv.DataSource = sql.CSSinirube();
                     }
                     #endregion*/
                dgv.Visible = false;
                ISinirubes = new Sinirubes();
                ICargos = new Cargos();
                IOrganizaciones = new Organizaciones();
                LlenarComboNombreCargo();
                LlenarComboNombreOrganizacion();

                if (Modo != "A")
                {
                    LlenarComboNombreCargo();
                    LlenarComboNombreOrganizacion();
                    Leer();
                }
            }

             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
        }

        private void mAlianza_Sinirube_Evento_Aceptar(object sender, EventArgs e)
        {
              #region "validaciones campos vacíos"

              if (this.Txt_Id_Contacto_Sinirube.Text == "")
              {
                  MessageBox.Show("El campo Id Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }

              if (this.Txt_Nombre_Contacto_Sinirube.Text == "")
              {
                  MessageBox.Show("El campo Nombre Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }

              if (this.Cbo_Nombre_Cargo.Text == "")
              {
                  MessageBox.Show("El campo Nombre Cargo no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }

              if (this.Cbo_Nombre_Organizacion.Text == "")
              {
                  MessageBox.Show("El campo Nombre Organizacion no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }

              if (this.Txt_Correo_Sinirube.Text == "")
              {
                  MessageBox.Show("El campo Correo Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }


              #endregion

              VSinirube = new Sinirube();

              try
              {
                  VSinirube.Id_Contacto_Sinirube = Convert.ToInt32(this.Txt_Id_Contacto_Sinirube.Text);
                  VSinirube.Nombre_Contacto_Sinirube = this.Txt_Nombre_Contacto_Sinirube.Text;
                  VSinirube.Nombre_Cargo = Convert.ToString(this.Cbo_Nombre_Cargo.SelectedValue);
                  VSinirube.Nombre_Organizacion = Convert.ToString(this.Cbo_Nombre_Organizacion.SelectedValue);
                  VSinirube.Correo_Sinirube = this.Txt_Correo_Sinirube.Text;

                  switch (Modo)
                  {
                      case "A":
                          #region "Valida campos repetidos en BD"
                          string CadenaSql = "SELECT Id_Contacto_Sinirube,Nombre_Contacto_Sinirube from Alianza_Sinirube where Id_Contacto_Sinirube= '" + Txt_Id_Contacto_Sinirube.Text + "' OR Nombre_Contacto_Sinirube = '" + Txt_Nombre_Contacto_Sinirube.Text + "'";
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
                          ISinirubes.Insertar(VSinirube);
                          MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                          Limpiar(this);
                          this.Close();
                          break;
                      case "M":
                          if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                          {
                     /*         #region "Valida campos repetidos en BD"
                              string CadenaSql1 = "SELECT Id_Contacto_Sinirube,Nombre_Contacto_Sinirube from Alianza_Sinirube where Id_Contacto_Sinirube= '" + Txt_Id_Contacto_Sinirube.Text + "' OR Nombre_Contacto_Sinirube = '" + Txt_Nombre_Contacto_Sinirube.Text + "'";
                              SqlCommand comando1 = new SqlCommand(CadenaSql1, _Conexion);
                              _Conexion.Open();
                              SqlDataReader leer1 = comando1.ExecuteReader();
                              if (leer1.Read() == true)
                              {
                                  MessageBox.Show("El dato ya existe, Favor ingresar datos de nuevo", "Validación de Datos", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
                                _Conexion.Close();
                                return;
                              }
                              _Conexion.Close();

                              #endregion*/
                              ISinirubes.Modificar(VSinirube);
                              MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                              Limpiar(this);
                              this.Close();

                          }
                          break;
                      case "E":
                          if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                          {
                              ISinirubes.Eliminar(VSinirube);
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

        private void mAlianza_Sinirube_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VSinirube = new Sinirube();

            try
            {
                VSinirube = ISinirubes.LeerCodigoLlave(Convert.ToInt32(Id_Contacto_Sinirube));

                if (VSinirube != null)
                {
                    this.Txt_Id_Contacto_Sinirube.Text = Convert.ToString(VSinirube.Id_Contacto_Sinirube);
                    this.Txt_Nombre_Contacto_Sinirube.Text = VSinirube.Nombre_Contacto_Sinirube;
                    this.Cbo_Nombre_Cargo.SelectedValue = VSinirube.Nombre_Cargo;
                    this.Cbo_Nombre_Organizacion.SelectedValue = VSinirube.Nombre_Organizacion;
                    this.Txt_Correo_Sinirube.Text = VSinirube.Correo_Sinirube;
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

        private void LlenarComboNombreCargo()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = ICargos.LlenarLista();

                this.Cbo_Nombre_Cargo.DataSource = dt;
                this.Cbo_Nombre_Cargo.DisplayMember = "Cargo";
                this.Cbo_Nombre_Cargo.ValueMember = "Cargo";
                //SelectedValue
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void LlenarComboNombreOrganizacion()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = IOrganizaciones.LlenarLista();

                this.Cbo_Nombre_Organizacion.DataSource = dt;
                this.Cbo_Nombre_Organizacion.DisplayMember = "Organización";
                this.Cbo_Nombre_Organizacion.ValueMember = "Organización";

            }
            catch (Exception)
            {

                throw;
            }

        }

        #region "Validaciones KeyPress"
        private void Txt_Id_Contacto_Sinirube_KeyPress(object sender, KeyPressEventArgs e)
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


        private void Txt_Nombre_Contacto_Sinirube_KeyPress(object sender, KeyPressEventArgs e)
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

        #endregion


    }
}
