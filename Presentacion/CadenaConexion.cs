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
        public void GuardarServidor(string txtservidor)
        {
            string nuevoservidor = "Data Source=" + txtservidor + ";Initial Catalog=CITRA;Integrated Security=True";
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings csSettings = new ConnectionStringSettings("MiConexion", nuevoservidor, "System.Data.SqlClient");
            ConnectionStringsSection csSection = config.ConnectionStrings;
            csSection.ConnectionStrings.Add(csSettings);
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
        }
    }
}
