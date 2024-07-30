using System;
using System.Globalization;

namespace uri1079
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');

                double a = double.Parse(entrada[0], CultureInfo.InvariantCulture) * 2;
                double b = double.Parse(entrada[1], CultureInfo.InvariantCulture) * 3;
                double c = double.Parse(entrada[2], CultureInfo.InvariantCulture) * 5;

                Console.WriteLine( ((a + b + c) / 10).ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}