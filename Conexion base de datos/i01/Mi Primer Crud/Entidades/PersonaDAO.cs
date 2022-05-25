using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class PersonaDAO
    {
        private static string cadenaConexion;

        static PersonaDAO()
        {
            PersonaDAO.cadenaConexion = "Server=.;Database=i01;Trusted_Connection=True;";
        }

        public static List<Persona> LeerDatos()
        {
            List<Persona> datos = new List<Persona>();
            try
            {
                string query = "SELECT * FROM personas";
                using (SqlConnection connection = new SqlConnection(PersonaDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        Persona p = new Persona(id, nombre, apellido);
                        datos.Add(p);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return datos;
        }

        public static Persona LeerDatosPorId(int id)
        {
            Persona persona = null;
            string datos = string.Empty;

            string query = "select * from personas where id = @id";          // ese @ hace referencia al id de la linea 57
            using (SqlConnection connection = new SqlConnection(PersonaDAO.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();                                            // abro la conexion
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())                                         // lee fila por fila
                {
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);

                    persona = new Persona(id, nombre, apellido);


                }

            }
            return persona;
        }

        public static void Guardar(Persona p)
        {
            string query = "INSERT INTO personas(nombre, apellido) values(@nombre, @apellido)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(PersonaDAO.cadenaConexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("nombre", p.Nombre);
                cmd.Parameters.AddWithValue("apellido", p.Apellido);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static void Borrar(int id)
        {
            List<Persona> datos = new List<Persona>();
            try
            {
                string query = "DELETE FROM personas WHERE id=@id";
                using (SqlConnection connection = new SqlConnection(PersonaDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Modificar(int id, Persona persona)
        {
            List<Persona> datos = new List<Persona>();
            try
            {
                string query = "update personas set nombre=@nombre, apellido=@apellido where id = @id";
                using (SqlConnection connection = new SqlConnection(PersonaDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("nombre", persona.Nombre);
                    cmd.Parameters.AddWithValue("apellido", persona.Apellido);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
