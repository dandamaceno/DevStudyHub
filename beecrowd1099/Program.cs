using System;
using System.Globalization;

namespace beecrowd1157
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                
                int a = int.Parse(entrada[0]);
                int b = int.Parse(entrada[1]);

                int maior = 0, menor = 0, soma = 0;

                if (a > b)
                {
                    maior = a;
                    menor = b;
                }
                else
                {
                    maior = b;
                    menor = a;
                }

                for (int j = menor; j < maior; j++)
                {
                    if (j % 2 != 0 && j > menor)
                    {
                        soma += j;
                    }
                }

                Console.WriteLine(soma);

            }

        }
    }
}