using System;

namespace Uppgift5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string[] städer = new string[3];
            städer[0] = "Göteborg";
            städer[1] = "Stockholm";
            Console.WriteLine($"Skriv in namnet på en svensk stad som inte är {städer[0]} eller {städer[1]}");
            städer[2] = Console.ReadLine();

            Console.WriteLine("Här är tre svenska städer - ");
            Console.WriteLine($"{städer[0]}, {städer[1]} och {städer[2]}");

        }
    }
}