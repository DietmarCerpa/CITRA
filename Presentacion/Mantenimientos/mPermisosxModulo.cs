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
    public partial class mPermisosxModulo : Frm_mantenimiento
    {
        public mPermisosxModulo()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        PermisosxModulos IPermisosxModulos;
        PermisoxModulo VPermisoxModulo;
        Roles IRoles;
        Modulos IModulos;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int id_Rol { get; set; }
        #endregion

        private void mPermisosxModulo_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Muestra campo sugerido"
                dgv.DataSource = sql.MostrarDatosModulos();
                #endregion

                IPermisosxModulos = new PermisosxModulos();
                IRoles = new Roles();
                IModulos = new Modulos();
                LlenarComboIdRol();
                LlenarComboIdModulo();

                if (Modo != "A")
                {
                    LlenarComboIdRol();
                    LlenarComboIdModulo();
                    Leer();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void mPermisosxModulo_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Cbo_Id_Rol.Text == "")
            {
                MessageBox.Show("El campo Id Rol no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Cbo_Id_Modulo.Text == "")
            {
                MessageBox.Show("El campo Id Modulo no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            VPermisoxModulo = new PermisoxModulo();

            try
            {
                VPermisoxModulo.id_Rol = Convert.ToInt32(this.Cbo_Id_Rol.SelectedValue);
                VPermisoxModulo.id_Modulo = Convert.ToInt32(this.Cbo_Id_Modulo.SelectedValue);

                switch (Modo)
                {
                    case "A":
                        #region "Valida campos repetidos en BD"
                        SqlConnection _Conexion = new SqlConnection(@"Data Source=DESKTOP-C5D2V8H; Initial Catalog= CITRA; Integrated Security= true");
                        string CadenaSql = "SELECT id_Rol,id_Modulo from Permisos_x_Modulo where id_Rol= '" + Cbo_Id_Rol.Text + "' AND id_Modulo = '" + Cbo_Id_Modulo.Text + "'";
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
                        IPermisosxModulos.Insertar(VPermisoxModulo);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;
                    /*case "M": 
                        if (MessageBox.Show("Esta seguro que desea actualizar los datos seleccionados", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IPermisosxModulos.Modificar(VPermisoxModulo);
                            MessageBox.Show("Datos actualizados satisfactoriamente");
                            Limpiar(this);
                            this.Close();

                        }
                        break;*/
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IPermisosxModulos.Eliminar(VPermisoxModulo);
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

        private void mPermisosxModulo_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VPermisoxModulo = new PermisoxModulo();

            try
            {
                VPermisoxModulo = IPermisosxModulos.LeerCodigoLlave(Convert.ToInt32(id_Rol));

                if (VPermisoxModulo != null)
                {
                    this.Cbo_Id_Rol.SelectedValue = VPermisoxModulo.id_Rol;
                    this.Cbo_Id_Modulo.SelectedValue = VPermisoxModulo.id_Modulo;

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

                this.Cbo_Id_Rol.DataSource = dt;
                this.Cbo_Id_Rol.DisplayMember = "Id";
                this.Cbo_Id_Rol.ValueMember = "Id";
                //SelectedValue
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void LlenarComboIdModulo()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = IModulos.LlenarLista();

                this.Cbo_Id_Modulo.DataSource = dt;
                this.Cbo_Id_Modulo.DisplayMember = "Id";
                this.Cbo_Id_Modulo.ValueMember = "Id";

            }
            catch (Exception)
            {

                throw;
            }

        }





    }
}
