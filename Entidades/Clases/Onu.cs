using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Onu
    {
         #region "Propiedades"
        public int Id_Contacto_Regional { get; set; }

        public string Nombre_Pais { get; set; }

        public string Nombre_Director { get; set; }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Adrr { get; set; }
        public string Telefono3 { get; set; }

        public string Fax { get; set; }

        public string Direccion_Director { get; set; }

        #endregion

         #region "Constructor"
        public Onu()
        {
            Id_Contacto_Regional = 0;
            Nombre_Pais = "";
            Nombre_Director = "";
            Telefono1 = "";
            Telefono2 = "";
            Adrr = "";
            Telefono3 = "";
            Fax = "";
            Direccion_Director = "";
        }
        #endregion
    }
}
