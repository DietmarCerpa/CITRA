using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Departamento
    {
         #region "Propiedades"
        public int Id_Departamento { get; set; }
        public string Nombre_Departamento { get; set; } 

        #endregion

         #region "Constructor"
        public Departamento()
        {
            Id_Departamento = 0;
            Nombre_Departamento = "";
        }
        #endregion
    }
}
