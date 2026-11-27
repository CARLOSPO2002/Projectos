using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSULTORIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opciones Opc1 = new Opciones();
            NODO raiz;
            paciente pac;
            int opcion;
            int tur;
            string Nom;
            DateTime fe;
            do
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("      SISTEMA DE PACIENTES");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Mostrar pacientes");
                Console.WriteLine("3. Salir");
                Console.WriteLine("=================================");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        
                        Console.Clear();
                        Console.WriteLine("REGISTRAR PACIENTE");
                        Console.WriteLine("");
                        Console.WriteLine("Ingresa el turno del paciente: ");
                        tur= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingresa el Nombre del paciente: ");
                        Nom=Console.ReadLine();
                        fe=DateTime.Now;
                        pac = new paciente(tur, Nom, fe);
                        if (raiz == null) 
                        {
                            raiz=Opc1.Insertar(pac, null);
                        }
                        Opc1.Insertar(pac, raiz);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("LISTA DE PACIENTES");
                        // Aquí llamas a tu recorrido InOrden()
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 3);
        }
    }
}
