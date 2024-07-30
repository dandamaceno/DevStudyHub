using System;
using System.Globalization;

namespace beecrowd1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, maior, menor;
            
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                maior = n1;
                menor = n2;
            }
            else
            {
                maior = n2;
                menor = n1;
            }

            for (int i = menor + 1; i < maior; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}