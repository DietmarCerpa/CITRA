using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sinirube
    {
         #region "Propiedades"
        public int Id_Contacto_Sinirube { get; set; }

        public string Nombre_Contacto_Sinirube { get; set; }

        public string Nombre_Cargo { get; set; }
        public string Nombre_Organizacion { get; set; }
       
        public string Correo_Sinirube { get; set; }

        #endregion

         #region "Constructor"
        public Sinirube()
        {
            Id_Contacto_Sinirube = 0;
            Nombre_Contacto_Sinirube = "";
            Nombre_Cargo = "";
            Nombre_Organizacion = "";       
            Correo_Sinirube = "";
        }
        #endregion
    }
}
