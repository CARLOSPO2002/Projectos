using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS_CIRCULARES
{
    internal class Nodo<T>
    {
        public T Datos;
        public Nodo<T> Siguiente;
        public Nodo<T> Anterior;


        public Nodo(T datos)
        {
            Datos = datos;
            Siguiente = null;
            Anterior = null;
        }
    }
}
