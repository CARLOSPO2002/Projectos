using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS_CIRCULARES
{
    internal class ListaEnlazada<T>
    {
        private Nodo<T> cabeza1;
        private Nodo<T> cabeza2;
        private int tamaño = 0;

        public void AgregarAlFinal(T datos)
        {
            Nodo<T> NuevoNodo = new Nodo<T>(datos);
            if (cabeza1 == null)
            {
                cabeza1 = NuevoNodo;
                cabeza2 = NuevoNodo;
                cabeza2.Siguiente = cabeza1;
                tamaño++;
                return;
            }
            cabeza2.Siguiente = NuevoNodo;
            cabeza2 = NuevoNodo;
            cabeza2.Siguiente = cabeza1;

            tamaño++;
        }

        public void AgregarAlInicio(T datos)
        {

            Nodo<T> NuevoNodo = new Nodo<T>(datos);
            if (cabeza1 == null)
            {
                cabeza1 = NuevoNodo;
                cabeza2 = NuevoNodo;
                cabeza2.Siguiente = cabeza1;
                tamaño++;
                return;
            } 
            NuevoNodo.Siguiente = cabeza1;
            cabeza2.Siguiente = NuevoNodo;
            cabeza1 = NuevoNodo;

            tamaño++;
        }

        public void AgregarIntermedio(T datos)
        {

            Nodo<T> NuevoNodo = new Nodo<T>(datos);
            if (cabeza1 == null)
            {
                cabeza1 = NuevoNodo;
                cabeza2 = NuevoNodo;
                cabeza2.Siguiente = cabeza1;
                tamaño++;
                return;
            }
            if (tamaño == 1)
            {
                cabeza1.Siguiente = NuevoNodo;
                NuevoNodo.Siguiente = cabeza1;
                cabeza2 = NuevoNodo;
                tamaño++;
                return;
            }

            Nodo<T> actual = cabeza1;
            for (int i = 0; i < (tamaño / 2) - 1; i++)//1,2,3, N ,4,5,6
            {

                actual = actual.Siguiente;

            }
            Nodo<T> aux = actual.Siguiente;
            NuevoNodo.Siguiente = aux;
            actual.Siguiente = NuevoNodo;
            
            tamaño++;

        }
        public void EliminarInicio()
        {
            if (cabeza1 == null)
                return;
            if (tamaño == 1)
            {
                cabeza1 = null;
                cabeza2 = null;
                tamaño--;
                return;
            }

            cabeza1 = cabeza1.Siguiente;
            cabeza2.Siguiente = cabeza1;
            tamaño--;

        }
        public void EliminarFinal()
        {
            if (cabeza2 == null)
                return;
            if (tamaño == 1)
            {
                cabeza1 = null;
                cabeza2 = null;
                tamaño--;
                return;
            }
            Nodo<T> actual = cabeza1;
            while (actual.Siguiente != cabeza2)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = cabeza1;
            cabeza2 = actual;
            tamaño--;


        }
        public void BuscarNodo(T datos)
        {
            if (cabeza1 == null)
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            int contador = 1;
            Nodo<T> actual = cabeza1.Siguiente;
            if (cabeza1.Datos.Equals(datos))// si el nodo encontrado es igual al nodo que se busca
            {

                Console.WriteLine("Nodo encontrado: " + cabeza1.Datos);
                Console.WriteLine("Nodo pertenece al lugar: " + contador);
                return;
            }
            while (actual != cabeza1)
            {
                contador++;
                if (actual.Datos.Equals(datos))// si el nodo encontrado es igual al nodo que se busca
                {

                    Console.WriteLine("Nodo encontrado: " + actual.Datos);
                    Console.WriteLine("Nodo pertenece al lugar: " + contador);
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine("Nodo no encontrado");
        }
        public void ImprimirLista()
        {
            if (cabeza1 == null)
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            Nodo<T> actual = cabeza1.Siguiente;
            Console.WriteLine(cabeza1.Datos + " -> ");
            while (actual != cabeza1)
            {
                Console.WriteLine(actual.Datos + " -> ");
                actual = actual.Siguiente;
            }
        }
    }
}
