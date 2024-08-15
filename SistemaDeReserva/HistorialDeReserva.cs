using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeReserva
{
    internal class HistorialDeReserva
    {
        public string FechaDeReserva { get; set; }

        public string DetalleDeReserva { get; set; }

        public HistorialDeReserva(string fechaDeReserva, string detalleDeReserva)
        {
            FechaDeReserva = fechaDeReserva;
            DetalleDeReserva = detalleDeReserva;
        }
    }
}
