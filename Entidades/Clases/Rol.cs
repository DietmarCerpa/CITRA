using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rol
    {
        #region "Propiedades"
        public int Id_Rol { get; set; }
        public string Nombre_Rol { get; set; } 
        public int Nivel { get; set; }

        #endregion

         #region "Constructor"
        public Rol()
        {
            Id_Rol = 0;
            Nombre_Rol = "";
            Nivel = 0;
        }
        #endregion
    }
}
