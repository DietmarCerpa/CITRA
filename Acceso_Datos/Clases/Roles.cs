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
    public class Roles
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//

        public Int32 Insertar(Rol pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Rol] VALUES (@Id_Rol, @Nombre_Rol, @Nivel) ";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Rol", SqlDbType.Int).Value = pRegistro.Id_Rol;
                    command.Parameters.Add("@Nombre_Rol", SqlDbType.VarChar, 20).Value = pRegistro.Nombre_Rol;
                    command.Parameters.Add("@Nivel", SqlDbType.Int).Value = pRegistro.Nivel;
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

        public Int32 Modificar(Rol pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Rol] " +
                                     "SET  Id_Rol= @Id_Rol, Nombre_Rol = @Nombre_Rol, Nivel= @Nivel "
                                     + "WHERE Id_Rol = @Id_Rol";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Rol", SqlDbType.Int).Value = pRegistro.Id_Rol;
                    command.Parameters.Add("@Nombre_Rol", SqlDbType.VarChar, 20).Value = pRegistro.Nombre_Rol;
                    command.Parameters.Add("@Nivel", SqlDbType.Int).Value = pRegistro.Nivel;
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

                string commandText = "SELECT [Id_Rol] AS Id, [Nombre_Rol] AS Nombre, [Nivel] AS Nivel  FROM [dbo].[Rol] Order by Id_Rol asc ";

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

        public Int32 Eliminar(Rol pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Rol] WHERE Id_Rol = @Id_Rol";
                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Rol", SqlDbType.Int).Value = pRegistro.Id_Rol;
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
                string commandText = "DELETE [dbo].[Rol] ";

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

                string commandText = "SELECT [Id_Rol] AS Id, [Nombre_Rol] AS Nombre, [Nivel] AS Nivel  FROM [dbo].[Rol] WHERE Id_Rol = " + pCodigoL;

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

        public Rol LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Rol vRegistro = new Rol();

                string commandText = "SELECT [Id_Rol] AS Id, [Nombre_Rol] AS Nombre, [Nivel] AS Nivel  FROM [dbo].[Rol] WHERE Id_Rol = " + pCodigoL;


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

                vRegistro.Id_Rol = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Rol = dtConsulta.Rows[0]["Nombre"].ToString();
                vRegistro.Nivel = Convert.ToInt32(dtConsulta.Rows[0]["Nivel"]);
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
