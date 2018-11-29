using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Países
    {
        public Int32 Insertar(Pais Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Países IControlador;

            try
            {
                IControlador = new Acceso_Datos.Países();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Pais Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Países IControlador;

            try
            {
                IControlador = new Acceso_Datos.Países();
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
            Acceso_Datos.Países IControlador;
            try
            {
                IControlador = new Acceso_Datos.Países();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Pais Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Países IControlador;

            try
            {
                IControlador = new Acceso_Datos.Países();
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
            Acceso_Datos.Países IControlador;

            try
            {
                IControlador = new Acceso_Datos.Países();
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
            Acceso_Datos.Países IControlador;
            try
            {
                IControlador = new Acceso_Datos.Países();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Pais LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Países IControlador;
            try
            {
                IControlador = new Acceso_Datos.Países();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }





    }
}
