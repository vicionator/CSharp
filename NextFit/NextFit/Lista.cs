using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFit
{
    class Lista<T>
    {
        private int tamaño;
        private Nodo<T> cabeza;
        private Nodo<T> cola;

        public Lista()
        {
            tamaño = 0;
            cabeza = null;
            cola = null;
        }
        public void Agrega(T val)
        {

            Nodo<T> n = new Nodo<T>(val);
            if (tamaño < 1)
            {
                cabeza = n;
                cola = n;
                cabeza.siguiente = cola;
                cola.siguiente = cabeza;
                tamaño++;
            }
            else
            {
                cola.siguiente = n;
                cola = n;
                n.siguiente = cabeza;
                tamaño++;
            }

        }
    }
}
