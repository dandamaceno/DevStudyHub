using System;
using System.Globalization;

namespace uri1020
{
    class URI
    {
        static void Main(string[] args)
        {

            int idade, idadeDias, anos, meses, dias, resto;
            
            idadeDias = int.Parse(Console.ReadLine());

            anos = idadeDias / 365;
            resto = idadeDias % 365;

            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano (s)");
            Console.WriteLine(meses + " mes (es)");
            Console.WriteLine(dias + " dia (s)");

        }

    }
}