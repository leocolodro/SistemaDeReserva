using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeReserva
{
    internal class Turno
    {
        public string FechaHorarioInicio { get; set; }
        public int Duracion { get; set; }
        public string Estado { get; set; }

        public Turno(string fechaHorarioInicio, int duracion, string estado)
        {
            FechaHorarioInicio = fechaHorarioInicio;
            Duracion = duracion;
            Estado = estado;
        }
    }
}
