using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            string datoPila = "";
            Stack<string> pila = new Stack<string>();
            do
            {
                Console.WriteLine("--------MENU--------");
                Console.WriteLine("1.Agregar un valor a la pila");
                Console.WriteLine("2.Eliminar el valor superior de la pila");
                Console.WriteLine("3.Ver el valor superior de la pila");
                Console.WriteLine("4.Ver la cantidad de elementos en la pila");
                Console.WriteLine("5.Salir");
                Console.WriteLine("Elige una opcion a elegir: ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        {
                            Console.WriteLine("Agrega el nombre de un libro: ");
                            datoPila = Console.ReadLine();
                            pila.Push(datoPila);
                            Console.WriteLine("Libro agregado a la pila con exito");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Eliminando el ultimo libro agregado");
                            datoPila = Console.ReadLine();
                            string eliminad = pila.Pop();
                            Console.WriteLine("Libro eliminado:" + eliminad);

                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("El libro que esta arriba de la pila es: " + pila.Peek());



                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("La cantidad de libros en la pila es: " + pila.Count());
                            break;
                        }
                        case 5:
                        {
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Opcion no valida, por favor elige una opcion del menu");
                            break;
                        }

                }
                Console.ReadKey();
                Console.Clear();
                
            } while (opc != 5);
           
        }
    }
}
