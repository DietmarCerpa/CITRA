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
    public class Camaras_Privadas
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//

        public Int32 Insertar(Camara_Privada pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Camaras_Privadas] VALUES (@Id_Contacto_Camara, @Nombre_Contacto_Camara  ,@Nombre_Organizacion, @Nombre_Cargo , @Correo_Camara, @Telefono, @Extension) ";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Camara", SqlDbType.Int).Value = pRegistro.Id_Contacto_Camara;
                    command.Parameters.Add("@Nombre_Contacto_Camara", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto_Camara;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Correo_Camara", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Camara;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = pRegistro.Telefono;
                    command.Parameters.Add("@Extension", SqlDbType.VarChar, 5).Value = pRegistro.Extension;
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

        public Int32 Modificar(Camara_Privada pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Camaras_Privadas] " +
                                     "SET  Id_Contacto_Camara= @Id_Contacto_Camara, Nombre_Contacto_Camara= @Nombre_Contacto_Camara, Nombre_Organizacion= @Nombre_Organizacion, Nombre_Cargo= @Nombre_Cargo, Correo_Camara= @Correo_Camara, Telefono = @Telefono, Extension= @Extension "
                                     + "WHERE Id_Contacto_Camara = @Id_Contacto_Camara";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Camara", SqlDbType.Int).Value = pRegistro.Id_Contacto_Camara;
                    command.Parameters.Add("@Nombre_Contacto_Camara", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto_Camara;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Correo_Camara", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Camara;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = pRegistro.Telefono;
                    command.Parameters.Add("@Extension", SqlDbType.VarChar, 5).Value = pRegistro.Extension;
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

                string commandText = "SELECT [Id_Contacto_Camara] AS Id, [Nombre_Contacto_Camara] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Cargo] AS Cargo, [Correo_Camara] AS Correo, [Telefono] AS Teléfono, [Extension] AS Extensión  FROM [dbo].[Camaras_Privadas] order by Nombre_Contacto_Camara asc";

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

        public Int32 Eliminar(Camara_Privada pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Camaras_Privadas] WHERE Id_Contacto_Camara = @Id_Contacto_Camara";
                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Camara", SqlDbType.Int).Value = pRegistro.Id_Contacto_Camara;
                    command.Parameters.Add("@Nombre_Contacto_Camara", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto_Camara;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Correo_Camara", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Camara;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = pRegistro.Telefono;
                    command.Parameters.Add("@Extension", SqlDbType.VarChar, 5).Value = pRegistro.Extension;
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
                string commandText = "DELETE [dbo].[Camaras_Privadas] ";

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

                string commandText = "SELECT [Id_Contacto_Camara] AS Id, [Nombre_Contacto_Camara] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Cargo] AS Cargo, [Correo_Camara] AS Correo , [Telefono] AS Teléfono, [Extension] AS Extensión FROM [dbo].[Camaras_Privadas] WHERE Id_Contacto_Camara = " + pCodigoL;

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

        public Camara_Privada LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Camara_Privada vRegistro = new Camara_Privada();

                string commandText = "SELECT [Id_Contacto_Camara] AS Id, [Nombre_Contacto_Camara] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Cargo] AS Cargo, [Correo_Camara] AS Correo, [Telefono] AS Teléfono, [Extension] AS Extensión  FROM [dbo].[Camaras_Privadas] WHERE Id_Contacto_Camara = " + pCodigoL;


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

                vRegistro.Id_Contacto_Camara = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Contacto_Camara = dtConsulta.Rows[0]["Nombre"].ToString();
                vRegistro.Nombre_Organizacion = dtConsulta.Rows[0]["Organización"].ToString();
                vRegistro.Nombre_Cargo = dtConsulta.Rows[0]["Cargo"].ToString();
                vRegistro.Correo_Camara = dtConsulta.Rows[0]["Correo"].ToString();
                vRegistro.Telefono = dtConsulta.Rows[0]["Teléfono"].ToString();
                vRegistro.Extension = dtConsulta.Rows[0]["Extensión"].ToString();
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
