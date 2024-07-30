using System;
using System.Globalization;

namespace beecrowd1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1, val2, maior, menor, soma;

            val1 = int. Parse(Console.ReadLine());
            val2 = int. Parse(Console.ReadLine());
            
            if (val1 > val2)
            {
                maior = val1;
                menor = val2;
            }
            else
            {
                maior = val2;
                menor = val1;
            }
            
            soma = 0;

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}