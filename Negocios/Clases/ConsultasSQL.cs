using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Negocios
{
    public class ConsultasSQL
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        private DataSet ds;

        #region "Buscar Cargos y Campo sugerido"
        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Cargo] AS Id, [Nombre_Cargo] AS Cargo FROM [dbo].[Cargos]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable Buscar(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Cargo] AS Id, [Nombre_Cargo] AS Cargo FROM [dbo].[Cargos] where Nombre_Cargo like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSCargo()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Cargo)+ 1 AS 'Campo Sugerido' FROM [dbo].[Cargos]") , conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }


        #endregion

        #region "Buscar Departamentos"
        public DataTable MostrarDatosDepartamentos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Departamento] AS Id, [Nombre_Departamento] AS Departamento FROM [dbo].[Departamentos]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarDepartamentos(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Departamento] AS Id, [Nombre_Departamento] AS Departamento FROM [dbo].[Departamentos] WHERE Nombre_Departamento like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSDepartamento()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Departamento)+ 1 AS 'Campo Sugerido' FROM [dbo].[Departamentos]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

        #region "Buscar Países"
        public DataTable MostrarDatosPaises()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Pais] AS Id, [Nombre_Pais] AS País FROM [dbo].[Paises]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarPaises(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Pais] AS Id, [Nombre_Pais] AS País FROM [dbo].[Paises] WHERE Nombre_Pais like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSPais()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Pais)+ 1 AS 'Campo Sugerido' FROM [dbo].[Paises]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        #endregion

        #region "Buscar Organizaciones"
        public DataTable MostrarDatosOrganizaciones()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Organizacion] AS Id, [Nombre_Organizacion] AS Organización FROM [dbo].[Organizaciones]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarOrganizaciones(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Organizacion] AS Id, [Nombre_Organizacion] AS Organización FROM [dbo].[Organizaciones] WHERE Nombre_Organizacion like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSOrganizacion()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Organizacion)+ 1 AS 'Campo Sugerido' FROM [dbo].[Organizaciones]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

        #region "Buscar Alianza Sinirube"
        public DataTable MostrarDatosSinirube()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Contacto_Sinirube] AS Id , [Nombre_Contacto_Sinirube] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Sinirube] AS Correo  FROM [dbo].[Alianza_Sinirube]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarSinirubeNombre(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Sinirube] AS Id , [Nombre_Contacto_Sinirube] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Sinirube] AS Correo  FROM [dbo].[Alianza_Sinirube] WHERE Nombre_Contacto_Sinirube like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarSinirubeCargo(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Sinirube] AS Id , [Nombre_Contacto_Sinirube] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Sinirube] AS Correo  FROM [dbo].[Alianza_Sinirube] WHERE Nombre_Cargo like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarSinirubeOrganizacion(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Sinirube] AS Id , [Nombre_Contacto_Sinirube] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Sinirube] AS Correo  FROM [dbo].[Alianza_Sinirube] WHERE Nombre_Organizacion like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSSinirube()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Contacto_Sinirube)+ 1 AS 'Campo Sugerido' FROM [dbo].[Alianza_Sinirube]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        #endregion

        #region "Buscar Cámaras Privadas"
        public DataTable MostrarDatosCamaras()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Contacto_Camara] AS Id, [Nombre_Contacto_Camara] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Cargo] AS Cargo, [Correo_Camara] AS Correo , [Telefono] AS Teléfono, [Extension] AS Extensión FROM [dbo].[Camaras_Privadas]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarCamaraNombre(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Camara] AS Id, [Nombre_Contacto_Camara] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Cargo] AS Cargo, [Correo_Camara] AS Correo , [Telefono] AS Teléfono, [Extension] AS Extensión FROM [dbo].[Camaras_Privadas] WHERE Nombre_Contacto_Camara like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarCamaraCargo(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Camara] AS Id ,[Nombre_Contacto_Camara] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Cargo] AS Cargo, [Correo_Camara] AS Correo , [Telefono] AS Teléfono, [Extension] AS Extensión FROM [dbo].[Camaras_Privadas] WHERE Nombre_Cargo like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarCamaraOrganizacion(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Camara] AS Id, [Nombre_Contacto_Camara] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Cargo] AS Cargo, [Correo_Camara] AS Correo , [Telefono] AS Teléfono, [Extension] AS Extensión FROM [dbo].[Camaras_Privadas] WHERE Nombre_Organizacion like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSCamaraPrivada()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Contacto_Camara)+ 1 AS 'Campo Sugerido' FROM [dbo].[Camaras_Privadas]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

        #region "Buscar Alianza ODS"
        public DataTable MostrarDatosOds()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Contacto_Ods] AS Id , [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Correo_Ods] AS Correo, [Telefono] AS Teléfono,  [Telefono2] AS Teléfono2, [Nombre_Sector] AS Sector  FROM [dbo].[Alianza_Ods]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarOdsNombre(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Ods] AS Id , [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Correo_Ods] AS Correo, [Telefono] AS Teléfono,  [Telefono2] AS Teléfono2, [Nombre_Sector] AS Sector  FROM [dbo].[Alianza_Ods] WHERE Nombre_Contacto like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarOdsOrganizacion(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Ods] AS Id , [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Correo_Ods] AS Correo, [Telefono] AS Teléfono,  [Telefono2] AS Teléfono2, [Nombre_Sector] AS Sector  FROM [dbo].[Alianza_Ods] WHERE Nombre_Organizacion like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarOdsCargo(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Ods] AS Id , [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Correo_Ods] AS Correo, [Telefono] AS Teléfono,  [Telefono2] AS Teléfono2, [Nombre_Sector] AS Sector  FROM [dbo].[Alianza_Ods] WHERE Nombre_Cargo like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSOds()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Contacto_Ods)+ 1 AS 'Campo Sugerido' FROM [dbo].[Alianza_Ods]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

        #region "Buscar Sectores"
        public DataTable MostrarDatosSectores()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Sector] AS Id, [Nombre_Sector] AS Sector FROM [dbo].[Sectores]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarSectores(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Sector] AS Id, [Nombre_Sector] AS Sector FROM [dbo].[Sectores] WHERE Nombre_Sector like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSSector()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Sector)+ 1 AS 'Campo Sugerido' FROM [dbo].[Sectores]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        #endregion

        #region "Buscar Socios Estratégicos"
        public DataTable MostrarDatosSocios()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Socio] AS Id , [Nombre_Socio] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Socio] AS Correo  FROM [dbo].[Socios_Estrategicos]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarSocioNombre(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Socio] AS Id , [Nombre_Socio] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Socio] AS Correo  FROM [dbo].[Socios_Estrategicos] WHERE Nombre_Socio like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarSocioOrganizacion(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Socio] AS Id , [Nombre_Socio] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Socio] AS Correo  FROM [dbo].[Socios_Estrategicos] WHERE Nombre_Organizacion like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarSocioCargo(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Socio] AS Id , [Nombre_Socio] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Socio] AS Correo  FROM [dbo].[Socios_Estrategicos] WHERE Nombre_Cargo like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSSocio()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Socio)+ 1 AS 'Campo Sugerido' FROM [dbo].[Socios_Estrategicos]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion 

        #region "Buscar Círculos Sociales"
        public DataTable MostrarDatosCirculos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Circulo] AS Id, [Nombre_Circulo] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Departamento] AS Departamento, [Correo_Circulo] AS Correo  FROM [dbo].[Circulos_Sociales]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarCirculoNombre(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Circulo] AS Id, [Nombre_Circulo] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Departamento] AS Departamento, [Correo_Circulo] AS Correo  FROM [dbo].[Circulos_Sociales] WHERE Nombre_Circulo like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarCirculoOrganizacion(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Circulo] AS Id, [Nombre_Circulo] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Departamento] AS Departamento, [Correo_Circulo] AS Correo  FROM [dbo].[Circulos_Sociales] WHERE Nombre_Organizacion like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarCirculoDepartamento(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Circulo] AS Id, [Nombre_Circulo] AS Nombre, [Nombre_Organizacion] AS Organización, [Nombre_Departamento] AS Departamento, [Correo_Circulo] AS Correo  FROM [dbo].[Circulos_Sociales] WHERE Nombre_Departamento like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSCirculo()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Circulo)+ 1 AS 'Campo Sugerido' FROM [dbo].[Circulos_Sociales]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

        #region "Buscar OBF"
        public DataTable MostrarDatosObf()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Contacto_Obf] AS Id, [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Correo_Obf] AS Correo, [Telefono_Obf] AS Teléfono,  [Telefono2] AS Teléfono2 FROM [dbo].[Alianza_Obf]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarObfNombre(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Obf] AS Id, [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Correo_Obf] AS Correo, [Telefono_Obf] AS Teléfono,  [Telefono2] AS Teléfono2 FROM [dbo].[Alianza_Obf] WHERE Nombre_Contacto like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarObfOrganizacion(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Obf] AS Id, [Nombre_Organizacion] AS Organización, [Nombre_Contacto] AS Nombre, [Correo_Obf] AS Correo, [Telefono_Obf] AS Teléfono,  [Telefono2] AS Teléfono2 FROM [dbo].[Alianza_Obf] WHERE Nombre_Organizacion like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSObf()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Contacto_Obf)+ 1 AS 'Campo Sugerido' FROM [dbo].[Alianza_Obf]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        #endregion

        #region "Buscar Alianza Inamu"
        public DataTable MostrarDatosInamu()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Contacto] AS Id, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Inamu] AS Correo, [Telefono] AS Teléfono  FROM [dbo].[Alianza_Inamu]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarInamuNombre(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto] AS Id, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Inamu] AS Correo, [Telefono] AS Teléfono  FROM [dbo].[Alianza_Inamu] WHERE Nombre_Contacto like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarInamuOrganizacion(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto] AS Id, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Inamu] AS Correo, [Telefono] AS Teléfono  FROM [dbo].[Alianza_Inamu] WHERE Nombre_Organizacion like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarInamuCargo(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto] AS Id, [Nombre_Contacto] AS Nombre, [Nombre_Cargo] AS Cargo, [Nombre_Organizacion] AS Organización, [Correo_Inamu] AS Correo, [Telefono] AS Teléfono  FROM [dbo].[Alianza_Inamu] WHERE Nombre_Cargo like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSInamu()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Contacto)+ 1 AS 'Campo Sugerido' FROM [dbo].[Alianza_Inamu]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

        #region "Buscar Rblac"
        public DataTable MostrarDatosRblac()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Rblac] AS Id, [Nombre_Rblac] AS Nombre, [Nombre_Departamento] AS Departamento, [Nombre_Cargo] AS Cargo, [Ubicacion] AS Ubicación, [Extension] AS Extensión FROM [dbo].[Rblac]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarRblacNombre(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Rblac] AS Id, [Nombre_Rblac] AS Nombre, [Nombre_Departamento] AS Departamento, [Nombre_Cargo] AS Cargo, [Ubicacion] AS Ubicación, [Extension] AS Extensión FROM [dbo].[Rblac] WHERE Nombre_Rblac like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarRblacDepartamento(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Rblac] AS Id, [Nombre_Rblac] AS Nombre, [Nombre_Departamento] AS Departamento, [Nombre_Cargo] AS Cargo, [Ubicacion] AS Ubicación, [Extension] AS Extensión FROM [dbo].[Rblac] WHERE Nombre_Departamento like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarRblacCargo(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Rblac] AS Id, [Nombre_Rblac] AS Nombre, [Nombre_Departamento] AS Departamento, [Nombre_Cargo] AS Cargo, [Ubicacion] AS Ubicación, [Extension] AS Extensión FROM [dbo].[Rblac] WHERE Nombre_Cargo like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSRblac()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Rblac)+ 1 AS 'Campo Sugerido' FROM [dbo].[Rblac]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        #endregion

        #region "Buscar Usuarios"
        public DataTable MostrarDatosUsuario()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Usuario] AS Id, [Nombre_Persona] AS Nombre, [Cedula] AS Cédula, [Roles] AS Rol, [Email] AS Correo, [Nombre_Usuario] AS Usuario, [Contraseña] AS Contraseña  FROM [dbo].[Usuarios]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarUsuarioNombre(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Usuario] AS Id, [Nombre_Persona] AS Nombre, [Cedula] AS Cédula, [Roles] AS Rol, [Email] AS Correo, [Nombre_Usuario] AS Usuario, [Contraseña] AS Contraseña  FROM [dbo].[Usuarios] WHERE Nombre_Persona like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarUsuarioRol(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Usuario] AS Id, [Nombre_Persona] AS Nombre, [Cedula] AS Cédula, [Roles] AS Rol, [Email] AS Correo, [Nombre_Usuario] AS Usuario, [Contraseña] AS Contraseña  FROM [dbo].[Usuarios] WHERE Roles like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarUsuarioCedula(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Usuario] AS Id, [Nombre_Persona] AS Nombre, [Cedula] AS Cédula, [Roles] AS Rol, [Email] AS Correo, [Nombre_Usuario] AS Usuario, [Contraseña] AS Contraseña  FROM [dbo].[Usuarios] WHERE Cedula like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarUsuarioUsuario(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Usuario] AS Id, [Nombre_Persona] AS Nombre, [Cedula] AS Cédula, [Roles] AS Rol, [Email] AS Correo, [Nombre_Usuario] AS Usuario, [Contraseña] AS Contraseña  FROM [dbo].[Usuarios] WHERE Nombre_Usuario like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSUsuario()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Usuario)+ 1 AS 'Campo Sugerido' FROM [dbo].[Usuarios]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        #endregion

        #region "Buscar Permisos y  Módulos"
        public DataTable MostrarDatosPermisos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [id] AS Id, [nombre] AS Nombre FROM [dbo].[Permisos]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable MostrarDatosModulos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [id] AS Id, [nombre] AS Nombre FROM [dbo].[Modulos]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

        #region "Buscar Roles"
        public DataTable MostrarDatosRoles()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Rol] AS Id, [Nombre_Rol] AS Nombre, [Nivel] AS Nivel FROM [dbo].[Rol]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarRol(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Rol] AS Id, [Nombre_Rol] AS Nombre, [Nivel] AS Nivel  FROM [dbo].[Rol] WHERE Nombre_Rol like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSRol()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Rol)+ 1 AS 'Campo Sugerido' FROM [dbo].[Rol]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

        #region "Buscar Permisos x Rol"
        public DataTable MostrarDatosPermisoxRol()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [id_Rol] AS Rol, [id_Permiso] AS Permiso FROM [dbo].[Permisos_x_Rol]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarRolxPermiso(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [id_Rol] AS Rol, [id_Permiso] AS Permiso FROM [dbo].[Permisos_x_Rol] WHERE id_Rol like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarPermisoxRol(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [id_Rol] AS Rol, [id_Permiso] AS Permiso FROM [dbo].[Permisos_x_Rol] WHERE id_Permiso like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }



        #endregion

        #region "Buscar Regional ONU"
        public DataTable MostrarDatosOnu()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Contacto_Regional] AS Id , [Nombre_Pais] AS País, [Nombre_Director] AS Nombre, [Telefono1] AS Teléfono, [Telefono2] AS Teléfono2, [Adrr] AS ARRDRR, [Telefono3] AS Teléfono3, [Fax] AS Fax, [Direccion_Director] AS Dirección  FROM [dbo].[Regional_Onu]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarOnuNombre(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Regional] AS Id , [Nombre_Pais] AS País, [Nombre_Director] AS Nombre, [Telefono1] AS Teléfono, [Telefono2] AS Teléfono2, [Adrr] AS ARRDRR, [Telefono3] AS Teléfono3, [Fax] AS Fax, [Direccion_Director] AS Dirección  FROM [dbo].[Regional_Onu] WHERE Nombre_Director like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarOnuPais(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Regional] AS Id , [Nombre_Pais] AS País, [Nombre_Director] AS Nombre, [Telefono1] AS Teléfono, [Telefono2] AS Teléfono2, [Adrr] AS ARRDRR, [Telefono3] AS Teléfono3, [Fax] AS Fax, [Direccion_Director] AS Dirección  FROM [dbo].[Regional_Onu] WHERE Nombre_Pais like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarOnuAdrr(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Contacto_Regional] AS Id , [Nombre_Pais] AS País, [Nombre_Director] AS Nombre, [Telefono1] AS Teléfono, [Telefono2] AS Teléfono2, [Adrr] AS ARRDRR, [Telefono3] AS Teléfono3, [Fax] AS Fax, [Direccion_Director] AS Dirección  FROM [dbo].[Regional_Onu] WHERE Adrr like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable CSOnu()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT (Id_Contacto_Regional)+ 1 AS 'Campo Sugerido' FROM [dbo].[Regional_Onu]"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

        #region "Bitácora Sucesos"
        public DataTable MostrarDatosSucesos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Tipo_Transaccion] AS Transacción, [Tabla_Afectada] AS Tabla, [Fecha] AS Fecha, [Id_Registro] AS Id, [Nombre_Registro] AS Registro FROM [dbo].[Bitacora_Sucesos]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarTransaccion(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Tipo_Transaccion] AS Transacción, [Tabla_Afectada] AS Tabla, [Fecha] AS Fecha, [Id_Registro] AS Id, [Nombre_Registro] AS Registro FROM [dbo].[Bitacora_Sucesos] WHERE Tipo_Transaccion like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarTabla(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Tipo_Transaccion] AS Transacción, [Tabla_Afectada] AS Tabla, [Fecha] AS Fecha, [Id_Registro] AS Id, [Nombre_Registro] AS Registro FROM [dbo].[Bitacora_Sucesos] WHERE Tabla_Afectada like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarFecha(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Tipo_Transaccion] AS Transacción, [Tabla_Afectada] AS Tabla, [Fecha] AS Fecha, [Id_Registro] AS Id, [Nombre_Registro] AS Registro FROM [dbo].[Bitacora_Sucesos] WHERE Fecha like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion
        #region "Bitacora Entradas/Salidas"
        public DataTable MostrarDatosES()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Id_Usuario] AS ID_Usuario,[Fecha] AS Fecha, [Tipo_Transaccion] AS Tipo_Transaccion FROM [dbo].[Bitacora_ES]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
            public DataTable BuscarIDUsuario(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Usuario] AS ID_Usuario,[Fecha] AS Fecha, [Tipo_Transaccion] AS Tipo_Transaccion FROM [dbo].[Bitacora_ES] WHERE Id_Usuario like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public DataTable BuscarFechaES(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Usuario] AS ID_Usuario,[Fecha] AS Fecha, [Tipo_Transaccion] AS Tipo_Transaccion FROM [dbo].[Bitacora_ES] WHERE CONVERT(VARCHAR(25), Fecha, 126) LIKE '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public DataTable BuscarTransaccionES(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [Id_Usuario] AS ID_Usuario,[Fecha] AS Fecha, [Tipo_Transaccion] AS Tipo_Transaccion FROM [dbo].[Bitacora_ES] WHERE Tipo_Transaccion like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

        #region "Buscar Permisos por Modulo"

        public DataTable MostrarPermisoModulo()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT [id_Rol] AS Rol, [id_Modulo] AS Módulo FROM [dbo].[Permisos_x_Modulo]", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarRolModulo(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [id_Rol] AS Rol, [id_Modulo] AS Módulo FROM [dbo].[Permisos_x_Modulo] WHERE id_Rol like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarModuloRol(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT [id_Rol] AS Rol, [id_Modulo] AS Módulo FROM [dbo].[Permisos_x_Modulo] WHERE id_Modulo like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        #endregion

    }
}
