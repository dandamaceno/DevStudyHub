using System;
using System.Globalization;

namespace uri1072
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, dentro, fora;

            n = int.Parse(Console.ReadLine());

            dentro = 0;
            fora = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    dentro ++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");

        }
    }
}