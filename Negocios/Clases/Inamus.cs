using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Inamus
    {
  
    
        public Int32 Insertar(Inamu Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Inamus IControlador;

            try
            {
                IControlador = new Acceso_Datos.Inamus();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Inamu Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Inamus IControlador;

            try
            {
                IControlador = new Acceso_Datos.Inamus();
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
            Acceso_Datos.Inamus IControlador;
            try
            {
                IControlador = new Acceso_Datos.Inamus();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Inamu Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Inamus IControlador;

            try
            {
                IControlador = new Acceso_Datos.Inamus();
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
            Acceso_Datos.Inamus IControlador;

            try
            {
                IControlador = new Acceso_Datos.Inamus();
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
            Acceso_Datos.Inamus IControlador;
            try
            {
                IControlador = new Acceso_Datos.Inamus();
                return IControlador.LeerCodigoLlave(pCodigoL);//leercodigo
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Inamu LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Inamus IControlador;
            try
            {
                IControlador = new Acceso_Datos.Inamus();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
