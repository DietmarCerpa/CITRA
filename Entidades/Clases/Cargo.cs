using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cargo
    {
        #region "Propiedades"
        public int Id_Cargo { get; set; }
        public string Nombre_Cargo { get; set; } 

        #endregion

         #region "Constructor"
        public Cargo()
        {
            Id_Cargo = 0;
            Nombre_Cargo = "";
        }
        #endregion
    }
}
