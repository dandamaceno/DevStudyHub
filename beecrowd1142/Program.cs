using System;
using System.Globalization;

namespace beecrowd1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;

            n = int.Parse(Console.ReadLine());
            x = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{x++} {x++} {x++} PUM");
                x++;
            }
        }
    }
}