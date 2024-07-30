using System;
using System.Globalization;

namespace uri1014
{
    class URI
    {
        static void Main(string[] args)
        {

            int distancia = int.Parse(Console.ReadLine());
            double litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = distancia / litros;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }

    }
}