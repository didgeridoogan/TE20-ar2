using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Lägg in dina ordval");

            Console.WriteLine("Skriv in ett adjektiv: ");
            string adjektiv = Console.ReadLine();

            Console.WriteLine("Plats ");
            string plats = Console.ReadLine();

            Console.WriteLine("Relation ");
            string relation = Console.ReadLine();

            Console.WriteLine("Substantiv ");
            string substantiv = Console.ReadLine();

            Console.WriteLine("Namn ");
            string namn = Console.ReadLine();

            Console.WriteLine($"Det fanns en gång en {adjektiv} hund. Denna hund var på väg till {plats} för att träffa sin {relation} när han plötsligt såg en {substantiv}. {substantiv} använde sina laserögon för att spränga hunden, som förresten hette {namn}")
        }
    }
}
