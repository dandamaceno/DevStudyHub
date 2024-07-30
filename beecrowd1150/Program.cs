using System;
using System.Globalization;

namespace beecrowd1150
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, z, contador;

            x = int.Parse(Console.ReadLine());
            contador = 0;

            do
            {
                z = int.Parse(Console.ReadLine());
            }
            while (z <= x);
            
            for (int i = x; i <= z; i += x + 1)
            {
                contador ++;
            }

            Console.WriteLine(contador);

        }
    }
}