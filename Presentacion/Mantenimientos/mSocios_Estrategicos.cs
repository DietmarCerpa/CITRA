using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using Negocios;


namespace Presentacion
{
    public partial class mSocios_Estrategicos : Frm_mantenimiento
    {
        SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        public mSocios_Estrategicos()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        Socios_Estrategicos ISocios_Estrategicos;
        Socio_Estrategico VSocio_Estrategico;
        Organizaciones IOrganizaciones;
        Cargos ICargos;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Socio { get; set; }
        #endregion

        private void mSocios_Estrategicos_Load(object sender, EventArgs e)
        {
            try
            {
                /*   #region "Muestra campo sugerido"
                   if (Modo == "A")
                   {
                       dgv.Visible = true;
                       dgv.DataSource = sql.CSSocio();
                   }
                   #endregion*/
                dgv.Visible = false;
                ISocios_Estrategicos = new Socios_Estrategicos();
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


        private void mSocios_Estrategicos_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Txt_Id_Socio.Text == "")
            {
                MessageBox.Show("El campo Id Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Socio.Text == "")
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

            if (this.Txt_Correo_Socio.Text == "")
            {
                MessageBox.Show("El campo Correo Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            #endregion

            VSocio_Estrategico = new Socio_Estrategico();

            try
            {
                VSocio_Estrategico.Id_Socio = Convert.ToInt32(this.Txt_Id_Socio.Text);
                VSocio_Estrategico.Nombre_Socio = this.Txt_Nombre_Socio.Text;
                VSocio_Estrategico.Nombre_Cargo = Convert.ToString(this.Cbo_Nombre_Cargo.SelectedValue);
                VSocio_Estrategico.Nombre_Organizacion = Convert.ToString(this.Cbo_Nombre_Organizacion.SelectedValue);
                VSocio_Estrategico.Correo_Socio = this.Txt_Correo_Socio.Text;

                switch (Modo)
                {
                    case "A":
                        #region "Valida campos repetidos en BD"
                        string CadenaSql = "SELECT Id_Socio,Nombre_Socio from Socios_Estrategicos where Id_Socio= '" + Txt_Id_Socio.Text + "' OR Nombre_Socio = '" + Txt_Nombre_Socio.Text + "'";
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
                        ISocios_Estrategicos.Insertar(VSocio_Estrategico);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;
                    case "M":
                        if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                        /*    #region "Valida campos repetidos en BD"
                            string CadenaSql1 = "SELECT Id_Socio,Nombre_Socio from Socios_Estrategicos where Id_Socio= '" + Txt_Id_Socio.Text + "' OR Nombre_Socio = '" + Txt_Nombre_Socio.Text + "'";
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
                            ISocios_Estrategicos.Modificar(VSocio_Estrategico);
                            MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();

                        }
                        break;
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ISocios_Estrategicos.Eliminar(VSocio_Estrategico);
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

        private void mSocios_Estrategicos_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VSocio_Estrategico = new Socio_Estrategico();

            try
            {
                VSocio_Estrategico = ISocios_Estrategicos.LeerCodigoLlave(Convert.ToInt32(Id_Socio));

                if (VSocio_Estrategico != null)
                {
                    this.Txt_Id_Socio.Text = Convert.ToString(VSocio_Estrategico.Id_Socio);
                    this.Txt_Nombre_Socio.Text = VSocio_Estrategico.Nombre_Socio;
                    this.Cbo_Nombre_Cargo.SelectedValue = VSocio_Estrategico.Nombre_Cargo;
                    this.Cbo_Nombre_Organizacion.SelectedValue = VSocio_Estrategico.Nombre_Organizacion;
                    this.Txt_Correo_Socio.Text = VSocio_Estrategico.Correo_Socio;
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

        private void Txt_Id_Socio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Nombre_Socio_KeyPress(object sender, KeyPressEventArgs e)
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
