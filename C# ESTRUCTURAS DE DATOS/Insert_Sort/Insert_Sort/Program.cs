using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];
            int num;
            Console.WriteLine("Ingresa 10 numeros");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número: ");
                num = Convert.ToInt32(Console.ReadLine());

                int j = 0;

                while (j < i && num > numeros[j])
                {
                    j++;
                }

                for (int k = i; k > j; k--)
                {
                    numeros[k] = numeros[k - 1];
                }

                numeros[j] = num;
            }
            for(int g = 0; g < numeros.Length; g++)
            {
                Console.WriteLine(numeros[g]);
            }
        
    
        }
    }
}
