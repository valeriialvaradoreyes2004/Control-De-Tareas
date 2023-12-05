using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlDeTareas
{

public class GestorTareas
    {
        private string cadenaConexion = "Data Source=PAVILION-G-15\\SQLEXPRESS;Initial Catalog=SistemaTareas;Integrated Security=True;Encrypt=False0"; 

        public List<Tarea> ObtenerTareasPorProyecto(int proyectoId)
        {
            List<Tarea> listaTareas = new List<Tarea>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = "SELECT * FROM Tareas WHERE ProyectoId = @ProyectoId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProyectoId", proyectoId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tarea tarea = new Tarea
                            {
                                TareaId = Convert.ToInt32(reader["TareaId"]),
                                Nombre = reader["Nombre"].ToString(),
                                ProyectoId = Convert.ToInt32(reader["ProyectoId"]),
                                FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                                FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                                Estado = reader["Estado"].ToString(),
                            
                            };

                            listaTareas.Add(tarea);
                        }
                    }
                }
            }

            return listaTareas;
        }

        public void AgregarTarea(int proyectoId, string nombre, DateTime fechaInicio, DateTime fechaFin, string estado)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = "INSERT INTO Tareas (Nombre, ProyectoId, FechaInicio, FechaFin, Estado) " +
                               "VALUES (@Nombre, @ProyectoId, @FechaInicio, @FechaFin, @Estado)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@ProyectoId", proyectoId);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    command.Parameters.AddWithValue("@Estado", estado);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarTarea(int tareaId, string nombre, DateTime fechaInicio, DateTime fechaFin, string estado)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = "UPDATE Tareas SET Nombre = @Nombre, FechaInicio = @FechaInicio, FechaFin = @FechaFin, Estado = @Estado " +
                               "WHERE TareaId = @TareaId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@TareaId", tareaId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarTarea(int tareaId)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = "DELETE FROM Tareas WHERE TareaId = @TareaId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TareaId", tareaId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}