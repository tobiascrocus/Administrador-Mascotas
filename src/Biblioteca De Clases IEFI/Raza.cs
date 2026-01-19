using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases_IEFI
{
    public class Raza
    {
        string cadenaConexion;
        public Raza()
        {
            cadenaConexion = new CadenaConexion().obtenerCadena();
        }

        public int id_Raza { get; set; }
        public string Nombre { get; set; }
        public int id_Animal { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Animal { get; set; }

        public List<Raza> obtenerRazas()
        {
            List<Raza> listaRazas = new List<Raza>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                string query = "SELECT * FROM vistaRazas";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Raza raza = new Raza()
                            {
                                id_Raza = Convert.ToInt32(reader["id_Raza"]),
                                Nombre = reader["Nombre"].ToString(),
                                Animal = reader["Animal"].ToString()
                            };
                            listaRazas.Add(raza);
                        }
                    }
                }
            }
            return listaRazas;
        }

        public List<Raza> obtenerNombresRazas()
        {
            List<Raza> listaNombres = new List<Raza>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                string query = "SELECT Nombre FROM Razas WHERE FechaBaja IS NULL";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Raza nombre = new Raza()
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

        public Raza Obtener(string nombre)
        {
            Raza raza = null;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("seleccionarRaza", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar) { Value = nombre });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            raza = new Raza()
                            {
                                id_Raza = Convert.ToInt32(reader["id_Raza"]),
                                Nombre = reader["Nombre"].ToString(),
                                Animal = reader["Animal"].ToString()
                            };
                        }
                    }
                }
            }
            return raza;
        }

        public void Agregar(Raza raza)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("agregarRaza", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", raza.Nombre);
                    command.Parameters.AddWithValue("@id_Animal", raza.id_Animal);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(Raza raza)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("modificarRaza", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_Raza", raza.id_Raza);
                    command.Parameters.AddWithValue("@Nombre", raza.Nombre);
                    command.Parameters.AddWithValue("@id_Animal", raza.id_Animal);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id_raza)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("eliminarRaza", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_Raza", id_raza);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}