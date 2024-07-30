using System;
using System.Globalization;

namespace vetores0003
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            int[] b = new int[n];

            int[] c = new int[n];

            string[] entrada = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(entrada[i]);
            }

            entrada = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(entrada[i]);
            }

            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i];
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();

        }
    }
}