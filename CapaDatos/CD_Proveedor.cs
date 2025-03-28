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
            comando.CommandText = "MostrarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            Leer = comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;

        }

    }
}
