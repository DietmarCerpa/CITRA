using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PermisoxRol
    {
         #region "Propiedades"
        public int id_Rol { get; set; }
        public int id_Permiso { get; set; }

        #endregion

         #region "Constructor"
        public PermisoxRol()
        {
            id_Rol = 0;
            id_Permiso = 0;
        }
        #endregion


    }
}
