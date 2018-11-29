using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AOds
    {
          #region "Propiedades"
        public int Id_Contacto_Ods { get; set; }
        public string Nombre_Organizacion { get; set; }

        public string Nombre_Contacto { get; set; }

        public string Nombre_Cargo { get; set; }
        public string Correo_Ods { get; set; }

         public string Telefono { get; set; }

         public string Telefono2 { get; set; }

         public string Nombre_Sector { get; set; }

        #endregion

         #region "Constructor"
        public AOds()
        {
            Id_Contacto_Ods = 0;
            Nombre_Organizacion = "";
            Nombre_Contacto = "";
            Nombre_Cargo = "";
            Correo_Ods = "";
            Telefono = "";
            Telefono2 = "";
            Nombre_Sector = "";
        }
        #endregion
    }
}
