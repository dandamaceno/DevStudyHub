using System;
using System.Globalization;

namespace uri1008
{
    class URI
    {
        static void Main(string[] args)
        {

            int number, hours;
            double cost,salary;

            number = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            cost = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = hours * cost;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}