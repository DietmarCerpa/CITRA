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
    public class PermisosxRoles
    {
        static string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//
        SqlConnection connection = new SqlConnection(vCadenaConexion);
        public Int32 Insertar(PermisoxRol pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Permisos_x_Rol] VALUES (@id_Rol, @id_Permiso) ";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@id_Rol", SqlDbType.Int).Value = pRegistro.id_Rol;
                    command.Parameters.Add("@id_Permiso", SqlDbType.Int).Value = pRegistro.id_Permiso;
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

        public Int32 Modificar(PermisoxRol pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Permisos_x_Rol] " +
                                     "SET  id_Rol= @id_Rol, id_Permiso = @id_Permiso "
                                     + "WHERE id_Rol = @id_Rol";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@id_Rol", SqlDbType.Int).Value = pRegistro.id_Rol;
                    command.Parameters.Add("@id_Permiso", SqlDbType.Int).Value = pRegistro.id_Permiso;
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

                string commandText = "SELECT [id_Rol] AS Rol, [id_Permiso] AS Permiso FROM [dbo].[Permisos_x_Rol] Order by id_Rol asc ";

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

        public Int32 Eliminar(PermisoxRol pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Permisos_x_Rol] WHERE id_Rol = @id_Rol";
                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@id_Rol", SqlDbType.Int).Value = pRegistro.id_Rol;
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
                string commandText = "DELETE [dbo].[Permisos_x_Rol] ";

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

                string commandText = "SELECT [id_Rol] AS Rol, [id_Permiso] AS Permiso FROM [dbo].[Permisos_x_Rol] where id_Rol = " + pCodigoL;

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

        public PermisoxRol LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                PermisoxRol vRegistro = new PermisoxRol();

                string commandText = "SELECT [id_Rol] AS Rol, [id_Permiso] AS Permiso FROM [dbo].[Permisos_x_Rol] where id_Rol = " + pCodigoL;


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

                vRegistro.id_Rol = Convert.ToInt32(dtConsulta.Rows[0]["Rol"]);
                vRegistro.id_Permiso = Convert.ToInt32(dtConsulta.Rows[0]["Permiso"]);
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
