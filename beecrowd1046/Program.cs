using System;
using System.Globalization;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {

            int inicial, final, duracao;

            string[] entrada = Console.ReadLine().Split(' ');

            inicial = int.Parse(entrada[0]);
            final = int.Parse(entrada[1]);

            if (inicial < final)
            {
                duracao = final - inicial;
            }
            else 
            {
                duracao = 24 - inicial + final;            
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}
