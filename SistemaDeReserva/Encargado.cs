using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeReserva
{
    internal class Encargado
    {
        public string Nombre { get; set; }

        public string CorreoElectronico { get; set; }

        public string Telefono {  get; set; }

        public Encargado(string nombre, string correoElectronico, string telefono)
        {
            Nombre = nombre;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
        }
    }
}
