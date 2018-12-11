using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

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
            string nuevoservidor = "Data Source=" + txtServidor + ";Initial Catalog=CITRA;Integrated Security=True";
            SqlConnection _Conexion = new SqlConnection(nuevoservidor);
            try
            {
                _Conexion.Open();
                bool Resultado = DocumentoConfig(nuevoservidor);
                _Conexion.Close();
                return Resultado;
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
            string nuevoservidor = "Data Source=" + txtServidor + ";Database=CITRA;User Id=" + txtUsuario + ";Password=" + txtPass;
            SqlConnection _Conexion = new SqlConnection(nuevoservidor);
            try
            {
                _Conexion.Open();
                bool Resultado = DocumentoConfig(nuevoservidor);
                _Conexion.Close();
                return Resultado;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// procedimiento que permite generar el documento .Config que se encuentra en la carpeta DEBUG
        /// </summary>
        /// <param name="CadenaSQL">cadena de conexion SQL</param>
        /// <returns>verdadero (true) si tiene exito</returns>
        private bool DocumentoConfig(string CadenaSQL)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            try
            {
                ConnectionStringSettings csSettings = new ConnectionStringSettings("MiConexion", CadenaSQL, "System.Data.SqlClient");
                ConnectionStringsSection csSection = config.ConnectionStrings;
                csSection.ConnectionStrings.Add(csSettings);
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
                return true;
            }
            catch (Exception ex)
            {
                if (ex is ConfigurationException)
                {
                    config.ConnectionStrings.ConnectionStrings["MiConexion"].ConnectionString = CadenaSQL;
                    ConnectionStringsSection csSection = config.ConnectionStrings;
                    config.Save(ConfigurationSaveMode.Modified, true);
                    ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
     
    }
}
