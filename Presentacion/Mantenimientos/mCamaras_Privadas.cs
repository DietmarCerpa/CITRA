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
    public partial class mCamaras_Privadas : Frm_mantenimiento
    {
        public mCamaras_Privadas()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        Camaras_Privadas ICamaras_Privadas;
        Camara_Privada VCamara_Privada;
        Organizaciones IOrganizaciones;
        Cargos ICargos;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Contacto_Camara { get; set; }
        #endregion

        private void mCamaras_Privadas_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Muestra campo sugerido"
                dgv.DataSource = sql.CSCamaraPrivada();
                #endregion
                
                ICamaras_Privadas = new Camaras_Privadas();
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

        private void mCamaras_Privadas_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Txt_Id_Contacto_Camara.Text == "")
            {
                MessageBox.Show("El campo Id Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Contacto_Camara.Text == "")
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
                MessageBox.Show("El campo Nombre Organización no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Correo_Camara.Text == "")
            {
                MessageBox.Show("El campo Correo Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Telefono.Text == "")
            {
                MessageBox.Show("El campo Teléfono no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Extension.Text == "")
            {
                MessageBox.Show("El campo Extensión no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            #endregion

            VCamara_Privada = new Camara_Privada();

            try
            {
                VCamara_Privada.Id_Contacto_Camara = Convert.ToInt32(this.Txt_Id_Contacto_Camara.Text);
                VCamara_Privada.Nombre_Contacto_Camara = this.Txt_Nombre_Contacto_Camara.Text;
                VCamara_Privada.Nombre_Organizacion = Convert.ToString(this.Cbo_Nombre_Organizacion.SelectedValue); 
                VCamara_Privada.Nombre_Cargo = Convert.ToString(this.Cbo_Nombre_Cargo.SelectedValue);
                VCamara_Privada.Correo_Camara = this.Txt_Correo_Camara.Text;
                VCamara_Privada.Telefono = this.Txt_Telefono.Text;
                VCamara_Privada.Extension = this.Txt_Extension.Text;
                switch (Modo)
                {
                    case "A":

                        #region "Valida campos repetidos en BD"
                        SqlConnection _Conexion = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");
                        string CadenaSql = "SELECT Id_Contacto_Camara,Nombre_Contacto_Camara from Camaras_Privadas where Id_Contacto_Camara= '" + Txt_Id_Contacto_Camara.Text + "' OR Nombre_Contacto_Camara = '" + Txt_Nombre_Contacto_Camara.Text + "'";
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
                        ICamaras_Privadas.Insertar(VCamara_Privada);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;
                    case "M":
                        if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            #region "Valida campos repitos en BD"
                            SqlConnection _Conexion1 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");
                            string CadenaSql1 = "SELECT Id_Contacto_Camara,Nombre_Contacto_Camara from Camaras_Privadas where Id_Contacto_Camara= '" + Txt_Id_Contacto_Camara.Text + "' OR Nombre_Contacto_Camara = '" + Txt_Nombre_Contacto_Camara.Text + "'";
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
                            ICamaras_Privadas.Modificar(VCamara_Privada);
                            MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();

                        }
                        break;
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ICamaras_Privadas.Eliminar(VCamara_Privada);
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

        private void mCamaras_Privadas_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VCamara_Privada = new Camara_Privada();

            try
            {
                VCamara_Privada = ICamaras_Privadas.LeerCodigoLlave(Convert.ToInt32(Id_Contacto_Camara));

                if (VCamara_Privada != null)
                {
                    this.Txt_Id_Contacto_Camara.Text = Convert.ToString(VCamara_Privada.Id_Contacto_Camara);
                    this.Txt_Nombre_Contacto_Camara.Text = VCamara_Privada.Nombre_Contacto_Camara;
                    this.Cbo_Nombre_Organizacion.SelectedValue = VCamara_Privada.Nombre_Organizacion;
                    this.Cbo_Nombre_Cargo.SelectedValue = VCamara_Privada.Nombre_Cargo;
                    this.Txt_Correo_Camara.Text = VCamara_Privada.Correo_Camara;
                    this.Txt_Telefono.Text = VCamara_Privada.Telefono;
                    this.Txt_Extension.Text = VCamara_Privada.Extension;
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
        private void Txt_Id_Contacto_Camara_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Nombre_Contacto_Camara_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Extension_KeyPress(object sender, KeyPressEventArgs e)
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
