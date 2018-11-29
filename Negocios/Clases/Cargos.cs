using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Cargos
    {

        public Int32 Insertar(Cargo Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Cargos IControlador;

            try
            {
                IControlador = new Acceso_Datos.Cargos();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Cargo Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Cargos IControlador;

            try
            {
                IControlador = new Acceso_Datos.Cargos();
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
            Acceso_Datos.Cargos IControlador;
            try
            {
                IControlador = new Acceso_Datos.Cargos();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Cargo Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Cargos IControlador;

            try
            {
                IControlador = new Acceso_Datos.Cargos();
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
            Acceso_Datos.Cargos IControlador;

            try
            {
                IControlador = new Acceso_Datos.Cargos();
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
            Acceso_Datos.Cargos IControlador;
            try
            {
                IControlador = new Acceso_Datos.Cargos();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Cargo LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Cargos IControlador;
            try
            {
                IControlador = new Acceso_Datos.Cargos();
                return IControlador.LeerBuscar(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
