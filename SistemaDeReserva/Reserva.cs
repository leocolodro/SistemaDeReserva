using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeReserva
{
    internal class Reserva
    {
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string TipoCancha { get; set; }

        public Reserva(DateTime fecha, string nombre, string tipoCancha)
        {
            Fecha = fecha;
            Nombre = nombre;
            TipoCancha = tipoCancha;
        }
    }
}
