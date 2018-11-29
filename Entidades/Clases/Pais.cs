using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pais
    {
        #region "Propiedades"
        public int Id_Pais { get; set; }
        public string Nombre_Pais { get; set; } 

        #endregion

         #region "Constructor"
        public Pais()
        {
            Id_Pais = 0;
            Nombre_Pais = "";
        }
        #endregion
    }
}
