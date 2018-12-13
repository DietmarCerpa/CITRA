using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class mCirculos_Sociales : Frm_mantenimiento
    {
        SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        public mCirculos_Sociales()
        {
            InitializeComponent();
        }
        #region "Declaracion de Variables"
        Circulos_Sociales ICirculos_Sociales;
        Circulo_Social VCirculo_Social;
        Organizaciones IOrganizaciones;
        Departamentos IDepartamentos;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Circulo { get; set; }
        #endregion

        private void mCirculos_Sociales_Load(object sender, EventArgs e)
        {
            try
            {
                /*     #region "Muestra campo sugerido"
                     if (Modo == "A")
                     {
                         dgv.Visible = true;
                         dgv.DataSource = sql.CSCirculo();
                     }
                     #endregion*/
                dgv.Visible = false;
                ICirculos_Sociales = new Circulos_Sociales();
                IDepartamentos = new Departamentos();
                IOrganizaciones = new Organizaciones();
                LlenarComboNombreDepartamento();
                LlenarComboNombreOrganizacion();

                if (Modo != "A")
                {
                    LlenarComboNombreDepartamento();
                    LlenarComboNombreOrganizacion();
                    Leer();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void mCirculos_Sociales_Evento_Aceptar(object sender, EventArgs e)
        {
              #region "validaciones campos vacíos"

              if (this.Txt_Id_Circulo.Text == "")
              {
                  MessageBox.Show("El campo Id Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }

              if (this.Txt_Nombre_Circulo.Text == "")
              {
                  MessageBox.Show("El campo Nombre Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }

              if (this.Cbo_Nombre_Departamento.Text == "")
              {
                  MessageBox.Show("El campo Nombre Departamento no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }

              if (this.Cbo_Nombre_Organizacion.Text == "")
              {
                  MessageBox.Show("El campo Nombre Organizacion no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }

              if (this.Txt_Correo_Circulo.Text == "")
              {
                  MessageBox.Show("El campo Correo Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
              }


              #endregion

              VCirculo_Social = new Circulo_Social();

              try
              {
                  VCirculo_Social.Id_Circulo = Convert.ToInt32(this.Txt_Id_Circulo.Text);
                  VCirculo_Social.Nombre_Circulo = this.Txt_Nombre_Circulo.Text;
                  VCirculo_Social.Nombre_Organizacion = Convert.ToString(this.Cbo_Nombre_Organizacion.SelectedValue);
                  VCirculo_Social.Nombre_Departamento = Convert.ToString(this.Cbo_Nombre_Departamento.SelectedValue);
                  VCirculo_Social.Correo_Circulo = this.Txt_Correo_Circulo.Text;

                  switch (Modo)
                  {
                      case "A":
                          #region "Valida campos repetidos en BD"
                          string CadenaSql = "SELECT Id_Circulo,Nombre_Circulo from Circulos_Sociales where Id_Circulo= '" + Txt_Id_Circulo.Text + "' OR Nombre_Circulo = '" + Txt_Nombre_Circulo.Text + "'";
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
                          ICirculos_Sociales.Insertar(VCirculo_Social);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                          Limpiar(this);
                          this.Close();
                          break;
                      case "M":
                          if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                          {
                      /*        #region "Valida campos repetidos en BD"
                              string CadenaSql1 = "SELECT Id_Circulo,Nombre_Circulo from Circulos_Sociales where Id_Circulo= '" + Txt_Id_Circulo.Text + "' OR Nombre_Circulo = '" + Txt_Nombre_Circulo.Text + "'";
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
                              ICirculos_Sociales.Modificar(VCirculo_Social);
                              MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                              Limpiar(this);
                              this.Close();

                          }
                          break;
                      case "E":
                          if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                          {
                              ICirculos_Sociales.Eliminar(VCirculo_Social);
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

        private void mCirculos_Sociales_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VCirculo_Social = new Circulo_Social();

            try
            {
                VCirculo_Social = ICirculos_Sociales.LeerCodigoLlave(Convert.ToInt32(Id_Circulo));

                if (VCirculo_Social != null)
                {
                    this.Txt_Id_Circulo.Text = Convert.ToString(VCirculo_Social.Id_Circulo);
                    this.Txt_Nombre_Circulo.Text = VCirculo_Social.Nombre_Circulo;
                    this.Cbo_Nombre_Organizacion.SelectedValue = VCirculo_Social.Nombre_Organizacion;
                    this.Cbo_Nombre_Departamento.SelectedValue = VCirculo_Social.Nombre_Departamento;
                    this.Txt_Correo_Circulo.Text = VCirculo_Social.Correo_Circulo;
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

        private void LlenarComboNombreDepartamento()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = IDepartamentos.LlenarLista();

                this.Cbo_Nombre_Departamento.DataSource = dt;
                this.Cbo_Nombre_Departamento.DisplayMember = "Departamento";
                this.Cbo_Nombre_Departamento.ValueMember = "Departamento";
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
        private void Txt_Id_Circulo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Nombre_Circulo_KeyPress(object sender, KeyPressEventArgs e)
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
