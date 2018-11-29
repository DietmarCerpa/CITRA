using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AObf
    {
          #region "Propiedades"
        public int Id_Contacto_Obf { get; set; }
        public string Nombre_Organizacion { get; set; }

        public string Nombre_Contacto { get; set; }

        public string Correo_Obf { get; set; }

         public string Telefono_Obf { get; set; }

         public string Telefono2 { get; set; }

        #endregion

         #region "Constructor"
        public AObf()
        {
            Id_Contacto_Obf = 0;
            Nombre_Organizacion = "";
            Nombre_Contacto = "";
            Correo_Obf = "";
            Telefono_Obf = "";
            Telefono2 = "";
        }
        #endregion
    }
}
