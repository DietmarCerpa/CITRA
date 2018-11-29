using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Permisos
    {

        public System.Data.DataTable LlenarLista()
        {
            Acceso_Datos.Permisos IControlador;
            try
            {
                IControlador = new Acceso_Datos.Permisos();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }    
    }
}
