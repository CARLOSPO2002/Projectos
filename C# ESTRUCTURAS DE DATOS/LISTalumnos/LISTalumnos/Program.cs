using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTalumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            string alum;
            string matri;
            Alumnos alu;
            
          List<Alumnos> alumnos = new List<Alumnos>();
            do
            {
                int i=0;
                Console.WriteLine("++++++++++++++++++ MENU +++++++++++++++++++++");
                Console.WriteLine("");
                Console.WriteLine("1.Ingresar Alumno");
                Console.WriteLine("2.Buscar Alumno");
                Console.WriteLine("3.Mostrar todos los alumnos");
                Console.WriteLine("4.Salir");
                Console.WriteLine("Elige tu opcion: ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingresa el nombre del alumno: ");
                            alum = Console.ReadLine();
                            Console.WriteLine("Ingresa la matricula del usuario: ");
                            matri = Console.ReadLine();
                            alu = new Alumnos(matri,alum);
                            foreach (Alumnos a in alumnos)
                            {
                                if (alu.Mat == a.Mat)
                                {
                                    i++;
                                }

                            }
                            if (i == 0)
                            {
                                alumnos.Add(alu);
                            }
                            else
                            {
                                Console.WriteLine("Usuario ya existente, Matricula ya asignada");
                            }
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Ingresa la matricula del usuario a buscar: ");
                            matri= Console.ReadLine();

                            foreach (Alumnos a in alumnos)
                            {
                                if (matri == a.Mat)
                                {
                                    Console.WriteLine("Matricula: " + a.Mat);
                                    Console.WriteLine("Alumno: " + a.Nom);
                                    break;
                                }
                            }
                        }
                        break;

                    case 3:
                        {
                            foreach (Alumnos a in alumnos)
                            {
                                Console.WriteLine(i);
                                Console.WriteLine(a.Nom);
                                Console.WriteLine(a.Mat);
                                i++;
                            }
                        }
                        break;

                    case 4:
                        { }
                        break;
                    default:

                        break;


                }
            } while (opc != 4);



        }
    }
}
