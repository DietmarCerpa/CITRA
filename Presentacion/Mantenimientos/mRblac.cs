using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class mRblac : Frm_mantenimiento
    {
        SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        public mRblac()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        Rblacs IRblacs;
        Rblac VRblac;
        Cargos ICargos;
        Departamentos IDepartamentos;
        ConsultasSQL sql = new ConsultasSQL();
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Rblac { get; set; }
        #endregion

        private void mRblac_Load(object sender, EventArgs e)
        {
             try
            {
                /*    #region "Muestra campo sugerido"
                    if (Modo == "A")
                    {
                        dgv.Visible = true;
                        dgv.DataSource = sql.CSRblac();
                    }
                    #endregion*/
                dgv.Visible = false;
                IRblacs = new Rblacs();
                ICargos = new Cargos();
                IDepartamentos = new Departamentos();
               
                LlenarComboNombreCargo();
                LlenarComboNombreDepartamento();

                if (Modo != "A")
                {
                    LlenarComboNombreCargo();
                    LlenarComboNombreDepartamento();
                    Leer();
                }

            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
        }

        private void mRblac_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Txt_Id_Rblac.Text == "")
            {
                MessageBox.Show("El campo Id Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Rblac.Text == "")
            {
                MessageBox.Show("El campo Nombre Contacto no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Cbo_Nombre_Cargo.Text == "")
            {
                MessageBox.Show("El campo Nombre Cargo no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Cbo_Nombre_Departamento.Text == "")
            {
                MessageBox.Show("El campo Nombre Departamento no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Ubicacion.Text == "")
            {
                MessageBox.Show("El campo Ubicación no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Extension.Text == "")
            {
                MessageBox.Show("El campo Extensión no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            #endregion

            VRblac = new Rblac();

            try
            {
                VRblac.Id_Rblac = Convert.ToInt32(this.Txt_Id_Rblac.Text);
                VRblac.Nombre_Rblac = this.Txt_Nombre_Rblac.Text;
                VRblac.Nombre_Departamento = Convert.ToString(this.Cbo_Nombre_Departamento.SelectedValue);
                VRblac.Nombre_Cargo = Convert.ToString(this.Cbo_Nombre_Cargo.SelectedValue);
                VRblac.Ubicacion = this.Txt_Ubicacion.Text;
                VRblac.Extension = this.Txt_Extension.Text;

                switch (Modo)
                {
                    case "A":
                        #region "Valida campos repetidos en BD"
                        string CadenaSql = "SELECT Id_Rblac,Nombre_Rblac from Rblac where Id_Rblac= '" + Txt_Id_Rblac.Text + "' OR Nombre_Rblac = '" + Txt_Nombre_Rblac.Text + "'";
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
                        IRblacs.Insertar(VRblac);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar(this);
                        this.Close();
                        break;
                    case "M":
                        if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                 /*           #region "Valida campos repetidos en BD"
                            string CadenaSql1 = "SELECT Id_Rblac,Nombre_Rblac from Rblac where Id_Rblac= '" + Txt_Id_Rblac.Text + "' OR Nombre_Rblac = '" + Txt_Nombre_Rblac.Text + "'";
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
                            IRblacs.Modificar(VRblac);
                            MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();

                        }
                        break;
                    case "E":
                        if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IRblacs.Eliminar(VRblac);
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

        private void mRblac_Evento_Salir(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Leer()
        {
            VRblac = new Rblac();

            try
            {
                VRblac = IRblacs.LeerCodigoLlave(Convert.ToInt32(Id_Rblac));

                if (VRblac != null)
                {
                    this.Txt_Id_Rblac.Text = Convert.ToString(VRblac.Id_Rblac);
                    this.Txt_Nombre_Rblac.Text = VRblac.Nombre_Rblac;
                    this.Cbo_Nombre_Departamento.SelectedValue = VRblac.Nombre_Departamento;
                    this.Cbo_Nombre_Cargo.SelectedValue = VRblac.Nombre_Cargo;
                    this.Txt_Ubicacion.Text = VRblac.Ubicacion;
                    this.Txt_Extension.Text = VRblac.Extension;
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

        #region "Validaciones KeyPress"
        private void Txt_Id_Rblac_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Nombre_Rblac_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Nombre_Titulo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Ubicacion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt_Extension_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion


    }
}
