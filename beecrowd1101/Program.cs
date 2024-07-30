using System;
using System.Globalization;

namespace beecrowd1101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);

            while (a > 0 && b > 0) 
            {

                if (b > a)
                {
                    int aux = a;
                    a = b;
                    b = aux;
                }

                int soma = 0;

                for (int i = b; i <= a; i++)
                {
                    soma += i;
                    Console.Write($"{i} ");
                }

                Console.WriteLine($"Sum={soma}");

                entrada = Console.ReadLine().Split(' ');
                a = int.Parse(entrada[0]);
                b = int.Parse(entrada[1]);
            }
        }
    }
}