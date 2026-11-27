using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARREGLOS_PRACTICA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc=0;
            string[]Nombre = new string[22];
            int[] Edad = new int[22];
            do
            {
                
                Console.WriteLine("MENU");
                Console.WriteLine("1.Ingresa alumno");
                Console.WriteLine("2.Mostrar alumnos");
                Console.WriteLine("3.Calcular promedio de las edades de los alumnos");
                Console.WriteLine("4.Salir");
                Console.WriteLine("Ingrese una opcion: ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        int cont = 0;
                        Console.WriteLine("Ingresa nombre de Alumno");
                        string nombreO = Console.ReadLine();
                        Console.WriteLine("Ingresa edad de Alumno");
                        int edad = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 22; i++)
                        {
                            if (Nombre[i] == null)
                            {
                                cont = i; break;
                            }
                        }
                        Nombre[cont] = nombreO;
                        Edad[cont] = edad;

                        break;

                    case 2:

                        for (int i = 0; i < 22; i++)
                        {
                            if (Nombre[i] != null)
                            {
                                int num = i + 1;
                                Console.WriteLine(num + ". Nombre: " + Nombre[i] + "| Edad: " + Edad[i]);

                            }
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        int edades=0;
                        double prom = 0;
                        int con = 0;
                        for (int i = 0; i < 22; i++)
                        {
                            if (Nombre[i] != null)
                            {
                                edades=edades+ Edad[i];
                                con=con+ 1;
                            }
                        }
                        prom = edades /con;
                        Console.WriteLine("El promedio de las edades es: " + prom);
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (opc !=4);
        }
    }
}
