using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIBONACCI
{
    internal class Program
    {
        public static long fibo(int n)
        {
            if(n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return fibo(n - 1) + fibo(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("LOS PRIMEROS 20 NUMEROS DE FIBONACCI SON:");
            for(int i=0;i<20; i++)
            {
                Console.WriteLine(fibo(i));
            }
            Console.ReadKey();
        }
    }
}
