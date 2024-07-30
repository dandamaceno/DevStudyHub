using System;
using System.Globalization;

namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] entrada = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(entrada[0]);
            int minutoInicial = int.Parse(entrada[1]);
            int horaFinal = int.Parse(entrada[2]);
            int minutoFinal = int.Parse(entrada[3]);

            int instanteInicial = horaInicial * 60 + minutoInicial;
            int instanteFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if(instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            } 
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

        }
    }
}