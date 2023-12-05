using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ControlDeTareas
{
    internal class GestorClientes
    {
        private string cadenaConexion = "Data Source=PAVILION-G-15\\SQLEXPRESS;Initial Catalog=SistemaTareas;Integrated Security=True;Encrypt=False0"; // Reemplaza con tu cadena de conexión
        private int proximoId;

        public GestorClientes()
        {
            proximoId = 1;
        }
       
        public List<Cliente> ObtenerClientesDB()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM Clientes";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente
                                {
                                    ClienteId = Convert.ToInt32(reader["ClienteId"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Correo = reader["Correo"].ToString(),
                                    DireccionFisica = reader["DireccionFisica"].ToString()
                                };

                                listaClientes.Add(cliente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener clientes desde la base de datos: " + ex.Message);
            }

            return listaClientes;
        }

        public void AgregarCliente(string nombre, string telefono, string correo, string direccion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "INSERT INTO Clientes (Nombre, Telefono, Correo, DireccionFisica) VALUES (@Nombre, @Telefono, @Correo, @Direccion)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Telefono", telefono);
                        comando.Parameters.AddWithValue("@Correo", correo);
                        comando.Parameters.AddWithValue("@Direccion", direccion);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar cliente a la base de datos: " + ex.Message);
            }
        }

        public void EditarCliente(int clienteId, string nombre, string telefono, string correo, string direccion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "UPDATE Clientes SET Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, DireccionFisica = @Direccion WHERE ClienteId = @ClienteId";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ClienteId", clienteId);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Telefono", telefono);
                        comando.Parameters.AddWithValue("@Correo", correo);
                        comando.Parameters.AddWithValue("@Direccion", direccion);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar cliente en la base de datos: " + ex.Message);
            }
        }

        public void EliminarCliente(int clienteId)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "DELETE FROM Clientes WHERE ClienteId = @ClienteId";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ClienteId", clienteId);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar cliente de la base de datos: " + ex.Message);
            }
        }
    }
}
