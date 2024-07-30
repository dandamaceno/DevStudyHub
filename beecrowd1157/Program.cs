using System;
using System.Globalization;

namespace beecrowd1157
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int resultado = n * (n - 1);

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(n);

        }
    }
}