using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class mOrganizaciones : Frm_mantenimiento
    {
        SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        public mOrganizaciones()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        Organizaciones IOrganizaciones;
        Organizacion VOrganizacion;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Organizacion { get; set; }

        #endregion

        private void mOrganizaciones_Load(object sender, EventArgs e)
        {
            try
            {
                /*                #region "Muestra campo sugerido"
                                if (Modo == "A")
                                {
                                    dgv.Visible = true;
                                    dgv.DataSource = sql.CSOrganizacion();
                                }
                                #endregion*/
                dgv.Visible = false;
                IOrganizaciones = new Organizaciones();

                if (Modo != "A")
                {
                    Leer();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void mOrganizaciones_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Txt_Id_Organizacion.Text == "")
            {
                MessageBox.Show("El campo Id Organización no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Organizacion.Text == "")
            {
                MessageBox.Show("El campo Nombre Organización no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            VOrganizacion = new Organizacion();

            try
            {
                VOrganizacion.Id_Organizacion = Convert.ToInt32(this.Txt_Id_Organizacion.Text);
                VOrganizacion.Nombre_Organizacion = this.Txt_Nombre_Organizacion.Text;


                switch (Modo)
                {
                    case "A":
                        #region "Valida campos repetidos en BD"
                        string CadenaSql = "SELECT Id_Organizacion,Nombre_Organizacion from Organizaciones where Id_Organizacion= '" + Txt_Id_Organizacion.Text + "' OR Nombre_Organizacion = '" + Txt_Nombre_Organizacion.Text + "'";
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
                        IOrganizaciones.Insertar(VOrganizacion);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;
                    case "M":
                        if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                         /*   #region "Valida campos repetidos en BD"
                            string CadenaSql1 = "SELECT Id_Organizacion,Nombre_Organizacion from Organizaciones where Id_Organizacion= '" + Txt_Id_Organizacion.Text + "' OR Nombre_Organizacion = '" + Txt_Nombre_Organizacion.Text + "'";
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
                            IOrganizaciones.Modificar(VOrganizacion);
                            MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();

                        }
                        break;
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IOrganizaciones.Eliminar(VOrganizacion);
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


        private void mOrganizaciones_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VOrganizacion = new Organizacion();

            try
            {

                VOrganizacion = IOrganizaciones.LeerCodigoLlave(Convert.ToInt32(Id_Organizacion));
                if (VOrganizacion != null)
                {
                    this.Txt_Id_Organizacion.Text = Convert.ToString(VOrganizacion.Id_Organizacion);
                    this.Txt_Nombre_Organizacion.Text = Convert.ToString(VOrganizacion.Nombre_Organizacion);
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

        #region "Validaciones KeyPress"
        private void Txt_Id_Organizacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Nombre_Organizacion_KeyPress(object sender, KeyPressEventArgs e)
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
