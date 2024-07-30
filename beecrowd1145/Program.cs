using System;
using System.Globalization;

namespace beecrowd1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);
                if (i % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}