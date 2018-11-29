using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrada_Salida
    {
         #region "Propiedades"
        public int Id_ES { get; set; }
        public string Usuario { get; set; }

        public string Fecha { get; set; }//datetime
        public string Tipo_es { get; set; }

        #endregion

         #region "Constructor"
        public Entrada_Salida()
        {
            Id_ES = 0;
            Usuario = "";
            Fecha = "";
            Tipo_es = "";
        }
        #endregion
    }
}
