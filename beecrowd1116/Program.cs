using System;
using System.Globalization;

namespace beecrowd1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');

                double divisor = double.Parse(entrada[0]);
                double dividendo = double.Parse(entrada[1]);

                if (dividendo == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine((divisor / dividendo).ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}