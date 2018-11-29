using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Organizacion
    {
        #region "Propiedades"
        public int Id_Organizacion { get; set; }
        public string Nombre_Organizacion { get; set; } 

        #endregion

         #region "Constructor"
        public Organizacion()
        {
            Id_Organizacion = 0;
            Nombre_Organizacion = "";
        }
        #endregion
    }
}
