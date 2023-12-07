using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ControlDeTareas
{
    internal class GestorProyectos
    {
        private string cadenadeConexion = "Data Source=PAVILION-G-15\\SQLEXPRESS;Initial Catalog=SistemaTareas;Integrated Security=True;Encrypt=False0"; // Reemplaza con tu cadena de conexión
       
        public List<Proyectos> ObtenerProyectosDB()
        {
            List<Proyectos> listaProyectos = new List<Proyectos>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenadeConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM Proyectos";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Proyectos proyecto = new Proyectos
                                {
                                    ProyectoId = Convert.ToInt32(reader["ProyectoId"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                                    FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                                    Estado = reader["Estado"].ToString(),
                                    ClienteId = Convert.ToInt32(reader["ClienteId"])
                                };

                                listaProyectos.Add(proyecto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener proyectos desde la base de datos: " + ex.Message);
            }

            return listaProyectos;
        }

        public void AgregarProyecto(string nombre, DateTime fechaInicio, DateTime fechaFin, string estado, int clienteId)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "INSERT INTO Proyectos (Nombre, FechaInicio, FechaFin, Estado, ClienteId) VALUES (@Nombre, @FechaInicio, @FechaFin, @Estado, @ClienteId)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaFin);
                        comando.Parameters.AddWithValue("@Estado", estado);
                        comando.Parameters.AddWithValue("@ClienteId", clienteId);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar proyecto a la base de datos: " + ex.Message);
            }
        }

        public void EditarProyecto(int proyectoId, string nombre, DateTime fechaInicio, DateTime fechaFin, string estado, int clienteId)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "UPDATE Proyectos SET Nombre = @Nombre, FechaInicio = @FechaInicio, FechaFin = @FechaFin, Estado = @Estado, ClienteId = @ClienteId WHERE ProyectoId = @ProyectoId";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ProyectoId", proyectoId);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaFin);
                        comando.Parameters.AddWithValue("@Estado", estado);
                        comando.Parameters.AddWithValue("@ClienteId", clienteId);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar proyecto en la base de datos: " + ex.Message);
            }
        }

        public void EliminarProyecto(int proyectoId)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "DELETE FROM Proyectos WHERE ProyectoId = @ProyectoId";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ProyectoId", proyectoId);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar proyecto de la base de datos: " + ex.Message);
            }
        }
    }
}
