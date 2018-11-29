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
    public partial class mRegional_Onu : Frm_mantenimiento
    {
        public mRegional_Onu()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        Onus IOnus;
        Onu VOnu;
        Países IPaises;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Contacto_Regional { get; set; }
        #endregion

        private void mRegional_Onu_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Muestra campo sugerido"
                dgv.DataSource = sql.CSOnu();
                #endregion

                IOnus = new Onus();
                IPaises = new Países();
                LlenarComboNombrePais();

                if (Modo != "A")
                {
                    LlenarComboNombrePais();
                    Leer();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void mRegional_Onu_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Txt_Contacto_Regional.Text == "")
            {
                MessageBox.Show("El campo Id Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Director.Text == "")
            {
                MessageBox.Show("El campo Nombre Director no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Cbo_Nombre_Pais.Text == "")
            {
                MessageBox.Show("El campo Nombre País no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Telefono1.Text == "")
            {
                MessageBox.Show("El campo Teléfono 1 no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Telefono2.Text == "")
            {
                MessageBox.Show("El campo Teléfono 2 no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Adr.Text == "")
            {
                MessageBox.Show("El campo ARR/DRR no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Fax.Text == "")
            {
                MessageBox.Show("El campo Fax no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Direccion.Text == "")
            {
                MessageBox.Show("El campo Dirección no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            #endregion

            VOnu = new Onu();

            try
            {
                VOnu.Id_Contacto_Regional = Convert.ToInt32(this.Txt_Contacto_Regional.Text);
                VOnu.Nombre_Pais = Convert.ToString(this.Cbo_Nombre_Pais.SelectedValue);
                VOnu.Nombre_Director = this.Txt_Nombre_Director.Text;
                VOnu.Telefono1 = this.Txt_Telefono1.Text;
                VOnu.Telefono2 = this.Txt_Telefono2.Text;
                VOnu.Adrr = this.Txt_Nombre_Adr.Text;
                VOnu.Telefono3 = this.Txt_Telefono3.Text;
                VOnu.Fax = this.Txt_Fax.Text;
                VOnu.Direccion_Director = this.Txt_Direccion.Text;

                switch (Modo)
                {
                    case "A":
                        #region "Valida campos repetidos en BD"
                        SqlConnection _Conexion = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");
                        string CadenaSql = "SELECT Id_Contacto_Regional,Nombre_Director from Regional_Onu where Id_Contacto_Regional= '" + Txt_Contacto_Regional.Text + "' OR Nombre_Director = '" + Txt_Nombre_Director.Text + "'";
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
                        IOnus.Insertar(VOnu);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;
                    case "M":
                        if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            #region "Valida campos repetidos en BD"
                            SqlConnection _Conexion1 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");
                            string CadenaSql1 = "SELECT Id_Contacto_Regional,Nombre_Director from Regional_Onu where Id_Contacto_Regional= '" + Txt_Contacto_Regional.Text + "' OR Nombre_Director = '" + Txt_Nombre_Director.Text + "'";
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
                            IOnus.Modificar(VOnu);
                            MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();

                        }
                        break;
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IOnus.Eliminar(VOnu);
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

        private void mRegional_Onu_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VOnu = new Onu();

            try
            {
                VOnu = IOnus.LeerCodigoLlave(Convert.ToInt32(Id_Contacto_Regional));

                if (VOnu != null)
                {
                    this.Txt_Contacto_Regional.Text = Convert.ToString(VOnu.Id_Contacto_Regional);
                    this.Cbo_Nombre_Pais.SelectedValue = VOnu.Nombre_Pais;
                    this.Txt_Nombre_Director.Text = VOnu.Nombre_Director;
                    this.Txt_Telefono1.Text = VOnu.Telefono1;
                    this.Txt_Telefono2.Text = VOnu.Telefono2;
                    this.Txt_Nombre_Adr.Text = VOnu.Adrr;
                    this.Txt_Telefono3.Text = VOnu.Telefono3;
                    this.Txt_Fax.Text = VOnu.Fax;
                    this.Txt_Direccion.Text = VOnu.Direccion_Director;
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

        private void LlenarComboNombrePais()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = IPaises.LlenarLista();

                this.Cbo_Nombre_Pais.DataSource = dt;
                this.Cbo_Nombre_Pais.DisplayMember = "País";
                this.Cbo_Nombre_Pais.ValueMember = "País";
                //SelectedValue
            }
            catch (Exception)
            {

                throw;
            }
            
        }

 
    }
}
