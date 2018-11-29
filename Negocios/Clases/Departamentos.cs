using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Departamentos
    {
        public Int32 Insertar(Departamento Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Departamentos IControlador;

            try
            {
                IControlador = new Acceso_Datos.Departamentos();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Departamento Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Departamentos IControlador;

            try
            {
                IControlador = new Acceso_Datos.Departamentos();
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
            Acceso_Datos.Departamentos IControlador;
            try
            {
                IControlador = new Acceso_Datos.Departamentos();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Departamento Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Departamentos IControlador;

            try
            {
                IControlador = new Acceso_Datos.Departamentos();
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
            Acceso_Datos.Departamentos IControlador;

            try
            {
                IControlador = new Acceso_Datos.Departamentos();
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
            Acceso_Datos.Departamentos IControlador;
            try
            {
                IControlador = new Acceso_Datos.Departamentos();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Departamento LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Departamentos IControlador;
            try
            {
                IControlador = new Acceso_Datos.Departamentos();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


    }
}
