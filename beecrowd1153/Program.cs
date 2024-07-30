using System;
using System.Globalization;

namespace beecrowd1153
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int resultado = n * (n - 1);

            for (int i = 2; i < n; i++)
            {
                resultado *= (n - i);
            }

            Console.WriteLine(resultado);

        }
    }
}