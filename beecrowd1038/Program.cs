using System;
using System.Globalization;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {

            int codigo, quantidade;

            double precoLanche, precoFinal;

            string[] entrada = Console.ReadLine().Split(' ');

            codigo = int.Parse(entrada[0]);
            quantidade = int.Parse(entrada[1]);

            switch (codigo) {
                case 1:
                    precoLanche = 4.00;
                    break;
                case 2:
                    precoLanche = 4.50;
                    break;
                case 3:
                    precoLanche = 5.00;
                    break;
                case 4:
                    precoLanche = 2.00;
                    break;
                case 5:
                    precoLanche = 1.50;
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    return;
            }

            precoFinal = (double)precoLanche * quantidade;

            Console.WriteLine("Total: R$ " +  precoFinal.ToString("F2", CultureInfo.InvariantCulture));
             
        }
    }
}
