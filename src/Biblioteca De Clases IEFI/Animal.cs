using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases_IEFI
{
    public class Animal
    {
        string cadenaConexion;
        public Animal()
        {
            cadenaConexion = new CadenaConexion().obtenerCadena();
        }

        public int id_Animal { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaBaja { get; set; }

        public List<Animal> obtenerAnimales()
        {
            List<Animal> listaAnimales = new List<Animal>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                string query = "SELECT * FROM vistaAnimales";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Animal animal = new Animal()
                            {
                                id_Animal = Convert.ToInt32(reader["id_Animal"]),
                                Nombre = reader["Animal"].ToString()
                            };
                            listaAnimales.Add(animal);
                        }
                    }
                }
            }
            return listaAnimales;
        }

        public List<Animal> obtenerNombresAnimales()
        {
            List<Animal> listaNombres = new List<Animal>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                string query = "SELECT Nombre FROM Animales WHERE FechaBaja IS NULL";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Animal nombre = new Animal()
                            {
                                Nombre = reader["Nombre"].ToString()
                            };
                            listaNombres.Add(nombre);
                        }
                    }
                }
            }
            return listaNombres;
        }

        public Animal Obtener(string nombre)
        {
            Animal animal = null;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("seleccionarAnimal", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Animal", SqlDbType.VarChar) { Value = nombre });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            animal = new Animal()
                            {
                                id_Animal = Convert.ToInt32(reader["id_Animal"]),
                                Nombre = reader["Animal"].ToString()
                            };
                        }
                    }
                }
            }
            return animal;
        }

        public void Agregar(Animal animal)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("agregarAnimal", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", animal.Nombre);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(Animal animal)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("modificarAnimal", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_Animal", animal.id_Animal);
                    command.Parameters.AddWithValue("@Nombre", animal.Nombre);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id_animal)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("eliminarAnimal", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_Animal", id_animal);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}