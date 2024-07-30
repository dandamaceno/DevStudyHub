using System;
using System.Globalization;

namespace uri1019
{
    class URI
    {
        static void Main(string[] args)
        {
            int N, var1, var2, var3, resto;

            N = int.Parse(Console.ReadLine());

            var1 = N / 3600;
            resto = N % 3600;

            var2 = resto / 60;
            
            var3 = resto % 60;

            Console.WriteLine(var1 + ":" + var2 + ":" + var3);

        }

    }
}