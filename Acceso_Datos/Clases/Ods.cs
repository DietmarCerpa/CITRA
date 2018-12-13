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
    public class Ods
    {
        static string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//
        SqlConnection connection = new SqlConnection(vCadenaConexion);
        public Int32 Insertar(AOds pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Alianza_Ods] VALUES (@Id_Contacto_Ods, @Nombre_Organizacion, @Nombre_Contacto, @Nombre_Cargo, @Correo_Ods, @Telefono, @Telefono2, @Nombre_Sector) ";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Ods", SqlDbType.Int).Value = pRegistro.Id_Contacto_Ods;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Contacto", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Correo_Ods", SqlDbType.VarChar, 40).Value = pRegistro.Correo_Ods;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = pRegistro.Telefono;
                    command.Parameters.Add("@Telefono2", SqlDbType.VarChar, 9).Value = pRegistro.Telefono2;
                    command.Parameters.Add("@Nombre_Sector", SqlDbType.VarChar, 20).Value = pRegistro.Nombre_Sector;
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

        public Int32 Modificar(AOds pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Alianza_Ods] " +
                                     "SET  Id_Contacto_Ods= @Id_Contacto_Ods, Nombre_Organizacion= @Nombre_Organizacion, Nombre_Contacto= @Nombre_Contacto, Nombre_Cargo= @Nombre_Cargo, Correo_Ods= @Correo_Ods, Telefono= @Telefono, Telefono2= @Telefono2, Nombre_Sector= @Nombre_Sector "
                                     + "WHERE  Id_Contacto_Ods= @Id_Contacto_Ods";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Ods", SqlDbType.Int).Value = pRegistro.Id_Contacto_Ods;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Contacto", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Correo_Ods", SqlDbType.VarChar, 40).Value = pRegistro.Correo_Ods;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = pRegistro.Telefono;
                    command.Parameters.Add("@Telefono2", SqlDbType.VarChar, 9).Value = pRegistro.Telefono2;
                    command.Parameters.Add("@Nombre_Sector", SqlDbType.VarChar, 20).Value = pRegistro.Nombre_Sector;
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

                string commandText = "SELECT [Id_Contacto_Ods] AS Id, [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Correo_Ods] AS Correo, [Telefono] AS Teléfono,  [Telefono2] AS Teléfono2, [Nombre_Sector] AS Sector  FROM [dbo].[Alianza_Ods] order by Nombre_Contacto asc";

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

        public Int32 Eliminar(AOds pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Alianza_Ods] WHERE Id_Contacto_Ods = @Id_Contacto_Ods";
                using (connection)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Ods", SqlDbType.Int).Value = pRegistro.Id_Contacto_Ods;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Contacto", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Correo_Ods", SqlDbType.VarChar, 40).Value = pRegistro.Correo_Ods;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = pRegistro.Telefono;
                    command.Parameters.Add("@Telefono2", SqlDbType.VarChar, 9).Value = pRegistro.Telefono2;
                    command.Parameters.Add("@Nombre_Sector", SqlDbType.VarChar, 20).Value = pRegistro.Nombre_Sector;
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
                string commandText = "DELETE [dbo].[Alianza_Ods] ";

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

                string commandText = "SELECT [Id_Contacto_Ods] AS Id , [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Correo_Ods] AS Correo, [Telefono] AS Teléfono,  [Telefono2] AS Teléfono2, [Nombre_Sector] AS Sector  FROM [dbo].[Alianza_Ods] WHERE Id_Contacto_Ods = " + pCodigoL;

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

        public AOds LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                AOds vRegistro = new AOds();

                string commandText = "SELECT [Id_Contacto_Ods] AS Id , [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Correo_Ods] AS Correo, [Telefono] AS Teléfono,  [Telefono2] AS Teléfono2, [Nombre_Sector] AS Sector  FROM [dbo].[Alianza_Ods] WHERE Id_Contacto_Ods = " + pCodigoL;


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

                vRegistro.Id_Contacto_Ods = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Organizacion = dtConsulta.Rows[0]["Organización"].ToString();
                vRegistro.Nombre_Contacto = dtConsulta.Rows[0]["Nombre"].ToString();
                vRegistro.Nombre_Cargo = dtConsulta.Rows[0]["Cargo"].ToString();
                vRegistro.Correo_Ods = dtConsulta.Rows[0]["Correo"].ToString();
                vRegistro.Telefono = dtConsulta.Rows[0]["Teléfono"].ToString();
                vRegistro.Telefono2 = dtConsulta.Rows[0]["Teléfono2"].ToString();
                vRegistro.Nombre_Sector = dtConsulta.Rows[0]["Sector"].ToString();
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
