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
    public class Modulos
    {
        static string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//
        SqlConnection connection = new SqlConnection(vCadenaConexion);
        public DataTable LlenarLista()//
        {
            DataTable dtConsulta = new DataTable();

            try
            {

                string commandText = "SELECT [id] AS Id, [nombre] AS Nombre  FROM [dbo].[Modulos] Order by Id asc ";

                using (connection)
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
