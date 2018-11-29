using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Socio_Estrategico
    {
         #region "Propiedades"
        public int Id_Socio { get; set; }

        public string Nombre_Socio { get; set; }

        public string Nombre_Cargo { get; set; }

        public string Nombre_Organizacion { get; set; }

        public string Correo_Socio { get; set; }

        #endregion

         #region "Constructor"
        public Socio_Estrategico()
        {
            Id_Socio = 0;
            Nombre_Socio = "";
            Nombre_Cargo = "";
            Nombre_Organizacion = "";
            Correo_Socio = "";
        }
        #endregion
    }
}
