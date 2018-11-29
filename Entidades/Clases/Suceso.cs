using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suceso
    {
         #region "Propiedades"
        public string Tipo_Transaccion { get; set; }
        public string Tabla_Afectada { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Registro { get; set; }
        public string Nombre_Registro { get; set; }

        #endregion

         #region "Constructor"
        public Suceso()
        {
            Tipo_Transaccion = "";
            Tabla_Afectada = "";
            Id_Registro = 0;
            Nombre_Registro = "";
        }
        #endregion
    }
}
