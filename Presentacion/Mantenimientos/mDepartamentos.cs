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
    public partial class mDepartamentos : Frm_mantenimiento
    {
        public mDepartamentos()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        Departamentos IDepartamentos;
        Departamento VDepartamento;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Departamento { get; set; }
        #endregion

        private void mDepartamentos_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Muestra campo sugerido"
                dgv.DataSource = sql.CSDepartamento();
                #endregion
                IDepartamentos = new Departamentos();

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

        private void mDepartamentos_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones"

            if (this.Txt_Id_Departamento.Text == "")
            {
                MessageBox.Show("El campo Id Departamento no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Departamento.Text == "")
            {
                MessageBox.Show("El campo Nombre Departamento no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            VDepartamento = new Departamento();

            try
            {
                
                VDepartamento.Id_Departamento = Convert.ToInt32(this.Txt_Id_Departamento.Text);
                VDepartamento.Nombre_Departamento = this.Txt_Nombre_Departamento.Text;

                switch (Modo)
                {
                    case "A":
                        #region "Valida campos repetidos en BD"
                        SqlConnection _Conexion = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");

                        string CadenaSql = "SELECT Id_Departamento,Nombre_Departamento from Departamentos where Id_Departamento= '" + Txt_Id_Departamento.Text + "' OR Nombre_Departamento = '" + Txt_Nombre_Departamento.Text + "'";

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
                        IDepartamentos.Insertar(VDepartamento);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;

                    case "M":
                        if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            #region "Valida campos repetidos en BD"
                            SqlConnection _Conexion1 = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");

                            string CadenaSql1 = "SELECT Id_Departamento,Nombre_Departamento from Departamentos where Id_Departamento= '" + Txt_Id_Departamento.Text + "' OR Nombre_Departamento = '" + Txt_Nombre_Departamento.Text + "'";

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
                            IDepartamentos.Modificar(VDepartamento);
                            MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();
                        }
                        break;
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IDepartamentos.Eliminar(VDepartamento);
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

        private void mDepartamentos_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Leer()
        {
            VDepartamento = new Departamento();

            try
            {
                VDepartamento = IDepartamentos.LeerCodigoLlave(Convert.ToInt32(Id_Departamento));
                
                if (VDepartamento != null)
                {
                    this.Txt_Id_Departamento.Text = Convert.ToString(VDepartamento.Id_Departamento);
                    this.Txt_Nombre_Departamento.Text = Convert.ToString(VDepartamento.Nombre_Departamento);
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

        #region "Eventos Validaciones KeyPress" 
        private void Txt_Id_Departamento_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void Txt_Nombre_Departamento_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}
