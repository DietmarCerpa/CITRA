using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_Lista_Base : Form
    {
        public Frm_Lista_Base()
        {
            InitializeComponent();
        }

        #region "Declaración de Variables"

        string vtitulo;
        string vDescripcion;
      

        public ISynchronizeInvoke EventSyncInvoke { get; set; }
        public event EventHandler Evento_Ingresar;
        public event EventHandler Evento_Actualizar;
        public event EventHandler Evento_Eliminar;
        public event EventHandler Evento_Consultar;
        public event EventHandler Evento_Salir;

        #endregion

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

        #region "Declaración de Eventos"

        private void RaiseTestEvento(EventArgs e, EventHandler pEvento)
        {
            try
            {
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

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Name)
                {
                    case "btn_ingresar":
                        Ingresar();
                        break;
                    case "btn_actualizar":
                        Actualizar();
                        break;
                    case "btn_consultar":
                        Consultar();
                        break;
                    case "btn_eliminar":
                        Eliminar();
                        break;
                    case "btn_salir":
                        Salir();
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }




        #endregion


        #region "Declaración de Métodos"

        public void Ingresar()
        {
            try
            {
                RaiseTestEvento(EventArgs.Empty, this.Evento_Ingresar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Actualizar()
        {
            try
            {
                RaiseTestEvento(EventArgs.Empty, this.Evento_Actualizar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Eliminar()
        {
            try
            {
                RaiseTestEvento(EventArgs.Empty, this.Evento_Eliminar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Consultar()
        {
            try
            {
                RaiseTestEvento(EventArgs.Empty, this.Evento_Consultar);
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
                RaiseTestEvento(EventArgs.Empty, this.Evento_Salir);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

       

    }
}
