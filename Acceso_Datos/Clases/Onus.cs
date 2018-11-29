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
    public class Onus
    {
        string vCadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;//

        public Int32 Insertar(Onu pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {

                string commandText = "INSERT INTO [dbo].[Regional_Onu] VALUES (@Id_Contacto_Regional, @Nombre_Pais, @Nombre_Director, @Telefono1, @Telefono2, @Adrr, @Telefono3, @Fax, @Direccion_Director) ";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Regional", SqlDbType.Int).Value = pRegistro.Id_Contacto_Regional;
                    command.Parameters.Add("@Nombre_Pais", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Pais;
                    command.Parameters.Add("@Nombre_Director", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Director;
                    command.Parameters.Add("@Telefono1", SqlDbType.VarChar, 25).Value = pRegistro.Telefono1;
                    command.Parameters.Add("@Telefono2", SqlDbType.VarChar, 25).Value = pRegistro.Telefono2;
                    command.Parameters.Add("@Adrr", SqlDbType.VarChar, 80).Value = pRegistro.Adrr;
                    command.Parameters.Add("@Telefono3", SqlDbType.VarChar, 25).Value = pRegistro.Telefono3;
                    command.Parameters.Add("@Fax", SqlDbType.VarChar, 25).Value = pRegistro.Fax;
                    command.Parameters.Add("@Direccion_Director", SqlDbType.VarChar, 200).Value = pRegistro.Direccion_Director;
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

        public Int32 Modificar(Onu pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "UPDATE [dbo].[Regional_Onu] " +
                                     "SET  Id_Contacto_Regional= @Id_Contacto_Regional, Nombre_Pais= @Nombre_Pais, Nombre_Director= @Nombre_Director, Telefono1= @Telefono1, Telefono2= @Telefono2, Adrr = @Adrr, Telefono3 = @Telefono3, Fax = @Fax, Direccion_Director= @Direccion_Director "
                                     + "WHERE Id_Contacto_Regional = @Id_Contacto_Regional";

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Regional", SqlDbType.Int).Value = pRegistro.Id_Contacto_Regional;
                    command.Parameters.Add("@Nombre_Pais", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Pais;
                    command.Parameters.Add("@Nombre_Director", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Director;
                    command.Parameters.Add("@Telefono1", SqlDbType.VarChar, 25).Value = pRegistro.Telefono1;
                    command.Parameters.Add("@Telefono2", SqlDbType.VarChar, 25).Value = pRegistro.Telefono2;
                    command.Parameters.Add("@Adrr", SqlDbType.VarChar, 80).Value = pRegistro.Adrr;
                    command.Parameters.Add("@Telefono3", SqlDbType.VarChar, 25).Value = pRegistro.Telefono3;
                    command.Parameters.Add("@Fax", SqlDbType.VarChar, 25).Value = pRegistro.Fax;
                    command.Parameters.Add("@Direccion_Director", SqlDbType.VarChar, 200).Value = pRegistro.Direccion_Director;
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

                string commandText = "SELECT [Id_Contacto_Regional] AS Id , [Nombre_Pais] AS País, [Nombre_Director] AS Nombre, [Telefono1] AS Teléfono, [Telefono2] AS Teléfono2, [Adrr] AS ARRDRR, [Telefono3] AS Teléfono3, [Fax] AS Fax, [Direccion_Director] AS Dirección  FROM [dbo].[Regional_Onu] order by Nombre_Pais asc";

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

        public Int32 Eliminar(Onu pRegistro)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string commandText = "DELETE [dbo].[Regional_Onu] WHERE Id_Contacto_Regional = @Id_Contacto_Regional";
                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.Add("@Id_Contacto_Regional", SqlDbType.Int).Value = pRegistro.Id_Contacto_Regional;
                    command.Parameters.Add("@Nombre_Pais", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Pais;
                    command.Parameters.Add("@Nombre_Director", SqlDbType.VarChar, 80).Value = pRegistro.Nombre_Director;
                    command.Parameters.Add("@Telefono1", SqlDbType.VarChar, 25).Value = pRegistro.Telefono1;
                    command.Parameters.Add("@Telefono2", SqlDbType.VarChar, 25).Value = pRegistro.Telefono2;
                    command.Parameters.Add("@Adrr", SqlDbType.VarChar, 80).Value = pRegistro.Adrr;
                    command.Parameters.Add("@Telefono3", SqlDbType.VarChar, 25).Value = pRegistro.Telefono3;
                    command.Parameters.Add("@Fax", SqlDbType.VarChar, 25).Value = pRegistro.Fax;
                    command.Parameters.Add("@Direccion_Director", SqlDbType.VarChar, 200).Value = pRegistro.Direccion_Director;
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
                string commandText = "DELETE [dbo].[Regional_Onu] ";

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

                string commandText = "SELECT [Id_Contacto_Regional] AS Id , [Nombre_Pais] AS País, [Nombre_Director] AS Nombre, [Telefono1] AS Teléfono, [Telefono2] AS Teléfono2, [Adrr] AS ARRDRR, [Telefono3] AS Teléfono3, [Fax] AS Fax, [Direccion_Director] AS Dirección  FROM [dbo].[Regional_Onu] WHERE Id_Contacto_Regional = " + pCodigoL;

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

        public Onu LeerCodigoLlave(Int32 pCodigoL)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Onu vRegistro = new Onu();

                string commandText = "SELECT [Id_Contacto_Regional] AS Id , [Nombre_Pais] AS País, [Nombre_Director] AS Nombre, [Telefono1] AS Teléfono, [Telefono2] AS Teléfono2, [Adrr] AS ARRDRR, [Telefono3] AS Teléfono3, [Fax] AS Fax, [Direccion_Director] AS Dirección  FROM [dbo].[Regional_Onu] WHERE Id_Contacto_Regional = " + pCodigoL;


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

                vRegistro.Id_Contacto_Regional = Convert.ToInt32(dtConsulta.Rows[0]["Id"]);
                vRegistro.Nombre_Pais = dtConsulta.Rows[0]["País"].ToString();
                vRegistro.Nombre_Director = dtConsulta.Rows[0]["Nombre"].ToString();
                vRegistro.Telefono1 = dtConsulta.Rows[0]["Teléfono"].ToString();
                vRegistro.Telefono2 = dtConsulta.Rows[0]["Teléfono2"].ToString();
                vRegistro.Adrr = dtConsulta.Rows[0]["ARRDRR"].ToString();
                vRegistro.Telefono3 = dtConsulta.Rows[0]["Teléfono3"].ToString();
                vRegistro.Fax = dtConsulta.Rows[0]["Fax"].ToString();
                vRegistro.Direccion_Director = dtConsulta.Rows[0]["Dirección"].ToString();
                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
