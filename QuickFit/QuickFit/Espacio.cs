using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFit
{
    public class Espacio
    {
        public int Vi=0;
        public int Vf=0;
        public int espacio=0;

        public Espacio(int ini, int fin, int mem) 
        {
            Vi = ini;
            Vf = fin;
            espacio = mem;
        }

        public Espacio() 
        {
        }
    }
}
