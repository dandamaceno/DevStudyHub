using System;
using System.Globalization;

namespace uri1049
{
    class Program
    {
        static void Main(string[] args)
        {

            string grupo1 = Console.ReadLine();
            string grupo2 = Console.ReadLine();
            string grupo3 = Console.ReadLine();
            string animal = "";

            if (grupo1 == "vertebrado")
            {
                if (grupo2 == "ave")
                {
                    if (grupo3 == "carnivoro")
                    {
                        animal = "aguia";
                    }
                    else
                    {
                        animal = "pomba";
                    }
                }
                else
                {
                    if (grupo3 == "onivoro")
                    {
                        animal = "homem";
                    }
                    else
                    {
                        animal = "vaca";
                    }
                }
            }
            else
            {
                if (grupo2 == "inseto")
                {
                    if (grupo3 == "hematofago")
                    {
                        animal = "pulga";
                    }
                    else
                    {
                        animal = "lagarta";
                    }
                }
                else
                {
                    if (grupo3 == "hematofago")
                    {
                        animal = "sanguessuga";
                    }
                    else
                    {
                        animal = "minhoca";
                    }
                }
            }

            Console.WriteLine(animal);

        }
    }
}