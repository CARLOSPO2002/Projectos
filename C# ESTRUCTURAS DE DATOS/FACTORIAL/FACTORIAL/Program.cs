using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORIAL
{
    internal class Program
    {
        public static long fact(int n)
        {
            if (n == 0)
                return 1;
            else 
                return n * fact(n - 1);
            
                
            
        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("INGRESA EL NUMERO PARA CALCULAR SU FACTORIAL");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("EL FACTORIAL DE " + n + " ES: " + fact(n));
        }
    }
}
