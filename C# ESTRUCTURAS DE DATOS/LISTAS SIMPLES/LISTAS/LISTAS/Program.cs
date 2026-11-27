using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LISTAS
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            int opcion;
            ListaEnlazada<double> lista = new ListaEnlazada<double>();
            do
            {
                
                double numero = 0;
                
                Console.WriteLine("MENU");
                Console.WriteLine("1. Agregar al final");
                Console.WriteLine("2. Agregar al principio");
                Console.WriteLine("3. Agregar intermedio");
                Console.WriteLine("4. Eliminar del final");
                Console.WriteLine("5. Eliminar del principio");
                Console.WriteLine("6. Buscar nodo");
                Console.WriteLine("7. Mostrar lista");
                Console.WriteLine("8. Salir");
                Console.WriteLine("Seleccione una opcion");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {

                    case 1:
                        {
                            Console.WriteLine("AGREGAR AL FINAL ");
                            Console.WriteLine("Ingrese el numero a agregar al final: ");
                            numero = Convert.ToDouble(Console.ReadLine());
                            lista.AgregarAlFinal(numero);
                            Console.WriteLine("LISTO");
                            Console.ReadKey();
                            break;
                        }


                    case 2:
                        {

                            Console.WriteLine("AGREGAR AL INICIO ");
                            Console.WriteLine("Ingrese el numero a agregar al inicio: ");
                            numero = Convert.ToDouble(Console.ReadLine());
                            lista.AgregarAlInicio(numero);
                            Console.WriteLine("LISTO");
                            Console.ReadKey();
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("AGREGAR INTERMEDIO ");
                            Console.WriteLine("Ingrese el numero a agregar INTERMEDIO: ");
                            numero = Convert.ToDouble(Console.ReadLine());
                            lista.AgregarIntermedio(numero);
                            Console.WriteLine("LISTO");
                            Console.ReadKey();
                            break;
                        }


                    case 4:
                        {
                            Console.WriteLine("ELIMINAR DEL FINAL ");
                            lista.EliminarFinal();
                            Console.WriteLine("LISTO");
                            Console.ReadKey();

                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("ElIMINAR INICIO");
                            lista.EliminarInicio();
                            Console.WriteLine("LISTO");
                            Console.ReadKey();

                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("BUSCAR NODO");
                            Console.WriteLine("Ingrese el numero a buscar: ");
                            numero = Convert.ToDouble(Console.ReadLine());
                            lista.BuscarNodo(numero);
                            Console.WriteLine("listo");
                            Console.ReadKey();

                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("MOSTRAR LISTA");
                            lista.ImprimirLista();
                            Console.WriteLine("LISTO");
                            Console.ReadKey();

                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("ADIOS");

                            break;
                        }
                }
            } while (opcion != 8);
        }
    }
}
