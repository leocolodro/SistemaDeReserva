using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeReserva
{
    internal class ReporteyEstadistica
    {
        public DateTime FechaGeneracion { get; set; }
        public string TipoDeReporte { get; set; }
        public double DatosEstadisticos { get; set; }

        public ReporteyEstadistica(DateTime fechaGeneracion, string tipoDeReporte, double datosEstadisticos)
        {
            FechaGeneracion = fechaGeneracion;
            TipoDeReporte = tipoDeReporte;
            DatosEstadisticos = datosEstadisticos;
        }

    }
}
