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
    public partial class mAlianza_Obf : Frm_mantenimiento
    {
        public mAlianza_Obf()
        {
            InitializeComponent();
        }

         #region "Declaracion de Variables"
        Obf IObf;
        AObf VObf;
        Organizaciones IOrganizaciones;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Contacto_Obf { get; set; }
        #endregion

        private void mAlianza_Obf_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Muestra campo sugerido"
                dgv.DataSource = sql.CSObf();
                #endregion

                IObf = new Obf();
                IOrganizaciones = new Organizaciones();
                
                LlenarComboNombreOrganizacion();

                if (Modo != "A")
                {
                    LlenarComboNombreOrganizacion();
                    Leer();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mAlianza_Obf_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Txt_Id_Contacto_Obf.Text == "")
            {
                MessageBox.Show("El campo Id Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Contacto.Text == "")
            {
                MessageBox.Show("El campo Nombre Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Cbo_Nombre_Organizacion.Text == "")
            {
                MessageBox.Show("El campo Nombre Organización no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Correo_Obf.Text == "")
            {
                MessageBox.Show("El campo Correo Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Telefono_Obf.Text == "")
            {
                MessageBox.Show("El campo Teléfono no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Telefono2.Text == "")
            {
                MessageBox.Show("El campo Teléfono 2 no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            VObf = new AObf();

            try
            {
                VObf.Id_Contacto_Obf = Convert.ToInt32(this.Txt_Id_Contacto_Obf.Text);
                VObf.Nombre_Organizacion = Convert.ToString(this.Cbo_Nombre_Organizacion.SelectedValue);
                VObf.Nombre_Contacto = this.Txt_Nombre_Contacto.Text;
                VObf.Correo_Obf = this.Txt_Correo_Obf.Text;
                VObf.Telefono_Obf = Convert.ToString(this.Txt_Telefono_Obf.Text);
                VObf.Telefono2 = Convert.ToString(this.Txt_Telefono2.Text);

                switch (Modo)
                {
                    case "A":
                        #region "Valida campos repetidos en BD"
                        SqlConnection _Conexion = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");
                        string CadenaSql = "SELECT Id_Contacto_Obf,Nombre_Contacto from Alianza_Obf where Id_Contacto_Obf= '" + Txt_Id_Contacto_Obf.Text + "' OR Nombre_Contacto = '" + Txt_Nombre_Contacto.Text + "'";
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
                        IObf.Insertar(VObf);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;
                    case "M":
                        if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            #region "Valida campos repetidos en BD"
                            SqlConnection _Conexion1 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");
                            string CadenaSql1 = "SELECT Id_Contacto_Obf,Nombre_Contacto from Alianza_Obf where Id_Contacto_Obf= '" + Txt_Id_Contacto_Obf.Text + "' OR Nombre_Contacto = '" + Txt_Nombre_Contacto.Text + "'";
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
                            IObf.Modificar(VObf);
                            MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();

                        }
                        break;
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IObf.Eliminar(VObf);
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

        private void mAlianza_Obf_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VObf = new AObf();

            try
            {
                VObf = IObf.LeerCodigoLlave(Convert.ToInt32(Id_Contacto_Obf));

                if (VObf != null)
                {
                    this.Txt_Id_Contacto_Obf.Text = Convert.ToString(VObf.Id_Contacto_Obf);
                    this.Cbo_Nombre_Organizacion.SelectedValue = VObf.Nombre_Organizacion;
                    this.Txt_Nombre_Contacto.Text = VObf.Nombre_Contacto;
                    this.Txt_Correo_Obf.Text = VObf.Correo_Obf;
                    this.Txt_Telefono_Obf.Text = VObf.Telefono_Obf;
                    this.Txt_Telefono2.Text = VObf.Telefono2;
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

        private void Txt_Id_Contacto_Obf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Nombre_Contacto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Telefono_Obf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Telefono2_KeyPress(object sender, KeyPressEventArgs e)
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
