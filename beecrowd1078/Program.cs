using System;
using System.Globalization;

namespace uri1078
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }

        }
    }
}