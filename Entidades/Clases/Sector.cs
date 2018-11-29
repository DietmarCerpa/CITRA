using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sector
    {
          #region "Propiedades"
        public int Id_Sector { get; set; }
        public string Nombre_Sector { get; set; } 

        #endregion

         #region "Constructor"
        public Sector()
        {
            Id_Sector = 0;
            Nombre_Sector = "";
        }
        #endregion



    }
}
