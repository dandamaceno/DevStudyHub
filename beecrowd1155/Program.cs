using System;
using System.Globalization;

namespace beecrowd1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0;

            int s = 1;

            for (int i = 1; i <= 100; i++)
            {
                resultado += (double)s / i;
            }

            Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}