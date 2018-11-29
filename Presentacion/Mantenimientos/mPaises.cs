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
    public partial class mPaises : Frm_mantenimiento
    {
        public mPaises()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        Países IPaises;
        Pais VPais;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Pais { get; set; }

        #endregion

        private void mPaises_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Muestra campo sugerido"
                dgv.DataSource = sql.CSPais();
                #endregion

                IPaises = new Países();

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

        private void mPaises_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Txt_Id_Pais.Text == "")
            {
                MessageBox.Show("El campo Id País no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Pais.Text == "")
            {
                MessageBox.Show("El campo Nombre País no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            VPais = new Pais();

            try
            {
                VPais.Id_Pais = Convert.ToInt32(this.Txt_Id_Pais.Text);
                VPais.Nombre_Pais = this.Txt_Nombre_Pais.Text;


                switch (Modo)
                {
                    case "A":
                        #region "Valida campos repetidos en BD"
                        SqlConnection _Conexion = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");

                        string CadenaSql = "SELECT Id_Pais,Nombre_Pais from Paises where Id_Pais= '" + Txt_Id_Pais.Text + "' OR Nombre_Pais = '" + Txt_Nombre_Pais.Text + "'";
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
                        IPaises.Insertar(VPais);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;
                    case "M":
                        if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            #region "Valida campos repetidos en BD"
                            SqlConnection _Conexion1 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");

                            string CadenaSql1 = "SELECT Id_Pais,Nombre_Pais from Paises where Id_Pais= '" + Txt_Id_Pais.Text + "' OR Nombre_Pais = '" + Txt_Nombre_Pais.Text + "'";
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
                            IPaises.Modificar(VPais);
                            MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();

                        }
                        break;
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IPaises.Eliminar(VPais);
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

        private void mPaises_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VPais = new Pais();

            try
            {

                VPais = IPaises.LeerCodigoLlave(Convert.ToInt32(Id_Pais));
                if (VPais != null)
                {
                    this.Txt_Id_Pais.Text = Convert.ToString(VPais.Id_Pais);
                    this.Txt_Nombre_Pais.Text = Convert.ToString(VPais.Nombre_Pais);
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
        private void Txt_Id_Pais_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Nombre_Pais_KeyPress(object sender, KeyPressEventArgs e)
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
