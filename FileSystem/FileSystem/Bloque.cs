using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class Bloque
    {
        public int Espacio = 0;
        public string Nombre;
        public bool Disponibilidad;

        public Bloque() { }

        public Bloque(int espacio, string nombre, bool disponibilidad) 
        {
            this.Nombre = nombre;
            this.Espacio = espacio;
            this.Disponibilidad = disponibilidad;
        }
    }
}
