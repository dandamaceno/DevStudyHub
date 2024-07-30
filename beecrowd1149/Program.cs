using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace beecrowd1149
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            int A = int.Parse(entrada[0]);
            int i = 1;
            int N = int.Parse(entrada[i]);

            while (N <= 0)
            {
                i += 1;
                N = int.Parse(entrada[i]);
            }

            int soma = 0;

            for (i = 0; i < N; i++)
            {
                soma += A + i;
            }

            Console.WriteLine(soma);
        }
    }
}