using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            Leer = comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
        public void Insertar(string Nombre, string Direccion, string Telefono, string Email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProductos";
            comando.CommandType= CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre",Nombre);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Email", Email);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void Editar(string Nombre, string Direccion, string Telefono, string Email, int Proveedor_id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Email", Email);
            comando.Parameters.AddWithValue("@Proveedor_ID", Proveedor_id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProductos";
            comando.CommandType= CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idpro",id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

    }
}
