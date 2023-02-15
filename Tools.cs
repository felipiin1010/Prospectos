using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospectos
{
    static class Connexion
    {
        static string connectionString = "Data Source=10.10.9.15;Initial Catalog=VacacionesPruebas;User ID=sa;Password=pepeeltoro1#";

        public static Perfil Acceso(string @usuario, string @clave)
        {
            Perfil p = null;
            using (System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Acceso", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", @usuario);
                    cmd.Parameters.AddWithValue("@clave", @clave);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {                        
                        while (reader.Read())
                        {
                            p = new Perfil( Convert.ToInt32(reader[0].ToString()), reader[1].ToString());
                        }
                    }
                }
            }
            return p;
        }

        public static int GuardarProspecto(string @nombre, string @app, string @apm, string @calle, string @numero, string @colonia, string @cp, string @tel, string @rfc, int @usuario)
        {
            using (System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Insertaprospecto", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", @nombre);
                    cmd.Parameters.AddWithValue("@app", @app);
                    cmd.Parameters.AddWithValue("@apm", @apm);
                    cmd.Parameters.AddWithValue("@calle", @calle);
                    cmd.Parameters.AddWithValue("@numero", @numero);
                    cmd.Parameters.AddWithValue("@colonia", @colonia);
                    cmd.Parameters.AddWithValue("@cp", @cp);
                    cmd.Parameters.AddWithValue("@tel", @tel);
                    cmd.Parameters.AddWithValue("@rfc", @rfc);
                    cmd.Parameters.AddWithValue("@usuario", @usuario);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return Convert.ToInt32(reader[0].ToString());
                        }
                    }
                }
            }
            return 0;
        }
        public static DataTable MostrarProspectos(int @usuario)
        {
            using (System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Muestraprospectos", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", @usuario);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("Nombre", typeof(string));
                        dataTable.Columns.Add("app", typeof(string));
                        dataTable.Columns.Add("apm", typeof(string));
                        dataTable.Columns.Add("Estatus", typeof(string));
                        dataTable.Columns.Add("id", typeof(int));

                        while (reader.Read())
                        {
                            DataRow row = dataTable.NewRow();
                            row["Nombre"] = reader["Nombre"].ToString();
                            row["app"] = reader["app"].ToString();
                            row["apm"] = reader["apm"].ToString();
                            row["Estatus"] = reader["Estatus"].ToString();
                            row["id"] = Convert.ToInt32(reader["id"]);
                            dataTable.Rows.Add(row);
                        }
                        return dataTable;
                    }
                }
            }
            return null;
        }
         public static DataTable EvaluarProspectos(int @usuario)
        {
            using (System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("EvaluarProspectos", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("Nombre", typeof(string));
                        dataTable.Columns.Add("appaterno", typeof(string));
                        dataTable.Columns.Add("apmaterno", typeof(string));
                        dataTable.Columns.Add("calle", typeof(string));
                        dataTable.Columns.Add("numero", typeof(string));
                        dataTable.Columns.Add("colonia", typeof(string));
                        dataTable.Columns.Add("codigopostal", typeof(string));
                        dataTable.Columns.Add("telefono", typeof(string));
                        dataTable.Columns.Add("rfc", typeof(string));
                        dataTable.Columns.Add("id", typeof(int));


                        while (reader.Read())
                        {
                            DataRow row = dataTable.NewRow();
                            row["Nombre"] = reader["Nombre"].ToString();
                            row["appaterno"] = reader["appaterno"].ToString();
                            row["apmaterno"] = reader["apmaterno"].ToString();
                            row["calle"] = reader["calle"].ToString();
                            row["numero"] = reader["numero"].ToString();
                            row["colonia"] = reader["colonia"].ToString();
                            row["codigopostal"] = reader["codigopostal"].ToString();
                            row["telefono"] = reader["telefono"].ToString();
                            row["rfc"] = reader["rfc"].ToString();
                            row["id"] = reader["id"].ToString();
                            dataTable.Rows.Add(row);
                        }
                        return dataTable;
                    }
                }
            }
            return null;
        }
       public static DataTable MostrarProspecto(int @prospectoid, int @usuario)
        {
            using (System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Muestraprospecto", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", @usuario);
                    cmd.Parameters.AddWithValue("@prospectoid", @prospectoid);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("Nombre", typeof(string));
                        dataTable.Columns.Add("prospectoId", typeof(string));
                        dataTable.Columns.Add("appaterno", typeof(string));
                        dataTable.Columns.Add("apmaterno", typeof(string));
                        dataTable.Columns.Add("calle", typeof(string));
                        dataTable.Columns.Add("numero", typeof(string));
                        dataTable.Columns.Add("colonia", typeof(string));
                        dataTable.Columns.Add("codigopostal", typeof(string));
                        dataTable.Columns.Add("telefono", typeof(string));
                        dataTable.Columns.Add("rfc", typeof(string));

                        dataTable.Columns.Add("estatus", typeof(string));
                        dataTable.Columns.Add("usuarioid", typeof(string));
                        dataTable.Columns.Add("observaciones", typeof(string));

                        while (reader.Read())
                        {
                            DataRow row = dataTable.NewRow();
                            row["prospectoId"] = reader["prospectoId"].ToString();
                            row["nombre"] = reader["nombre"].ToString();
                            row["appaterno"] = reader["appaterno"].ToString();
                            row["apmaterno"] = reader["apmaterno"].ToString();
                            row["calle"] = reader["calle"].ToString();
                            row["numero"] = reader["numero"].ToString();
                            row["colonia"] = reader["colonia"].ToString();
                            row["codigopostal"] = reader["codigopostal"].ToString();
                            row["telefono"] = reader["telefono"].ToString();
                            row["rfc"] = reader["rfc"].ToString();
                            row["estatus"] = reader["estatus"].ToString();
                            row["usuarioid"] = reader["usuarioid"].ToString();
                            row["observaciones"] = reader["observaciones"].ToString();
                            dataTable.Rows.Add(row);
                        }
                        return dataTable;
                    }
                }
            }
            return null;
        }
        public static List<string> MostrarDocumentos(int @prospectoid, int @usuario)
        {
            using (System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                List<string> lista = new System.Collections.Generic.List<string>();
                using (SqlCommand cmd = new SqlCommand("MuestraDocumento", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", @usuario);
                    cmd.Parameters.AddWithValue("@prospectoid", @prospectoid);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(reader["ruta"].ToString());
                        }
                        return lista;
                    }
                }
            }
            return null;
        }
        public static void GuardarDocumentos(string @prospecto,string rutas/*"_"*/ )
        {
            using (System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Insertadocumento", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prospectoid", @prospecto);
                    cmd.Parameters.AddWithValue("@rutas", @rutas);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void GuardarEstatus(string @prospecto, string @estatus,string @observaciones=null)
        {
            using (System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GuardarEstatus", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prospectoid",Convert.ToInt32(@prospecto));
                    cmd.Parameters.AddWithValue("@estatus", Convert.ToInt32(@estatus));
                if(@observaciones !=null)
                    cmd.Parameters.AddWithValue("@observaciones", @observaciones);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
    public class Perfil
    {
        //public enum tipoPerfil { promotor, evaluacion }
        private int id;
        private string perfil;

        public Perfil(int i, string p)
        {
            id = i;
            perfil = p;
        }
        public string GetPerfil()
        {
            return perfil;
        }
        public int GetUsuario()
        {
            return id;
        }
    }
    public class Item
    {
        public int id { get; set; }
        public string valor { get; set; }
    }

}
