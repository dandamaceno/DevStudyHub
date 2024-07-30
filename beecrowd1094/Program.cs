using System;
using System.Globalization;

namespace uri1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int qtdC, qtdR, qtdS;

            qtdC = 0;
            qtdR = 0;
            qtdS = 0;

            for (int i = 0; i < n; i++)
            {            
                string[] entrada = Console.ReadLine().Split(' ');
                int quantia = int.Parse(entrada[0]);
                char tipo = char.Parse(entrada[1]);

                if (tipo == 'C')
                {
                    qtdC += quantia;
                } 
                else if (tipo == 'R')
                {
                    qtdR += quantia;
                }
                else
                {
                    qtdS += quantia;
                }
            }

            int total = qtdC + qtdR + qtdS;
            double porcentagemCoelhos = (double)qtdC / total * 100.0;
            double porcentagemRatos = (double)qtdR / total * 100.0;
            double porcentagemSapos = (double)qtdS / total * 100.0;

            Console.WriteLine($"Total: {qtdC + qtdR + qtdS} cobaias");
            Console.WriteLine($"Total de coelhos: {qtdC}");
            Console.WriteLine($"Total de ratos: {qtdR}");
            Console.WriteLine($"Total de sapos: {qtdS}");
            Console.WriteLine($"Percentual de coelhos: {porcentagemCoelhos.ToString("F2")} %");
            Console.WriteLine($"Percentual de ratos: {porcentagemRatos.ToString("F2")} %");
            Console.WriteLine($"Percentual de sapos: {porcentagemSapos.ToString("F2")} %");
        }
    }
}