using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_Origen
{
    internal class Pila<T>
    {
        private Nodo<T> cabeza;
        
        
        private int tamaño=0;

        public void Ingresar(T datos)
        {
            Nodo<T> nuevo_nodo = new Nodo<T>(datos);
            nuevo_nodo.siguiente = cabeza;
            cabeza = nuevo_nodo;
        }
        public void SacarPrimero() 
        {
            
        }
    }
}
