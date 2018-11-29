using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PermisoxModulo
    {
        #region "Propiedades"
        public int id_Rol { get; set; }
        public int id_Modulo { get; set; }

        #endregion

         #region "Constructor"
        public PermisoxModulo()
        {
            id_Rol = 0;
            id_Modulo = 0;
        }
        #endregion

    }
}
