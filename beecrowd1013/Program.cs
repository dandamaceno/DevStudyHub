using System;
using System.Globalization;

namespace uri1013
{
    class URI
    {
        static void Main(string[] args)
        {

            int A, B, C, maior1, maiorFinal;

            string[] valores = Console.ReadLine().Split(' ');

            A = int.Parse(valores[0], CultureInfo.InvariantCulture);
            B = int.Parse(valores[1], CultureInfo.InvariantCulture);
            C = int.Parse(valores[2], CultureInfo.InvariantCulture);

            maior1 = (A + B + Math.Abs(A - B)) / 2;
            maiorFinal = (maior1 + C + Math.Abs(maior1 - C)) / 2;

            Console.WriteLine(maiorFinal + " eh o maior");

        }

    }
}