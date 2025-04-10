using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VehiculoDAO
    {
        private string conexion = "Data Source=.;Initial Catalog=CRUDF;Integrated Security=True";

        public bool InsertarVehiculo(Vehiculo v)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string sql = "INSERT INTO Vehiculos (Modelo, Marca, Año, Precio, Condicion, Tipo) " +
                             "VALUES (@Modelo, @Marca, @Año, @Precio, @Condicion, @Tipo)";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Modelo", v.Modelo);
                cmd.Parameters.AddWithValue("@Marca", v.Marca);
                cmd.Parameters.AddWithValue("@Año", v.Año);
                cmd.Parameters.AddWithValue("@Precio", v.Precio);
                cmd.Parameters.AddWithValue("@Condicion", v.Condicion);
                cmd.Parameters.AddWithValue("@Tipo", v.Tipo);

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine ("Error al insertar: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EditarVehiculo(Vehiculo v)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string sql = "UPDATE Vehiculos SET Modelo = @Modelo, Marca = @Marca, Año = @Año, Precio = @Precio, " +
                             "Condicion = @Condicion, Tipo = @Tipo WHERE Vehiculo_ID = @Vehiculo_ID";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Modelo", v.Modelo);
                cmd.Parameters.AddWithValue("@Marca", v.Marca);
                cmd.Parameters.AddWithValue("@Año", v.Año);
                cmd.Parameters.AddWithValue("@Precio", v.Precio);
                cmd.Parameters.AddWithValue("@Condicion", v.Condicion);
                cmd.Parameters.AddWithValue("@Tipo", v.Tipo);
                cmd.Parameters.AddWithValue("@Vehiculo_ID", v.VehiculoID);

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine ("Error al editar vehículo: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarVehiculo(int id)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string sql = "DELETE FROM Vehiculos WHERE Vehiculo_ID = @Vehiculo_ID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Vehiculo_ID", id);

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine ("Error al eliminar vehículo: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable ListarVehiculos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string sql = "SELECT * FROM Vehiculos";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                try
                {
                    con.Open();
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar: " + ex.Message);
                }
            }
            return tabla;
        }
    }
    public class Vehiculo
    {
        public int VehiculoID { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Año { get; set; }
        public decimal Precio { get; set; }
        public string Condicion { get; set; }
        public string Tipo { get; set; }
    }
}
