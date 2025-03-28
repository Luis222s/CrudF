using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        //La cadena de conexion
        private SqlConnection Conexion = new SqlConnection("Server=(local);Database=CrudF;Integrated Security=true");

        //Metodo para abrir la conexion
        public SqlConnection AbrirConexion()
        {
            //Abre la conexion si esta cerrada
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            //Devuelve la conexion abierta
            return Conexion;
        }
        //Metodo para cerrar la conexion
        public SqlConnection CerrarConexion()
        {
            //Cierra la conexion si esta abierta
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            //Duelve la conexion cerrada
            return Conexion;

        }
    }
}
