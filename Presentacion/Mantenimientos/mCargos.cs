using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class mCargos : Frm_mantenimiento
    {

        SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        public mCargos()
        {
            InitializeComponent();
        }

        #region "Declaracion de Variables"
        Cargos ICargos;
        Cargo VCargo;
        ConsultasSQL sql = new ConsultasSQL();
        
        #endregion

        #region "Propiedades"
        public string Modo { get; set; }
        public int Id_Cargo { get; set; }

        #endregion

        private void mCargos_Load(object sender, EventArgs e)
        {
            try
            {
                /*   #region "Muestra campo sugerido"
                   if (Modo == "A")
                   {
                       dgv.Visible = true;
                       dgv.DataSource = sql.CSCargo();
                   }
                   #endregion*/
                dgv.Visible = false;
                ICargos = new Cargos();

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

         private void mCargos_Evento_Aceptar(object sender, EventArgs e)
        {
            #region "validaciones campos vacíos"

            if (this.Txt_Id_Cargo.Text == "")
            {
                MessageBox.Show("El campo Id Cargo no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.Txt_Nombre_Cargo.Text== "")
            {
                MessageBox.Show("El campo Nombre Cargo no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            VCargo = new Cargo();

            try
            {
                VCargo.Id_Cargo = Convert.ToInt32(this.Txt_Id_Cargo.Text); 
                VCargo.Nombre_Cargo = this.Txt_Nombre_Cargo.Text;


                 switch (Modo)
                 {
                     case "A":
                        #region "Valida campos repetidos en BD"
                        string CadenaSql = "SELECT Id_Cargo,Nombre_Cargo from Cargos where Id_Cargo= '" + Txt_Id_Cargo.Text + "' OR Nombre_Cargo = '" + Txt_Nombre_Cargo.Text + "'";
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
                            ICargos.Insertar(VCargo);
                        MessageBox.Show("Datos ingresados satisfactoriamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar(this);
                            this.Close();
                            break;
                     case "M":
                            if (MessageBox.Show("Está seguro que desea actualizar los datos seleccionados?", "Modificación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                    /*         #region "Valida campos repetidos en BD"
                             string CadenaSql1 = "SELECT Id_Cargo,Nombre_Cargo from Cargos where Id_Cargo= '" + Txt_Id_Cargo.Text + "' OR Nombre_Cargo = '" + Txt_Nombre_Cargo.Text + "'";
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
                             ICargos.Modificar(VCargo);
                             MessageBox.Show("Datos actualizados satisfactoriamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                             Limpiar(this);
                             this.Close();
                             
                         }
                         break;
                     case "E":
                         if (MessageBox.Show("Está seguro que desea eliminar los datos seleccionados?", "Eliminación de datos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                         {
                             ICargos.Eliminar(VCargo);
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

         private void mCargos_Evento_Salir(object sender, EventArgs e)
         {
             this.Close();
         }

         private void Leer()
         {
             VCargo = new Cargo();

             try
             {

                 VCargo = ICargos.LeerCodigoLlave(Convert.ToInt32(Id_Cargo));
                 if (VCargo != null)
                 {
                     this.Txt_Id_Cargo.Text = Convert.ToString(VCargo.Id_Cargo);
                     this.Txt_Nombre_Cargo.Text = Convert.ToString(VCargo.Nombre_Cargo);
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
         private void Txt_Id_Cargo_KeyPress(object sender, KeyPressEventArgs e)
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

         private void Txt_Nombre_Cargo_KeyPress(object sender, KeyPressEventArgs e)
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
