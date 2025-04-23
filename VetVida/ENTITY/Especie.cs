using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Especie : NamedEntity
    {
        public override string ToString()
        {
            return $"{Id};{Nombre}";
        }
        public string Serializar()
        {
            return $"{Id};{Nombre}";
        }
    }
}
