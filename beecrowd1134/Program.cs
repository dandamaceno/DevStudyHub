using System;
using System.Globalization;

namespace uri1134
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int produto, soma1, soma2, soma3;

            produto = int.Parse(Console.ReadLine());

            soma1 = 0;
            soma2 = 0;
            soma3 = 0;

            while (produto != 4)
            {
                
                if (produto == 1)
                {
                    soma1 += 1;
                }
                else if (produto == 2)
                {
                    soma2 += 1;
                }
                else if (produto == 3)
                {
                    soma3 += 1;
                }
                produto = int.Parse(Console.ReadLine());

            }
                
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + soma1);
            Console.WriteLine("Gasolina: " + soma2);
            Console.WriteLine("Diesel: " + soma3);

        }
    }
}