using System;
using System.Globalization;

namespace beecrowd1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {i * i} {i * i * i}");
            }
        }
    }
}