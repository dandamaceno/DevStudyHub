using System;
using System.Globalization;

namespace uri1010
{
    class URI
    {
        static void Main(string[] args)
        {

            string[] linha1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(linha1[0]);
            int numPecas1 = int.Parse(linha1[1]);
            double valorUnit1 = double.Parse(linha1[2], CultureInfo.InvariantCulture);

            string[] linha2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(linha2[0]);
            int numPecas2 = int.Parse(linha2[1]);
            double valorUnit2 = double.Parse(linha2[2], CultureInfo.InvariantCulture);

            double valorPagar = (numPecas1 * valorUnit1) + (numPecas2 * valorUnit2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}