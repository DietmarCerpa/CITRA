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
    public class Rblacs
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//

        public Int32 Insertar(Rblac pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Rblac] VALUES (@Id_Rblac, @Nombre_Rblac, @Nombre_Departamento, @Nombre_Cargo, @Ubicacion, @Extension ) ";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Rblac", SqlDbType.Int).Value = pRegistro.Id_Rblac;
                    command.Parameters.Add("@Nombre_Rblac", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Rblac;
                    command.Parameters.Add("@Nombre_Departamento", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Departamento;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 9).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 8).Value = pRegistro.Ubicacion;
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

        public Int32 Modificar(Rblac pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Rblac] " +
                                     "SET  Id_Rblac= @Id_Rblac, Nombre_Rblac= @Nombre_Rblac, Nombre_Departamento= @Nombre_Departamento, Nombre_Cargo = @Nombre_Cargo, Ubicacion= @Ubicacion, Extension= @Extension  "
                                     + "WHERE  Id_Rblac= @Id_Rblac";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Rblac", SqlDbType.Int).Value = pRegistro.Id_Rblac;
                    command.Parameters.Add("@Nombre_Rblac", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Rblac;
                    command.Parameters.Add("@Nombre_Departamento", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Departamento;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 8).Value = pRegistro.Ubicacion;
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

                string commandText = "SELECT [Id_Rblac] AS Id, [Nombre_Rblac] AS Nombre, [Nombre_Departamento] AS Departamento, [Nombre_Cargo] AS Cargo, [Ubicacion] AS Ubicación, [Extension] AS Extensión FROM [dbo].[Rblac] order by Nombre_Rblac asc";

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

        public Int32 Eliminar(Rblac pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Rblac] WHERE Id_Rblac = @Id_Rblac";
                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Rblac", SqlDbType.Int).Value = pRegistro.Id_Rblac;
                    command.Parameters.Add("@Nombre_Rblac", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Rblac;
                    command.Parameters.Add("@Nombre_Departamento", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Departamento;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
                    command.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 8).Value = pRegistro.Ubicacion;
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
                string commandText = "DELETE [dbo].[Rblac] ";

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

                string commandText = "SELECT [Id_Rblac] AS Id, [Nombre_Rblac] AS Nombre, [Nombre_Departamento] AS Departamento, [Nombre_Cargo] AS Cargo, [Ubicacion] AS Ubicación, [Extension] AS Extensión FROM [dbo].[Rblac] WHERE Id_Rblac = " + pCodigoL;

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

        public Rblac LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Rblac vRegistro = new Rblac();

                string commandText = "SELECT [Id_Rblac] AS Id, [Nombre_Rblac] AS Nombre, [Nombre_Departamento] AS Departamento, [Nombre_Cargo] AS Cargo, [Ubicacion] AS Ubicación, [Extension] AS Extensión FROM [dbo].[Rblac] WHERE Id_Rblac = " + pCodigoL;


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

                vRegistro.Id_Rblac = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Rblac = dtConsulta.Rows[0]["Nombre"].ToString();
                vRegistro.Nombre_Departamento = dtConsulta.Rows[0]["Departamento"].ToString();
                vRegistro.Nombre_Cargo = dtConsulta.Rows[0]["Cargo"].ToString();
                vRegistro.Ubicacion = dtConsulta.Rows[0]["Ubicación"].ToString();
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
