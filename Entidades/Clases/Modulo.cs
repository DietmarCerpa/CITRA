using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Modulo
    {
        #region "Propiedades"
        public int id { get; set; }
        public string nombre { get; set; } 

        #endregion

         #region "Constructor"
        public Modulo()
        {
            id = 0;
            nombre = "";
        }
        #endregion


    }
}
