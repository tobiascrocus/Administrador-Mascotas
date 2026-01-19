using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases_IEFI
{
    public class Mascota
    {
        string cadenaConexion;
        public Mascota()
        {
            cadenaConexion = new CadenaConexion().obtenerCadena();
        }

        public int id_Mascota { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string NombreDueño { get; set; }
        public int id_Raza { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Dueño { get; set; }
        public string Raza { get; set; }

        public List<Mascota> obtenerMascotas()
        {
            List<Mascota> listaMascotas = new List<Mascota>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                string query = "SELECT * FROM vistaMascotas";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mascota mascota = new Mascota()
                            {
                                id_Mascota = Convert.ToInt32(reader["id_Mascota"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apodo = reader["Apodo"].ToString(),
                                Dueño = reader["Dueño"].ToString(),
                                Raza = reader["Raza"].ToString()
                            };
                            listaMascotas.Add(mascota);
                        }
                    }
                }
            }
            return listaMascotas;
        }

        public Mascota Obtener(string dueño)
        {
            Mascota mascota = null;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("seleccionarMascota", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Dueño", SqlDbType.VarChar) { Value = dueño });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            mascota = new Mascota()
                            {
                                id_Mascota = Convert.ToInt32(reader["id_Mascota"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apodo = reader["Apodo"].ToString(),
                                Dueño = reader["Dueño"].ToString(),
                                Raza = reader["Raza"].ToString()
                            };
                        }
                    }
                }
            }
            return mascota;
        }

        public void Agregar(Mascota mascota)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("agregarMascota", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                    command.Parameters.AddWithValue("@Apodo", mascota.Apodo);
                    command.Parameters.AddWithValue("@NombreDueño", mascota.NombreDueño);
                    command.Parameters.AddWithValue("@id_Raza", mascota.id_Raza);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(Mascota mascota)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("modificarMascota", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_Mascota", mascota.id_Mascota);
                    command.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                    command.Parameters.AddWithValue("@Apodo", mascota.Apodo);
                    command.Parameters.AddWithValue("@NombreDueño", mascota.NombreDueño);
                    command.Parameters.AddWithValue("@id_Raza", mascota.id_Raza);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id_mascota)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("eliminarMascota", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_Mascota", id_mascota);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}