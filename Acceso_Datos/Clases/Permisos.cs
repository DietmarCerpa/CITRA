using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Acceso_Datos
{
    public class Permisos
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//

        public DataTable LlenarLista()//
        {
            DataTable dtConsulta = new DataTable();

            try
            {

                string commandText = "SELECT [id] AS Id, [nombre] AS Nombre  FROM [dbo].[Permisos] Order by Id asc ";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtConsulta;

        }
    }
}
