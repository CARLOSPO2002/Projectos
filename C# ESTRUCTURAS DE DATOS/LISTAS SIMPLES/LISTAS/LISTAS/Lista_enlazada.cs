using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS
{
   
        internal class ListaEnlazada<T>
        {
            private Nodo<T> cabeza;
            private int tamaño = 0;
            public void AgregarAlFinal(T datos)
            {
                Nodo<T> NuevoNodo = new Nodo<T>(datos);
                if (cabeza == null)
                {
                    cabeza = NuevoNodo;
                    tamaño++;
                    return;
                }
                Nodo<T> actual = cabeza;

                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = NuevoNodo;
                tamaño++;
            }

            public void AgregarAlInicio(T datos)
            {

                Nodo<T> NuevoNodo = new Nodo<T>(datos);
                if (cabeza == null)
                {
                    cabeza = NuevoNodo;
                    tamaño++;
                    return;
                }
                Nodo<T> actual = cabeza;
                NuevoNodo.Siguiente = actual;
                cabeza = NuevoNodo;
                tamaño++;
            }

            public void AgregarIntermedio(T datos)
            {

                Nodo<T> NuevoNodo = new Nodo<T>(datos);
                if (cabeza == null)
                {
                    cabeza = NuevoNodo;
                    tamaño++;
                    return;
                }
                if (tamaño == 1)
                {
                    Nodo<T> actual1 = cabeza;
                    actual1.Siguiente = NuevoNodo;
                    tamaño++;
                    return;
                }

                Nodo<T> actual = cabeza;
                for (int i = 0; i < (tamaño / 2) - 1; i++)
                {

                    actual = actual.Siguiente;

                }
                NuevoNodo.Siguiente = actual.Siguiente;
                actual.Siguiente = NuevoNodo;
                tamaño++;

            }
            public void EliminarInicio()
            {
                if (cabeza == null)
                    return;
                cabeza = cabeza.Siguiente;
                tamaño--;

            }
            public void EliminarFinal()
            {
                if (cabeza == null)
                    return;
                if (tamaño == 1)
                {
                    cabeza = null;
                    tamaño--;
                    return;
                }

                Nodo<T> actual = cabeza;
                for (int i = 0; i < tamaño - 2; i++)
                {
                    actual = actual.Siguiente;

                }
                actual.Siguiente = null;
                tamaño--;
            }
            public void BuscarNodo(T datos)
            {
                if (cabeza == null)
                {
                    Console.WriteLine("La lista esta vacia");
                    return;
                }
                int contador = 0;
                Nodo<T> actual = cabeza;
                while (actual != null)
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
                if (cabeza == null)
                {
                    Console.WriteLine("La lista esta vacia");
                    return;
                }
                Nodo<T> actual = cabeza;
                while (actual != null)
                {
                    Console.WriteLine(actual.Datos+" -> ");
                    actual = actual.Siguiente;
                }
            }
        }
    }

