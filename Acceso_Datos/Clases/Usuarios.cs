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
    public class Usuarios
    {
        static string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//
        SqlConnection connection = new SqlConnection(vCadenaConexion);
        public Int32 Insertar(Usuario pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Usuarios] VALUES (@Id_Usuario, @Nombre_Persona, @Cedula, @Roles , @Email, @Nombre_Usuario, @Contraseña) ";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Usuario", SqlDbType.Int).Value = pRegistro.Id_Usuario;
                    command.Parameters.Add("@Nombre_Persona", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Persona;
                    command.Parameters.Add("@Cedula", SqlDbType.VarChar, 20).Value = pRegistro.Cedula;
                    command.Parameters.Add("@Roles", SqlDbType.Int).Value = pRegistro.Roles;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 40).Value = pRegistro.Email;
                    command.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 20).Value = pRegistro.Nombre_Usuario;
                    command.Parameters.Add("@Contraseña", SqlDbType.VarChar, 20).Value = pRegistro.Contraseña;
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

        public Int32 Modificar(Usuario pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Usuarios] " +
                                     "SET  Id_Usuario= @Id_Usuario, Nombre_Persona= @Nombre_Persona, Cedula= @Cedula, Roles= @Roles, Email= @Email, Nombre_Usuario = @Nombre_Usuario, Contraseña= @Contraseña "
                                     + "WHERE Id_Usuario = @Id_Usuario";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Usuario", SqlDbType.Int).Value = pRegistro.Id_Usuario;
                    command.Parameters.Add("@Nombre_Persona", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Persona;
                    command.Parameters.Add("@Cedula", SqlDbType.VarChar, 20).Value = pRegistro.Cedula;
                    command.Parameters.Add("@Roles", SqlDbType.Int).Value = pRegistro.Roles;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 40).Value = pRegistro.Email;
                    command.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 20).Value = pRegistro.Nombre_Usuario;
                    command.Parameters.Add("@Contraseña", SqlDbType.VarChar, 20).Value = pRegistro.Contraseña;
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

                string commandText = "SELECT [Id_Usuario] AS Id, [Nombre_Persona] AS Nombre, [Cedula] AS Cédula, [Roles] AS Rol, [Email] AS Correo, [Nombre_Usuario] AS Usuario, [Contraseña] AS Contraseña  FROM [dbo].[Usuarios] order by Nombre_Persona asc";

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

        public Int32 Eliminar(Usuario pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Usuarios] WHERE Id_Usuario = @Id_Usuario";
                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Usuario", SqlDbType.Int).Value = pRegistro.Id_Usuario;
                    command.Parameters.Add("@Nombre_Persona", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Persona;
                    command.Parameters.Add("@Cedula", SqlDbType.VarChar, 20).Value = pRegistro.Cedula;
                    command.Parameters.Add("@Roles", SqlDbType.Int).Value = pRegistro.Roles;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 40).Value = pRegistro.Email;
                    command.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 20).Value = pRegistro.Nombre_Usuario;
                    command.Parameters.Add("@Contraseña", SqlDbType.VarChar, 20).Value = pRegistro.Contraseña;
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
                string commandText = "DELETE [dbo].[Usuarios] ";

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

                string commandText = "SELECT [Id_Usuario] AS Id, [Nombre_Persona] AS Nombre, [Cedula] AS Cédula, [Roles] AS Rol, [Email] AS Correo, [Nombre_Usuario] AS Usuario, [Contraseña] AS Contraseña FROM [dbo].[Usuarios] WHERE Id_Usuario = " + pCodigoL;

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

        public Usuario LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Usuario vRegistro = new Usuario();

                string commandText = "SELECT [Id_Usuario] AS Id, [Nombre_Persona] AS Nombre, [Cedula] AS Cédula, [Roles] AS Rol, [Email] AS Correo, [Nombre_Usuario] AS Usuario, [Contraseña] AS Contraseña FROM [dbo].[Usuarios] WHERE Id_Usuario = " + pCodigoL;


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

                vRegistro.Id_Usuario = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Persona = dtConsulta.Rows[0]["Nombre"].ToString();
                vRegistro.Cedula = dtConsulta.Rows[0]["Cédula"].ToString();
                vRegistro.Roles = Convert.ToInt32(dtConsulta.Rows[0]["Rol"]);
                vRegistro.Email = dtConsulta.Rows[0]["Correo"].ToString();
                vRegistro.Nombre_Usuario = dtConsulta.Rows[0]["Usuario"].ToString();
                vRegistro.Contraseña = dtConsulta.Rows[0]["Contraseña"].ToString();
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
