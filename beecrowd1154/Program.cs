using System;
using System.Globalization;

namespace uri1154
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade, cont, soma;
            double media;

            idade = 0;
            soma = 0;
            cont = 0;

            while (idade >= 0)
            {
                idade = int.Parse(Console.ReadLine());
                if (idade >= 0)
                {
                    soma += idade;
                    cont += 1;
                }
            }

            media = (double)soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}