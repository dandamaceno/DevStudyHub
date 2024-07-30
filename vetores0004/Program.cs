using System;
using System.Globalization;

namespace vetores0004
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double[] reais = new double[n];

            string[] vet = Console.ReadLine().Split(' ');

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                reais[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                soma += reais[i];
            }

            double media = soma / n;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0;i < n; i++)
            {
                if (reais[i] < media)
                {
                    Console.WriteLine(reais[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}