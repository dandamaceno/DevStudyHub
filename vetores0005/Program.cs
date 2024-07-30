using System;
using System.Globalization;

namespace vetores0005
{
    class Program
    {
        static void Main(string[] args)
        {

            int soma = 0, n = int.Parse(Console.ReadLine());

            string[] entrada = Console.ReadLine().Split(' ');

            int[] inteiros = new int[n];

            for (int i = 0; i < n; i++)
            {
                inteiros[i] = int.Parse(entrada[i]);
                soma += inteiros[i];
            }

            Console.WriteLine((soma / n).ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}