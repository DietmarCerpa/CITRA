using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rblac
    {
        #region "Propiedades"
        public int Id_Rblac { get; set; }

        public string Nombre_Rblac { get; set; }

        public string Nombre_Departamento { get; set; }

        public string Ubicacion { get; set; }

        public string Extension { get; set; }

        public string Nombre_Cargo { get; set; }

        #endregion

         #region "Constructor"
        public Rblac()
        {
            Id_Rblac = 0;
            Nombre_Rblac = "";
            Nombre_Departamento = "";
            Ubicacion = "";
            Extension = "";
            Nombre_Cargo = "";
        }
        #endregion
    }
}
