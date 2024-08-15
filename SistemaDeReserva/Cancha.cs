using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeReserva
{
    internal class Cancha
    {
        public int Numero { get; set; }

        public string TipoDeSuperficie { get; set; }

        public string Capacidad { get; set; }

        public string Disponibilidad { get; set; }

        public Cancha(int numero, string tipoDeSuperficie, string capacidad, string disponibilidad)
        {
            Numero = numero;
            TipoDeSuperficie = tipoDeSuperficie;
            Capacidad = capacidad;
            Disponibilidad = disponibilidad;
        }
    }
}
