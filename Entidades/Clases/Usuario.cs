using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region "Propiedades"
        public int Id_Usuario { get; set; }
        public string Nombre_Persona { get; set; }
        public string Cedula { get; set; }
        public int Roles { get; set; }
        public string Email { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña { get; set; }

        #endregion

         #region "Constructor"
        public Usuario()
        {
            Id_Usuario = 0;
            Nombre_Persona = "";
            Cedula = "";
            Roles = 0;
            Email = "";
            Nombre_Usuario = "";
            Contraseña = "";
        }
        #endregion
    }
}
