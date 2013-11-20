using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class File
    {
        public string Nombre;
        public int Tamaño = 0;

        public File() { }

        public File(string nombre, int tamaño) 
        {
            this.Nombre = nombre;
            this.Tamaño = tamaño;
        }
    }
}
