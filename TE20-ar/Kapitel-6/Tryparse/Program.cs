using System;

namespace Tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Gissa ett tal");

            //Slumpgenerator
            Random generator = new Random();

            //Slumpa fram ett tal
            int slumptal = generator.Next(1,101);
            int slumptal2 = generator.Next(1,11);

            //Försök översätta det inmatade till ett tal
            int gissningTal = 0;
            bool korrekt = false;

            //Loopa för att tvinga spelaren att matta in något korrekt
            while (korrekt != true)
            {
                Console.Write("Gissa ett tal (1-100)");
                string gissning = Console.ReadLine();
                korrekt = int.TryParse(gissning, out gissningTal);
            }
            
            //Var gissning korrekt
            if (gissningTal == slumptal)
            {
                Console.WriteLine("Du gissade rätt!");
            }
            else 
            {
                Console.WriteLine("Du gissade fel!");
            }
        }
    }
}
