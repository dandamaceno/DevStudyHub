using System;
using System.Globalization;

namespace uri1009
{
    class URI
    {
        static void Main(string[] args)
        {

            string nome;
            double salario, vendas, comissao;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario += vendas * 0.15;

            Console.WriteLine("TOTAL = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}