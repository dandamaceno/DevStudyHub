using System;
using System.Globalization;

namespace vetores0002
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            int pares = 0;

            string[] entrada = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(entrada[i]);
            }
            //1. Mostrando os números pares
            int qtdPares = 0;
            for (int i = 0;i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                    qtdPares++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(qtdPares);

        }
    }
}