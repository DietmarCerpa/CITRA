using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Obf
    {
        public Int32 Insertar(AObf Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Obf IControlador;

            try
            {
                IControlador = new Acceso_Datos.Obf();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(AObf Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Obf IControlador;

            try
            {
                IControlador = new Acceso_Datos.Obf();
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
            Acceso_Datos.Obf IControlador;
            try
            {
                IControlador = new Acceso_Datos.Obf();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(AObf Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Obf IControlador;

            try
            {
                IControlador = new Acceso_Datos.Obf();
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
            Acceso_Datos.Obf IControlador;

            try
            {
                IControlador = new Acceso_Datos.Obf();
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
            Acceso_Datos.Obf IControlador;
            try
            {
                IControlador = new Acceso_Datos.Obf();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public AObf LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Obf IControlador;
            try
            {
                IControlador = new Acceso_Datos.Obf();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
