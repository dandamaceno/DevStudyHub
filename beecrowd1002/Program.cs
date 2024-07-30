using System;
using System.Globalization;

namespace uri1002{
    class URI{
        static void Main(string[] args){

            double raio, pi = 3.14159, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * raio * raio;

            Console.WriteLine("Área =" + area.ToString("F4", CultureInfo.InvariantCulture));
        }

    }
}