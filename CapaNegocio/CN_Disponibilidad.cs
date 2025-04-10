using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{

    public class ConsultaVehiculo : IConsultaVehiculo
    {
        public int Consulta_ID { get; set; }
        public string Disponibilidad { get; set; }
        public string Estado_Venta { get; set; }
        public int Vehiculo_ID { get; set; }
    }

    public class ConsultaVehiculoLN
    {
        //TODO instancia del DAO para acceso a datos
        private ConsultaVehiculoDAO dao = new ConsultaVehiculoDAO();

        //TODO método para registrar una nueva consulta
        public bool RegistrarConsulta(IConsultaVehiculo consulta) => dao.InsertarConsulta(consulta);

        //TODO método para editar una consulta existente
        public bool EditarConsulta(IConsultaVehiculo consulta) => dao.EditarConsulta(consulta);

        //TODO método para eliminar una consulta por su ID
        public bool EliminarConsulta(int id) => dao.EliminarConsulta(id);

        //TODO método para obtener todas las consultas
        public DataTable ObtenerConsultas() => dao.ListarConsultas();

        //TODO método para obtener lista de Vehiculo_ID desde la base de datos
        public List<int> ObtenerVehiculoIDs() => dao.ObtenerVehiculos();
    }
}
