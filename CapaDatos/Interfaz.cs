using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public interface IConsultaVehiculo
    {
        int Consulta_ID { get; set; }
        string Disponibilidad { get; set; }
        string Estado_Venta { get; set; }
        int Vehiculo_ID { get; set; }
    }
}
