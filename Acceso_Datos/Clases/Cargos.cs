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
    public class Cargos
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//

        public Int32 Insertar(Cargo pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Cargos] VALUES (@Id_Cargo,@Nombre_Cargo) ";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Cargo", SqlDbType.Int).Value = pRegistro.Id_Cargo;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
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

        public Int32 Modificar(Cargo pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Cargos] " +
                                     "SET  Id_Cargo= @Id_Cargo, Nombre_Cargo = @Nombre_Cargo "
                                     + "WHERE Id_Cargo = @Id_Cargo";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Cargo", SqlDbType.Int).Value = pRegistro.Id_Cargo;
                    command.Parameters.Add("@Nombre_Cargo", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Cargo;
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

                string commandText = "SELECT [Id_Cargo] AS Id, [Nombre_Cargo] AS Cargo FROM [dbo].[Cargos] Order by Nombre_Cargo asc ";

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

        public Int32 Eliminar(Cargo pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Cargos] WHERE Id_Cargo = @Id_Cargo";
                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Cargo", SqlDbType.Int).Value = pRegistro.Id_Cargo;
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
                string commandText = "DELETE [dbo].[Cargos] ";

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

                string commandText = "SELECT [Id_Cargo] AS Id, [Nombre_Cargo] AS Cargo FROM [dbo].[Cargos] WHERE Id_Cargo = " + pCodigoL;

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

        public Cargo LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Cargo vRegistro = new Cargo();

                string commandText = "SELECT [Id_Cargo] AS Id, [Nombre_Cargo] AS Cargo FROM [dbo].[Cargos] WHERE Id_Cargo = " + pCodigoL;


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

                vRegistro.Id_Cargo = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);               
                vRegistro.Nombre_Cargo = dtConsulta.Rows[0]["Cargo"].ToString();

                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region "Buscar"
        public DataTable LeerBuscar(string pCodigoL)
        {
            DataTable dtConsulta = new DataTable();

            try
            {

                string commandText = "SELECT [Id_Cargo] AS Id, [Nombre_Cargo] AS Cargo FROM [dbo].[Cargos] WHERE Nombre = " + pCodigoL;

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

        public Cargo LeerBuscar(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Cargo vRegistro = new Cargo();

                string commandText = "SELECT [Id_Cargo] AS Id, [Nombre_Cargo] AS Cargo FROM [dbo].[Cargos] WHERE Id_Cargo = " + pCodigoL;


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

                vRegistro.Id_Cargo = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Cargo = dtConsulta.Rows[0]["Cargo"].ToString();

                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion


    }
}
