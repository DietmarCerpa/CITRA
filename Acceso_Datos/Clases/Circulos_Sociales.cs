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
    public class Circulos_Sociales
    {
        static string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//
        SqlConnection connection = new SqlConnection(vCadenaConexion);
        public Int32 Insertar(Circulo_Social pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Circulos_Sociales] VALUES (@Id_Circulo, @Nombre_Circulo  ,@Nombre_Organizacion, @Nombre_Departamento , @Correo_Circulo) ";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Circulo", SqlDbType.Int).Value = pRegistro.Id_Circulo;
                    command.Parameters.Add("@Nombre_Circulo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Circulo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Departamento", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Departamento;
                    command.Parameters.Add("@Correo_Circulo", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Circulo;
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

        public Int32 Modificar(Circulo_Social pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Circulos_Sociales] " +
                                     "SET  Id_Circulo= @Id_Circulo, Nombre_Circulo= @Nombre_Circulo, Nombre_Organizacion= @Nombre_Organizacion, Nombre_Departamento= @Nombre_Departamento, Correo_Circulo= @Correo_Circulo "
                                     + "WHERE Id_Circulo = @Id_Circulo";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Circulo", SqlDbType.Int).Value = pRegistro.Id_Circulo;
                    command.Parameters.Add("@Nombre_Circulo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Circulo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Departamento", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Departamento;
                    command.Parameters.Add("@Correo_Circulo", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Circulo;
                    connection.Open();
                    FilasAfectadas = command.ExecuteNonQuery();
                    connection.Close();

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

                string commandText = "SELECT [Id_Circulo] AS Id, [Nombre_Circulo] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Departamento] AS Departamento, [Correo_Circulo] AS Correo  FROM [dbo].[Circulos_Sociales] order by Nombre_Circulo asc ";

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

        public Int32 Eliminar(Circulo_Social pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Circulos_Sociales] WHERE Id_Circulo = @Id_Circulo";
                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Circulo", SqlDbType.Int).Value = pRegistro.Id_Circulo;
                    command.Parameters.Add("@Nombre_Circulo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Circulo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Departamento", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Departamento;
                    command.Parameters.Add("@Correo_Circulo", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Circulo;
                    connection.Open();
                    FilasAfectadas = command.ExecuteNonQuery();
                    connection.Close();
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
                string commandText = "DELETE [dbo].[Circulos_Sociales] ";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    connection.Open();
                    FilasAfectadas = command.ExecuteNonQuery();
                    connection.Close();
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

                string commandText = "SELECT [Id_Circulo] AS Id, [Nombre_Circulo] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Departamento] AS Departamento, [Correo_Circulo] AS Correo  FROM [dbo].[Circulos_Sociales] WHERE Id_Circulo = " + pCodigoL;

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

        public Circulo_Social LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Circulo_Social vRegistro = new Circulo_Social();

                string commandText = "SELECT [Id_Circulo] AS Id, [Nombre_Circulo] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Departamento] AS Departamento, [Correo_Circulo] AS Correo  FROM [dbo].[Circulos_Sociales] WHERE Id_Circulo = " + pCodigoL;


                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count == 0)
                {
                    throw new Exception("El dato esta Corrupto");
                }

                vRegistro.Id_Circulo = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Circulo = dtConsulta.Rows[0]["Nombre"].ToString();
                vRegistro.Nombre_Organizacion = dtConsulta.Rows[0]["Organización"].ToString();
                vRegistro.Nombre_Departamento = dtConsulta.Rows[0]["Departamento"].ToString();
                vRegistro.Correo_Circulo = dtConsulta.Rows[0]["Correo"].ToString();
                return vRegistro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
