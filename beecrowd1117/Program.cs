using System;
using System.Globalization;

namespace uri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma, media, nota;
            int cont;

            nota = 0;
            cont = 0;
            soma = 0;

            while (cont < 2)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (nota >= 0.0 && nota <= 10.0)
                {
                    soma += nota;
                    cont += 1;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            media = soma / cont;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture)); 

        }
    }
}