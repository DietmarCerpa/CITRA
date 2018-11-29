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
    public class Obf
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//

        public Int32 Insertar(AObf pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Alianza_Obf] VALUES (@Id_Contacto_Obf, @Nombre_Organizacion, @Nombre_Contacto, @Correo_Obf, @Telefono_Obf, @Telefono2) ";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Obf", SqlDbType.Int).Value = pRegistro.Id_Contacto_Obf;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Contacto", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto;
                    command.Parameters.Add("@Correo_Obf", SqlDbType.VarChar, 40).Value = pRegistro.Correo_Obf;
                    command.Parameters.Add("@Telefono_Obf", SqlDbType.VarChar, 9).Value = pRegistro.Telefono_Obf;
                    command.Parameters.Add("@Telefono2", SqlDbType.VarChar, 9).Value = pRegistro.Telefono2;
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

        public Int32 Modificar(AObf pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Alianza_Obf] " +
                                     "SET  Id_Contacto_Obf= @Id_Contacto_Obf, Nombre_Organizacion= @Nombre_Organizacion, Nombre_Contacto= @Nombre_Contacto, Correo_Obf= @Correo_Obf, Telefono_Obf= @Telefono_Obf, Telefono2= @Telefono2 "
                                     + "WHERE  Id_Contacto_Obf= @Id_Contacto_Obf";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Obf", SqlDbType.Int).Value = pRegistro.Id_Contacto_Obf;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Contacto", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto;
                    command.Parameters.Add("@Correo_Obf", SqlDbType.VarChar, 40).Value = pRegistro.Correo_Obf;
                    command.Parameters.Add("@Telefono_Obf", SqlDbType.VarChar, 9).Value = pRegistro.Telefono_Obf;
                    command.Parameters.Add("@Telefono2", SqlDbType.VarChar, 9).Value = pRegistro.Telefono2;
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

                string commandText = "SELECT [Id_Contacto_Obf] AS Id, [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Correo_Obf] AS Correo, [Telefono_Obf] AS Teléfono,  [Telefono2] AS Teléfono2 FROM [dbo].[Alianza_Obf] order by Nombre_Contacto asc";

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

        public Int32 Eliminar(AObf pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Alianza_Obf] WHERE Id_Contacto_Obf = @Id_Contacto_Obf";
                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Obf", SqlDbType.Int).Value = pRegistro.Id_Contacto_Obf;
                    command.Parameters.Add("@Nombre_Organizacion", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Organizacion;
                    command.Parameters.Add("@Nombre_Contacto", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Contacto;
                    command.Parameters.Add("@Correo_Obf", SqlDbType.VarChar, 40).Value = pRegistro.Correo_Obf;
                    command.Parameters.Add("@Telefono_Obf", SqlDbType.VarChar, 9).Value = pRegistro.Telefono_Obf;
                    command.Parameters.Add("@Telefono2", SqlDbType.VarChar, 9).Value = pRegistro.Telefono2;
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
                string commandText = "DELETE [dbo].[Alianza_Obf] ";

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

                string commandText = "SELECT [Id_Contacto_Obf] AS Id , [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Correo_Obf] AS Correo, [Telefono_Obf] AS Teléfono, [Telefono2] AS Teléfono2 FROM [dbo].[Alianza_Obf] WHERE Id_Contacto_Obf = " + pCodigoL;

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

        public AObf LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                AObf vRegistro = new AObf();

                string commandText = "SELECT [Id_Contacto_Obf] AS Id , [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Correo_Obf] AS Correo, [Telefono_Obf] AS Teléfono, [Telefono2] AS Teléfono2 FROM [dbo].[Alianza_Obf] WHERE Id_Contacto_Obf = " + pCodigoL;


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

                vRegistro.Id_Contacto_Obf = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Organizacion = dtConsulta.Rows[0]["Organización"].ToString();
                vRegistro.Nombre_Contacto = dtConsulta.Rows[0]["Nombre"].ToString();               
                vRegistro.Correo_Obf = dtConsulta.Rows[0]["Correo"].ToString();
                vRegistro.Telefono_Obf = dtConsulta.Rows[0]["Teléfono"].ToString();
                vRegistro.Telefono2 = dtConsulta.Rows[0]["Teléfono2"].ToString();
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
