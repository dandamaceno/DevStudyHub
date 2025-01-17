﻿using System;
using System.Globalization;

namespace uri1036
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, delta, r1, r2;

            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0]);
            b = double.Parse(valores[1]);
            c = double.Parse(valores[2]);

            delta = Math.Pow(b, 2.0) - (4.0 * a * c);

            if (a == 0.0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }

        }
    }
}
