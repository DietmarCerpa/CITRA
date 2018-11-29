using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Onus
    {
        public Int32 Insertar(Onu Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Onus IControlador;

            try
            {
                IControlador = new Acceso_Datos.Onus();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Onu Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Onus IControlador;

            try
            {
                IControlador = new Acceso_Datos.Onus();
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
            Acceso_Datos.Onus IControlador;
            try
            {
                IControlador = new Acceso_Datos.Onus();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Onu Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Onus IControlador;

            try
            {
                IControlador = new Acceso_Datos.Onus();
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
            Acceso_Datos.Onus IControlador;

            try
            {
                IControlador = new Acceso_Datos.Onus();
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
            Acceso_Datos.Onus IControlador;
            try
            {
                IControlador = new Acceso_Datos.Onus();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Onu LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Onus IControlador;
            try
            {
                IControlador = new Acceso_Datos.Onus();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }



    }
}
