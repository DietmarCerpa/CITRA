using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Ods
    {
        public Int32 Insertar(AOds Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Ods IControlador;

            try
            {
                IControlador = new Acceso_Datos.Ods();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(AOds Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Ods IControlador;

            try
            {
                IControlador = new Acceso_Datos.Ods();
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
            Acceso_Datos.Ods IControlador;
            try
            {
                IControlador = new Acceso_Datos.Ods();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(AOds Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Ods IControlador;

            try
            {
                IControlador = new Acceso_Datos.Ods();
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
            Acceso_Datos.Ods IControlador;

            try
            {
                IControlador = new Acceso_Datos.Ods();
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
            Acceso_Datos.Ods IControlador;
            try
            {
                IControlador = new Acceso_Datos.Ods();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public AOds LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Ods IControlador;
            try
            {
                IControlador = new Acceso_Datos.Ods();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

    }
}
