using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ControlDeTareas
{
    public class GestorProyectos
    {
        private string cadenaConexion = "Data Source=PAVILION-G-15\\SQLEXPRESS;Initial Catalog=SistemaTareas;Integrated Security=True;Encrypt=False0";

        public List<Proyectos> ObtenerProyectos()
        {
            List<Proyectos> listaProyectos = new List<Proyectos>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = "SELECT * FROM Proyectos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Proyectos proyecto = new Proyectos
                            {
                                ProyectoId = Convert.ToInt32(reader["ProyectoId"]),
                                Nombre = reader["Nombre"].ToString(),
                                // Otras propiedades del proyecto según tu modelo
                            };

                            listaProyectos.Add(proyecto);
                        }
                    }
                }
            }

            return listaProyectos;
        }

        public void AgregarProyecto(string nombre)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = "INSERT INTO Proyectos (Nombre) VALUES (@Nombre)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarProyecto(int proyectoId, string nombre)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = "UPDATE Proyectos SET Nombre = @Nombre WHERE ProyectoId = @ProyectoId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@ProyectoId", proyectoId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarProyecto(int proyectoId)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = "DELETE FROM Proyectos WHERE ProyectoId = @ProyectoId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProyectoId", proyectoId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

