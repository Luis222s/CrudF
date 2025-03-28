using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objetoCD = new CD_Proveedor();

        public DataTable MostrarProveedor()
        {
            DataTable Tabla = new DataTable();
            Tabla = objetoCD.Mostrar();
            return Tabla;
        }
    }
}
