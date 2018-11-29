using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Circulo_Social
    {
        #region "Propiedades"
        public int Id_Circulo { get; set; }

        public string Nombre_Circulo { get; set; }

        public string Nombre_Organizacion { get; set; }

        public string Nombre_Departamento { get; set; }

        public string Correo_Circulo { get; set; }

        #endregion

         #region "Constructor"
        public Circulo_Social()
        {
            Id_Circulo = 0;
            Nombre_Circulo = "";
            Nombre_Organizacion = "";
            Nombre_Departamento = "";
            Correo_Circulo = "";
        }
        #endregion
    }
}
