using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_mantenimiento : Form
    {
        public Frm_mantenimiento()
        {
            InitializeComponent();
        }

        string vtitulo;
        string vDescripcion;
        bool mMostrarIngresar = true;
        bool mMostrarActualizar = true;
        bool mMostrarEliminar = true;
        bool mMostrarConsultar = true;

        public ISynchronizeInvoke EventSyncInvoke { get; set; }
        public event EventHandler Evento_Aceptar;
        public event EventHandler Evento_Salir;


        #region "Declaración de Propiedades"

        public string titulo
        {
            get { return vtitulo; }
            set
            {
                vtitulo = value;
                this.lbltitulo.Text = value;
                this.Text = value;
            }
        }

        public string Descripcion
        {
            get { return vDescripcion; }
            set
            {
                vDescripcion = value;
                this.lbldescripcion.Text = value;
                this.Text = value;
            }
        }

        #endregion
        private void RaiseTestEventoAceptar(EventArgs e, EventHandler pEvento)
        {
            try
            {
                //EventHandler EjecutarEvento = this.Evento_Aceptar;
                EventHandler EjecutarEvento = pEvento;

                if (EjecutarEvento == null)
                    return;

                if (EventSyncInvoke == null)
                    EjecutarEvento(this, e);
                else
                    EventSyncInvoke.Invoke(EjecutarEvento, new object[] { this, e });
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void RaiseTestEventoSalir(EventArgs e)
        {
            try
            {
                EventHandler testEvent = this.Evento_Salir;

                // Check for no subscribers
                if (testEvent == null)
                    return;

                if (EventSyncInvoke == null)
                    testEvent(this, e);
                else
                    EventSyncInvoke.Invoke(testEvent, new object[] { this, e });
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Aceptar()
        {
            try
            {
                RaiseTestEventoAceptar(EventArgs.Empty, this.Evento_Aceptar);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Salir()
        {
            try
            {
                RaiseTestEventoAceptar(EventArgs.Empty, this.Evento_Salir);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Name)
                {
                    case "btn_aceptar":
                    case "btn_actualizar":
                        Aceptar();
                        break;
                    case "btn_eliminar":
                    //if (MessageBox.Show("El registro seleccionado va a ser eliminado.  ¿Desea Continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        //{
                            Aceptar();
                        //}
                        break;
                    case "btn_salir":
                    case "btn_consultar":
                        Salir();
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region "propiedades"
        public bool MostrarIngresar
        {

            get { return mMostrarIngresar; }
            set
            {
                mMostrarIngresar = value;
                this.btn_aceptar.Visible = value;
            }
        }

        public bool MostrarEliminar
        {
            get { return mMostrarEliminar; }
            set
            {
                mMostrarEliminar = value;
                this.btn_eliminar.Visible = value;
            }
        }

        public bool MostrarConsultar
        {
            get { return mMostrarConsultar; }
            set
            {
                mMostrarConsultar = value;
                this.btn_consultar.Visible = value;
            }
        }

        public bool MostrarActualizar
        {
            get { return mMostrarActualizar; }
            set
            {
                mMostrarActualizar = value;
                this.btn_actualizar.Visible = value;
            }
        }

        #endregion




        private void Frm_mantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
