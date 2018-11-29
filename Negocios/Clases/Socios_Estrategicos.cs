using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;


namespace Negocios
{
    public class Socios_Estrategicos
    {
        public Int32 Insertar(Socio_Estrategico Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Socios_Estrategicoss IControlador;

            try
            {
                IControlador = new Acceso_Datos.Socios_Estrategicoss();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Socio_Estrategico Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Socios_Estrategicoss IControlador;

            try
            {
                IControlador = new Acceso_Datos.Socios_Estrategicoss();
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
            Acceso_Datos.Socios_Estrategicoss IControlador;
            try
            {
                IControlador = new Acceso_Datos.Socios_Estrategicoss();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Socio_Estrategico Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Socios_Estrategicoss IControlador;

            try
            {
                IControlador = new Acceso_Datos.Socios_Estrategicoss();
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
            Acceso_Datos.Socios_Estrategicoss IControlador;

            try
            {
                IControlador = new Acceso_Datos.Socios_Estrategicoss();
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
            Acceso_Datos.Socios_Estrategicoss IControlador;
            try
            {
                IControlador = new Acceso_Datos.Socios_Estrategicoss();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Socio_Estrategico LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Socios_Estrategicoss IControlador;
            try
            {
                IControlador = new Acceso_Datos.Socios_Estrategicoss();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }



    }
}
