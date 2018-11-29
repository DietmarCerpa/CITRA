using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Camaras_Privadas
    {
       public Int32 Insertar(Camara_Privada Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Camaras_Privadas IControlador;

            try
            {
                IControlador = new Acceso_Datos.Camaras_Privadas();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Camara_Privada Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Camaras_Privadas IControlador;

            try
            {
                IControlador = new Acceso_Datos.Camaras_Privadas();
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
            Acceso_Datos.Camaras_Privadas IControlador;
            try
            {
                IControlador = new Acceso_Datos.Camaras_Privadas();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Camara_Privada Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Camaras_Privadas IControlador;

            try
            {
                IControlador = new Acceso_Datos.Camaras_Privadas();
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
            Acceso_Datos.Camaras_Privadas IControlador;

            try
            {
                IControlador = new Acceso_Datos.Camaras_Privadas();
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
            Acceso_Datos.Camaras_Privadas IControlador;
            try
            {
                IControlador = new Acceso_Datos.Camaras_Privadas();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Camara_Privada LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Camaras_Privadas IControlador;
            try
            {
                IControlador = new Acceso_Datos.Camaras_Privadas();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        
    }
}
