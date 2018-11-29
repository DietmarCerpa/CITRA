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
    public class Socios_Estrategicoss
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//

        public Int32 Insertar(Socio_Estrategico pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Socios_Estrategicos] VALUES (@Id_Socio, @Nombre_Socio, @Nombre_Cargo, @Nombre_Organizacion, @Correo_Socio) ";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Socio", SqlDbType.Int).Value = pRegistro.Id_Socio;
                    command.Parameters.Add("@Nombre_Socio", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Socio;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Correo_Socio", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Socio;
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

        public Int32 Modificar(Socio_Estrategico pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Socios_Estrategicos] " +
                                     "SET  Id_Socio= @Id_Socio, Nombre_Socio= @Nombre_Socio, Nombre_Cargo= @Nombre_Cargo, Nombre_Organizacion= @Nombre_Organizacion, Correo_Socio= @Correo_Socio "
                                     + "WHERE Id_Socio = @Id_Socio";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Socio", SqlDbType.Int).Value = pRegistro.Id_Socio;
                    command.Parameters.Add("@Nombre_Socio", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Socio;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Correo_Socio", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Socio;
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

                string commandText = "SELECT [Id_Socio] AS Id , [Nombre_Socio] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Socio] AS Correo  FROM [dbo].[Socios_Estrategicos] order by Nombre_Socio asc";

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

        public Int32 Eliminar(Socio_Estrategico pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Socios_Estrategicos] WHERE Id_Socio = @Id_Socio";
                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Socio", SqlDbType.Int).Value = pRegistro.Id_Socio;
                    command.Parameters.Add("@Nombre_Socio", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Socio;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Correo_Socio", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Socio;
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
                string commandText = "DELETE [dbo].[Socios_Estrategicos] ";

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

                string commandText = "SELECT [Id_Socio] AS Id , [Nombre_Socio] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Socio] AS Correo  FROM [dbo].[Socios_Estrategicos] WHERE Id_Socio = " + pCodigoL;

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

        public Socio_Estrategico LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Socio_Estrategico vRegistro = new Socio_Estrategico();

                string commandText = "SELECT [Id_Socio] AS Id , [Nombre_Socio] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Socio] AS Correo  FROM [dbo].[Socios_Estrategicos] WHERE Id_Socio = " + pCodigoL;


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

                vRegistro.Id_Socio = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Socio = dtConsulta.Rows[0]["Nombre"].ToString();
                vRegistro.Nombre_Cargo = dtConsulta.Rows[0]["Cargo"].ToString();
                vRegistro.Nombre_Organizacion = dtConsulta.Rows[0]["Organización"].ToString();
                vRegistro.Correo_Socio = dtConsulta.Rows[0]["Correo"].ToString();
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
