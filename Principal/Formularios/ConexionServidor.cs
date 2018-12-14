using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Formularios
{
    public partial class ConexionServidor : Form
    {
        public ConexionServidor()
        {
            InitializeComponent();
        }


        private void ConexionServidor_Load(object sender, EventArgs e)
        {
            //esta linea permite que el evento FormClosing sea tomado en cuenta por el hilo de ejecucion
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ReiniciarCampos();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //permite cerrar el formulario y cerrar todo lo que este conectado a este
            MenuLogin();

        }

        private void rbtnRemoto_CheckedChanged(object sender, EventArgs e)
        {
            //si se usa el radiobutton 1 (REMOTO)
            if (rbtnRemoto.Enabled == true)
            {
                grpServidorRemoto.Enabled = true;
                grpServidorLocal.Enabled = false;
                LimpiarCamposTexto();
            }
        }

        private void rbtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            //si se usa el radiobutton 2 (LOCAL)
            if (rbtnLocal.Enabled == true)
            {
                grpServidorRemoto.Enabled = false;
                grpServidorLocal.Enabled = true;
                LimpiarCamposTexto();
            }
        }



        private void btnServidorRemoto_Click(object sender, EventArgs e)
        {
            #region "Validaciones campos vacíos"

            if (txtServidorRemoto.Text.Equals("") || txtUsuarioRemoto.Text.Equals("") || txtPassRemoto.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los datos solicitados ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #endregion "Validaciones campos vacios"

            CadenaConexion mServidor = new CadenaConexion();
            bool mResultado;
            mResultado = mServidor.guardarServidorRemoto(txtServidorRemoto.Text, txtUsuarioRemoto.Text, txtPassRemoto.Text);
            //resultado devuelve un booleano que le avisa al usuario si logro conectarse al servidor establecido y si se guardo en la cadena de conexion
            if(mResultado)
            {
                MessageBox.Show("Se ha guardado el servidor REMOTO satisfactoriamente", "Validacion de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuLogin();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error \n Verificar los datos del Servidor", "Validacion de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnServidorLocal_Click(object sender, EventArgs e)
        {
            #region "Validaciones campos vacíos"

            if (txtServidorLocal.Text.Equals(""))
            {
                MessageBox.Show("El campo Servidor no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion "Validaciones campos vacios"

            CadenaConexion mServidor = new CadenaConexion();
            bool mResultado;

            mResultado = mServidor.guardarServidorLocal(txtServidorLocal.Text);
            if (mResultado)
            {
                MessageBox.Show("Se ha guardado el servidor REMOTO satisfactoriamente", "Validacion de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuLogin();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Validacion de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

   
        }

        /// <summary>
        /// limpia los campos de texto cada vez que se use esta funcion
        /// </summary>
        private void LimpiarCamposTexto()
        {
            txtPassRemoto.Clear();
            txtServidorRemoto.Clear();
            txtUsuarioRemoto.Clear();
            txtServidorLocal.Clear();
        }


        /// <summary>
        /// permite reiniciar los valores de logica del formulario
        /// </summary>
        private void ReiniciarCampos()
        {
            grpServidorLocal.Enabled = false;
            grpServidorRemoto.Enabled = false;
            rbtnLocal.Checked = false;
            rbtnRemoto.Checked = false;
        }

        /// <summary>
        /// procedimiento para cambiar al menu de inicio de sesion
        /// </summary>
        private void MenuLogin()
        {
            this.Hide();
            Login formLogin = new Login();
            formLogin.Show();
        }

    }
}
