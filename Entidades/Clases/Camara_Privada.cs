using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camara_Privada
    {
        #region "Propiedades"
        public int Id_Contacto_Camara { get; set; }
        public string Nombre_Organizacion { get; set; }

        public string Nombre_Contacto_Camara { get; set; }
        public string Nombre_Cargo { get; set; }
        public string Correo_Camara { get; set; }

        public string Telefono { get; set; }

        public string Extension { get; set; }

        #endregion

         #region "Constructor"
        public Camara_Privada()
        {
            Id_Contacto_Camara = 0;
            Nombre_Organizacion = "";
            Nombre_Contacto_Camara = "";
            Nombre_Cargo = "";
            Correo_Camara = "";
            Telefono = "";
            Extension = "";
        }
        #endregion
    }
}
