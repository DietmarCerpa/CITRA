using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Usuarios
    {
        public Int32 Insertar(Usuario Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Usuarios IControlador;

            try
            {
                IControlador = new Acceso_Datos.Usuarios();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Usuario Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Usuarios IControlador;

            try
            {
                IControlador = new Acceso_Datos.Usuarios();
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
            Acceso_Datos.Usuarios IControlador;
            try
            {
                IControlador = new Acceso_Datos.Usuarios();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Usuario Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Usuarios IControlador;

            try
            {
                IControlador = new Acceso_Datos.Usuarios();
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
            Acceso_Datos.Usuarios IControlador;

            try
            {
                IControlador = new Acceso_Datos.Usuarios();
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
            Acceso_Datos.Usuarios IControlador;
            try
            {
                IControlador = new Acceso_Datos.Usuarios();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Usuario LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Usuarios IControlador;
            try
            {
                IControlador = new Acceso_Datos.Usuarios();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


    }
}
