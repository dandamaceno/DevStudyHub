using System;
using System.Globalization;

namespace uri1051
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario, impostoDevido;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.0)
            {
                impostoDevido = 0.0;
            }
            else if (salario <= 3000.0)
            {
                impostoDevido = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                impostoDevido = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            } 
            else
            {
                impostoDevido = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (impostoDevido == 0)
            {
                Console.WriteLine("Isento");
            } 
            else            
            {
                Console.WriteLine("R$ " + impostoDevido.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}