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

        public DataTable MostrarProductos()
        {
            DataTable Tabla = new DataTable();
            Tabla = objetoCD.Mostrar();
            return Tabla;
        }
        public void InsertarProd(string Nombre, string Direccion, string Telefono, string Email)
        {
            objetoCD.Insertar(Nombre, Direccion, Telefono, Email);
        }
        public void EditarProd(string Nombre, string Direccion, string Telefono, string Email, string Proveedor_ID)
        {
            objetoCD.Editar(Nombre, Direccion, Telefono, Email, Convert.ToInt32(Proveedor_ID));
        }
        public void EliminarProd(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
