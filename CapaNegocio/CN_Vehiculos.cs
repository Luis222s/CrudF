using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class VehiculoLN
    {
        public DataTable ObtenerVehiculos()
        {
            return dao.ListarVehiculos();
        }
        private VehiculoDAO dao = new VehiculoDAO();

        public bool RegistrarVehiculo(Vehiculo v)
        {
            return dao.InsertarVehiculo(v);
        }

        public bool EditarVehiculo(Vehiculo v)
        {
            return dao.EditarVehiculo(v);
        }

        public bool EliminarVehiculo(int id)
        {
            return dao.EliminarVehiculo(id);
        }
    }
}
