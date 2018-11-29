using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Sinirubes
    {
        public Int32 Insertar(Sinirube Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Sinirubes IControlador;

            try
            {
                IControlador = new Acceso_Datos.Sinirubes();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Sinirube Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Sinirubes IControlador;

            try
            {
                IControlador = new Acceso_Datos.Sinirubes();
                FilasAfectadas = IControlador.Modificar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public System.Data.DataTable LlenarLista()
        {
            Acceso_Datos.Sinirubes IControlador;
            try
            {
                IControlador = new Acceso_Datos.Sinirubes();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Sinirube Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Sinirubes IControlador;

            try
            {
                IControlador = new Acceso_Datos.Sinirubes();
                FilasAfectadas = IControlador.Eliminar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Eliminar()
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Sinirubes IControlador;

            try
            {
                IControlador = new Acceso_Datos.Sinirubes();
                FilasAfectadas = IControlador.Eliminar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public System.Data.DataTable LeerCodigoLlave(string pCodigoL)
        {
            Acceso_Datos.Sinirubes IControlador;
            try
            {
                IControlador = new Acceso_Datos.Sinirubes();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Sinirube LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Sinirubes IControlador;
            try
            {
                IControlador = new Acceso_Datos.Sinirubes();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
