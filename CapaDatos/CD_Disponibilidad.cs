using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConsultaVehiculoDAO
    {
        //TODO configurar cadena de conexión a SQL Server
        private string conexion = "Data Source=.;Initial Catalog=CRUDF;Integrated Security=True";

        public bool InsertarConsulta(IConsultaVehiculo consulta)
        {
            //TODO insertar una nueva consulta en la base de datos
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string sql = "INSERT INTO Disponibilidad (Disponibilidad, Estado_Venta, Vehiculo_ID) " +
                             "VALUES (@Disponibilidad, @Estado_Venta, @Vehiculo_ID)";
                SqlCommand cmd = new SqlCommand(sql, con);

                //TODO pasar parámetros a la consulta SQL
                
                cmd.Parameters.AddWithValue("@Disponibilidad", consulta.Disponibilidad);
                cmd.Parameters.AddWithValue("@Estado_Venta", consulta.Estado_Venta);
                cmd.Parameters.AddWithValue("@Vehiculo_ID", consulta.Vehiculo_ID);

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EditarConsulta(IConsultaVehiculo consulta)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string sql = "UPDATE Disponibilidad SET Disponibilidad = @Disponibilidad, Estado_Venta = @Estado_Venta, " +
                             "Vehiculo_ID = @Vehiculo_ID WHERE Consulta_ID = @Consulta_ID";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Consulta_ID", consulta.Consulta_ID);
                cmd.Parameters.AddWithValue("@Disponibilidad", consulta.Disponibilidad);
                cmd.Parameters.AddWithValue("@Estado_Venta", consulta.Estado_Venta);
                cmd.Parameters.AddWithValue("@Vehiculo_ID", consulta.Vehiculo_ID);

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine ("Error al editar: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarConsulta(int consultaID)
        {
            //TODO eliminar una consulta por su ID
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string sql = "DELETE FROM Disponibilidad WHERE Consulta_ID = @Consulta_ID";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Consulta_ID", consultaID);

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable ListarConsultas()
        {
            //TODO obtener todas las consultas desde la base de datos
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string sql = "SELECT * FROM Disponibilidad";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);

                try
                {
                    con.Open();
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    Console.WriteLine ("Error al listar: " + ex.Message);
                }
            }
            return tabla;
        }

        public List<int> ObtenerVehiculos()
        {
            //TODO obtener la lista de Vehiculo_ID existentes para el ComboBox
            List<int> lista = new List<int>();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string sql = "SELECT Vehiculo_ID FROM Vehiculos";
                SqlCommand cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(reader.GetInt32(0));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine ("Error al obtener vehículos: " + ex.Message);
                }
            }
            return lista;
        }
    }
}
