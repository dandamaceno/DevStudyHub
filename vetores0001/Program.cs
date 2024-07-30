using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace vetores0001
{
    class Program
    {
        static void Main(string[] args)
        {
            int posicao = 0;
            double maior = 0;
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            string[] entrada = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0;i < n; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);

        }
    }
}