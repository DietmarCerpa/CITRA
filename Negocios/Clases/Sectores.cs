using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Sectores
    {
        public Int32 Insertar(Sector Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Sectores IControlador;

            try
            {
                IControlador = new Acceso_Datos.Sectores();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Sector Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Sectores IControlador;

            try
            {
                IControlador = new Acceso_Datos.Sectores();
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
            Acceso_Datos.Sectores IControlador;
            try
            {
                IControlador = new Acceso_Datos.Sectores();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Sector Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Sectores IControlador;

            try
            {
                IControlador = new Acceso_Datos.Sectores();
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
            Acceso_Datos.Sectores IControlador;

            try
            {
                IControlador = new Acceso_Datos.Sectores();
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
            Acceso_Datos.Sectores IControlador;
            try
            {
                IControlador = new Acceso_Datos.Sectores();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Sector LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Sectores IControlador;
            try
            {
                IControlador = new Acceso_Datos.Sectores();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
