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
    public class Organizaciones
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//

        public Int32 Insertar(Organizacion pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Organizaciones] VALUES (@Id_Organizacion, @Nombre_Organizacion) ";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Organizacion", SqlDbType.Int).Value = pRegistro.Id_Organizacion;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    connection.Open();
                    FilasAfectadas = command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }

        public Int32 Modificar(Organizacion pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Organizaciones] " +
                                     "SET  Id_Organizacion= @Id_Organizacion, Nombre_Organizacion = @Nombre_Organizacion "
                                     + "WHERE Id_Organizacion = @Id_Organizacion";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Organizacion", SqlDbType.Int).Value = pRegistro.Id_Organizacion;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    connection.Open();
                    FilasAfectadas = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FilasAfectadas;
        }

        public DataTable LlenarLista()//
        {
            DataTable dtConsulta = new DataTable();

            try
            {

                string commandText = "SELECT [Id_Organizacion] AS Id, [Nombre_Organizacion] AS Organización FROM [dbo].[Organizaciones] order by Nombre_Organizacion asc";

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

        public Int32 Eliminar(Organizacion pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Organizaciones] WHERE Id_Organizacion = @Id_Organizacion";
                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Organizacion", SqlDbType.Int).Value = pRegistro.Id_Organizacion;
                    connection.Open();
                    FilasAfectadas = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }


        public Int32 Eliminar()
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Organizaciones] ";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    connection.Open();
                    FilasAfectadas = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }

        public DataTable LeerCodigoLlave(string pCodigoL)
        {
            DataTable dtConsulta = new DataTable();

            try
            {

                string commandText = "SELECT [Id_Organizacion] AS Id, [Nombre_Organizacion] AS Organización FROM [dbo].[Organizaciones] WHERE Id_Organizacion = " + pCodigoL;

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

        public Organizacion LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Organizacion vRegistro = new Organizacion();

                string commandText = "SELECT [Id_Organizacion] AS Id, [Nombre_Organizacion] AS Organización FROM [dbo].[Organizaciones] WHERE Id_Organizacion = " + pCodigoL;


                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count == 0)
                {
                    throw new Exception("El dato esta Corrupto");
                }

                vRegistro.Id_Organizacion = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Organizacion = dtConsulta.Rows[0]["Organización"].ToString();

                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
