using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inamu
    {
         #region "Propiedades"
        public int Id_Contacto { get; set; }
        public string Nombre_Contacto { get; set; }
        public string Nombre_Cargo { get; set; }

        public string Nombre_Organizacion { get; set; }

        public string Correo_Inamu { get; set; }

        public string Telefono { get; set; }

        #endregion

         #region "Constructor"
        public Inamu()
        {
            Id_Contacto = 0;
            Nombre_Contacto = "";
            Nombre_Cargo = "";
            Nombre_Organizacion = "";
            Correo_Inamu = "";
            Telefono = "";
        }
        #endregion
    }
}
