using System;
using System.Globalization;

namespace uri1044
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B;

            string[] entrada = Console.ReadLine().Split(' ');

            A = int.Parse(entrada[0]);
            B = int.Parse(entrada[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
