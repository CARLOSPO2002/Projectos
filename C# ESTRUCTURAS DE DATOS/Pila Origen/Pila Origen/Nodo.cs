using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_Origen
{
    internal class Nodo<T>
    {
        public T Datos;
        public Nodo<T> siguiente;

        public Nodo(T datos)
        {
            Datos = datos;
            siguiente = null;
            
        }

    }
}
