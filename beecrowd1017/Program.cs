using System;
using System.Globalization;

namespace uri1017
{
    class URI
    {
        static void Main(string[] args)
        {

            int tempo, velMedia;
            double litros;


            tempo = int.Parse(Console.ReadLine());
            velMedia = int.Parse(Console.ReadLine());

            litros = (double)tempo * (double)velMedia / 12.0;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

        }

    }
}