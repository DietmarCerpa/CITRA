using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Presentacion
{
    public class CadenaConexion
    {
        /// <summary>
        /// procedimiento que permite crear una cadena de conexion apuntando a un servidor en el mismo equipo
        /// a traves del nombre del servidor y seguridad integrada (no requiere usuario y contraseña)
        /// </summary>
        /// <param name="txtServidor">nombre  del servidor SQLSERVER</param>
        /// <returns> retorna true (verdadero) si se logro conectar con el servidor y false (falso) si no se logra conectar</returns>
        public bool guardarServidorLocal(string txtServidor)
        {
            try
            {
                string nuevoservidor = "Data Source=" + txtServidor + ";Initial Catalog=CITRA;Integrated Security=True";
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConnectionStringSettings csSettings = new ConnectionStringSettings("MiConexion", nuevoservidor, "System.Data.SqlClient");
                ConnectionStringsSection csSection = config.ConnectionStrings;
                csSection.ConnectionStrings.Add(csSettings);
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// procedimiento que permite crear una cadena de conexion apuntando a un servidor remoto (DENTRO DE LA MISMA RED)
        /// y que este habilitado para mostrar su nombre de servidor en la red 
        /// </summary>
        /// <param name="txtServidor">nombre del servidor SQLSERVER</param>
        /// <param name="txtUsuario">usuario para incio de sesion</param>
        /// <param name="txtPass">contraseña del servidor</param>
        /// <returns>retorna true (verdadero) si se logro conectar con el servidor y false (falso) si no se logra conectar</returns>
        public bool guardarServidorRemoto(string txtServidor, string txtUsuario, string txtPass)
        {
            try
            {
                string nuevoservidor = "Data Source=" + txtServidor + ";Initial Catalog=CITRA;Integrated Security=False;User Id=" + txtUsuario + ";Password =" + txtPass;
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConnectionStringSettings csSettings = new ConnectionStringSettings("MiConexion", nuevoservidor, "System.Data.SqlClient");
                ConnectionStringsSection csSection = config.ConnectionStrings;
                csSection.ConnectionStrings.Add(csSettings);
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// este procedimiento permite crear una cadena de conexion para ser implementada en el proyecto tomando el nombre del servidor
        /// LOCAL
        /// </summary>
        /// <param name="txtServidor"> nombre del servidor SQLServer LOCAL</param>
        public void GuardarServidor(string txtServidor)
        {

            string nuevoservidor = "Data Source=" + txtServidor + ";Initial Catalog=CITRA;Integrated Security=True";
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings csSettings = new ConnectionStringSettings("MiConexion", nuevoservidor, "System.Data.SqlClient");
            ConnectionStringsSection csSection = config.ConnectionStrings;
            csSection.ConnectionStrings.Add(csSettings);
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
        }

        /// <summary>
        /// este procedimiento permite crear una cadena de conexion para que sea implementada en el proyecto tomando en cuenta
        /// el nombre del servidor, usuario y contraseña para acceder a la base de datos
        /// </summary>
        /// <param name="txtServidor"> nombre del servidor </param>
        /// <param name="txtUsuario"> nombre del usuario del servidor (autorizado)</param>
        /// <param name="txtPase">contraseña del servidor</param>
        public void GuardarServidorRemoto(string txtServidor, string txtUsuario, string txtPase)
        {


            string nuevoservidor = "Data Source=" + txtServidor + ";Initial Catalog=CITRA;User Id=" + txtUsuario +";Password =" + txtPase;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings csSettings = new ConnectionStringSettings("MiConexion", nuevoservidor, "System.Data.SqlClient");
            ConnectionStringsSection csSection = config.ConnectionStrings;
            csSection.ConnectionStrings.Add(csSettings);
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
        }

    }
}
