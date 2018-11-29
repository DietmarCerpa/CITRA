using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permiso
    {
        #region "Propiedades"
        public int id { get; set; }
        public string nombre { get; set; } 

        #endregion

         #region "Constructor"
        public Permiso()
        {
            id = 0;
            nombre = "";
        }
        #endregion
    }
}
