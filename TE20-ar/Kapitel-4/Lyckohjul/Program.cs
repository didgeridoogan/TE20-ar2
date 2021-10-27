using System;

namespace Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();

            Console.WriteLine("Välkommen till lyckohjulet!");
            Console.WriteLine("Välj ett tal från 1 - 10");
            int användarensTal = int.Parse(Console.ReadLine());
            int hjuletsTal = slump.Next(1, 11);

            Console.WriteLine($"Hjulet stannade på {hjuletsTal}");
            if (användarensTal == hjuletsTal)
            {
                Console.WriteLine("Du vann!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Du vann tyvärr inte. ");
            }
        }
    }
}