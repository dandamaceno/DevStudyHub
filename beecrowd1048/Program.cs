using System;
using System.Globalization;

namespace uri1048
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario, percentual, newSalario, reajuste;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                percentual = 0.15;
            }
            else if (salario <= 800)
            {
                percentual = 0.12;
            }
            else if (salario <= 1200.0)
            {
                percentual = 0.10;
            }
            else if (salario <= 2000.0)
            {
                percentual = 0.07;
            }
            else
            {
                percentual = 0.04;
            }

            newSalario = salario * (1 + percentual);
            reajuste = salario * percentual;

            Console.WriteLine("Novo salario: " + newSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + (percentual*100).ToString("F0") + " %");

        }
    }
}
