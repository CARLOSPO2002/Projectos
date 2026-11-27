using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHSET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            char eleccion='y';
            int i=0;
            HashSet<string> set = new HashSet<string>();
            set.Add("CarlosP");
            set.Add("Fernando");
            do
            {
                Console.WriteLine("Ingresar Nombre: ");
                nombre = Console.ReadLine();

                foreach (string s in set)
                {
                    if (s == nombre)
                        i++;
                }
                if (i == 0)
                {
                    set.Add(nombre);
                    Console.WriteLine("Usuario guardado con exito");
                    Console.WriteLine("Desea Ingresar otro valor (y/n)");
                    eleccion = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("USUARIO NO VALIDO, YA EXISTE");
                }

            } while (eleccion != 'n');
        }
    }
}
