using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Propietario : Persona
    {
        public Propietario() { }
        public Propietario(string cedula, string nombres, string apellidos, string telefono)
        {
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
        }

        public override string NombreCompleto()
        {
            return $"Sr: {Nombres} {Apellidos}";
        }

        public override string ToString()
        {
            return $"{Id};{Cedula};{Nombres};{Apellidos};{Telefono}";
        }
    }
}
