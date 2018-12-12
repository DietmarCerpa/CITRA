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
    public class Sinirubes
    {
        static string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//
        SqlConnection connection = new SqlConnection(vCadenaConexion);
        public Int32 Insertar(Sinirube pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Alianza_Sinirube] VALUES (@Id_Contacto_Sinirube, @Nombre_Contacto_Sinirube, @Nombre_Cargo, @Nombre_Organizacion, @Correo_Sinirube) ";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Sinirube", SqlDbType.Int).Value = pRegistro.Id_Contacto_Sinirube;
                    command.Parameters.Add("@Nombre_Contacto_Sinirube", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto_Sinirube;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Correo_Sinirube", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Sinirube;
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

        public Int32 Modificar(Sinirube pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Alianza_Sinirube] " +
                                     "SET  Id_Contacto_Sinirube= @Id_Contacto_Sinirube, Nombre_Contacto_Sinirube= @Nombre_Contacto_Sinirube, Nombre_Cargo= @Nombre_Cargo, Nombre_Organizacion= @Nombre_Organizacion, Correo_Sinirube= @Correo_Sinirube "
                                     + "WHERE Id_Contacto_Sinirube = @Id_Contacto_Sinirube";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Sinirube", SqlDbType.Int).Value = pRegistro.Id_Contacto_Sinirube;
                    command.Parameters.Add("@Nombre_Contacto_Sinirube", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto_Sinirube;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Correo_Sinirube", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Sinirube;
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

                string commandText = "SELECT [Id_Contacto_Sinirube] AS Id , [Nombre_Contacto_Sinirube] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Sinirube] AS Correo  FROM [dbo].[Alianza_Sinirube] order by Nombre_Contacto_Sinirube asc ";

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

        public Int32 Eliminar(Sinirube pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Alianza_Sinirube] WHERE Id_Contacto_Sinirube = @Id_Contacto_Sinirube";
                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Sinirube", SqlDbType.Int).Value = pRegistro.Id_Contacto_Sinirube;
                    command.Parameters.Add("@Nombre_Contacto_Sinirube", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto_Sinirube;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Correo_Sinirube", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Sinirube;
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
                string commandText = "DELETE [dbo].[Alianza_Sinirube] ";

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

                string commandText = "SELECT [Id_Contacto_Sinirube] AS Id, [Nombre_Contacto_Sinirube] AS Nombre, [Nombre_Cargo] AS Nombre_Cargo, [Nombre_Organizacion] AS Organización, [Correo_Sinirube] AS Correo FROM [dbo].[Alianza_Sinirube] WHERE Id_Contacto_Sinirube = " + pCodigoL;

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

        public Sinirube LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Sinirube vRegistro = new Sinirube();

                string commandText = "SELECT [Id_Contacto_Sinirube] AS Id, [Nombre_Contacto_Sinirube] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Sinirube] AS Correo FROM [dbo].[Alianza_Sinirube] WHERE Id_Contacto_Sinirube = " + pCodigoL;


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

                vRegistro.Id_Contacto_Sinirube = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Contacto_Sinirube = dtConsulta.Rows[0]["Nombre"].ToString();
                vRegistro.Nombre_Cargo = dtConsulta.Rows[0]["Cargo"].ToString();
                vRegistro.Nombre_Organizacion = dtConsulta.Rows[0]["Organización"].ToString();
                vRegistro.Correo_Sinirube = dtConsulta.Rows[0]["Correo"].ToString();
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
