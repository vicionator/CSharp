using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFit
{
    class Nodo<T>
    {
        public T valor { get; set; }
        public Nodo<T> siguiente;

        public Nodo()
        {
            valor = default(T);
            siguiente = null;
        }
        public Nodo(T val)
        {
            valor = val;
            siguiente = null;
        }
        public T ValNod
        {
            get { return valor; }
            set { valor = value; }
        }
        public Nodo<T> SigNod
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
