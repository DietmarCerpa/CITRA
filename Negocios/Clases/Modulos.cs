using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Modulos
    {
        public System.Data.DataTable LlenarLista()
        {
            Acceso_Datos.Modulos IControlador;
            try
            {
                IControlador = new Acceso_Datos.Modulos();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }    
    }
}
