using System;

namespace Uppgift_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Vilket är världens största språk?");
            string svar = Console.ReadLine();
            while (svar != "Mandarin kinesiska")
            {
                Console.WriteLine("Du svarade fel, försök igen");
                svar = Console.ReadLine();
            }

            Console.WriteLine("Grattis! Du svarade rätt!");
        }
    }
}
