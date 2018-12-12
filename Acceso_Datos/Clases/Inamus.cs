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
    public class Inamus
    {
        static string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        SqlConnection connection = new SqlConnection(vCadenaConexion);

        public Int32 Insertar(Inamu pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Alianza_Inamu] VALUES (@Id_Contacto, @Nombre_Contacto, @Nombre_Cargo, @Nombre_Organizacion, @Correo_Inamu, @Telefono) ";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto", SqlDbType.Int).Value = pRegistro.Id_Contacto;
                    command.Parameters.Add("@Nombre_Contacto", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Correo_Inamu", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Inamu;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = pRegistro.Telefono;
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

        public Int32 Modificar(Inamu pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Alianza_Inamu] " +
                                     "SET  Id_Contacto= @Id_Contacto, Nombre_Contacto= @Nombre_Contacto, Nombre_Cargo= @Nombre_Cargo, Nombre_Organizacion= @Nombre_Organizacion, Correo_Inamu= @Correo_Inamu, Telefono = @Telefono "
                                     + "WHERE Id_Contacto = @Id_Contacto";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto", SqlDbType.Int).Value = pRegistro.Id_Contacto;
                    command.Parameters.Add("@Nombre_Contacto", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Correo_Inamu", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Inamu;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = pRegistro.Telefono;
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

                string commandText = "SELECT [Id_Contacto] AS Id, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Inamu] AS Correo, [Telefono] AS Teléfono  FROM [dbo].[Alianza_Inamu] order by Nombre_Contacto asc ";

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

        

        public Int32 Eliminar(Inamu pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Alianza_Inamu] WHERE Id_Contacto = @Id_Contacto";
                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto", SqlDbType.Int).Value = pRegistro.Id_Contacto;
                    command.Parameters.Add("@Nombre_Contacto", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Correo_Inamu", SqlDbType.VarChar, 80).Value = pRegistro.Correo_Inamu;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = pRegistro.Telefono;
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
                string commandText = "DELETE [dbo].[Alianza_Inamu] ";

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

                string commandText = "SELECT [Id_Contacto] AS Id, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Inamu] AS Correo, [Telefono] AS Teléfono  FROM [dbo].[Alianza_Inamu] WHERE Id_Contacto = " + pCodigoL;

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

       

        public Inamu LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Inamu vRegistro = new Inamu();

                string commandText = "SELECT [Id_Contacto] AS Id, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Inamu] AS Correo, [Telefono] AS Teléfono  FROM [dbo].[Alianza_Inamu] WHERE Id_Contacto = " + pCodigoL;


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

                vRegistro.Id_Contacto = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Contacto = dtConsulta.Rows[0]["Nombre"].ToString();
                vRegistro.Nombre_Cargo = dtConsulta.Rows[0]["Cargo"].ToString();
                vRegistro.Nombre_Organizacion = dtConsulta.Rows[0]["Organización"].ToString();
                vRegistro.Correo_Inamu = dtConsulta.Rows[0]["Correo"].ToString();
                vRegistro.Telefono = dtConsulta.Rows[0]["Teléfono"].ToString();
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      


    }
}
