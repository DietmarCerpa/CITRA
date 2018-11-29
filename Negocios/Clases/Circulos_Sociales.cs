using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Circulos_Sociales
    {
        public Int32 Insertar(Circulo_Social Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Circulos_Sociales IControlador;

            try
            {
                IControlador = new Acceso_Datos.Circulos_Sociales();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Circulo_Social Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Circulos_Sociales IControlador;

            try
            {
                IControlador = new Acceso_Datos.Circulos_Sociales();
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
            Acceso_Datos.Circulos_Sociales IControlador;
            try
            {
                IControlador = new Acceso_Datos.Circulos_Sociales();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Circulo_Social Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Circulos_Sociales IControlador;

            try
            {
                IControlador = new Acceso_Datos.Circulos_Sociales();
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
            Acceso_Datos.Circulos_Sociales IControlador;

            try
            {
                IControlador = new Acceso_Datos.Circulos_Sociales();
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
            Acceso_Datos.Circulos_Sociales IControlador;
            try
            {
                IControlador = new Acceso_Datos.Circulos_Sociales();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Circulo_Social LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Circulos_Sociales IControlador;
            try
            {
                IControlador = new Acceso_Datos.Circulos_Sociales();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
