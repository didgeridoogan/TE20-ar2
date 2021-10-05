using System;

namespace GissaEttTal2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spelet Gissa ett tal!");

            // Slumpa fram ett tal
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 51);

            // Loopa 5 gånger
            int räknare = 6;
            while (true)
            {
                //Räkna upp varv
                räknare++;

                // Bryt efter 5 varv
                if (räknare >= 5)
                {
                    break;
                }

            // Fråga användaren om en gissning
            Console.Write("Gissa ett tal (1-100): ");
            int gissning = int.Parse(Console.ReadLine());

            // Är gissningen rätt?
            if (gissning == slumptal)
            { 
                Console.WriteLine($"Bra gissat! Du gjorde det på {räknare} försök");
                break;
            }

            //Jämför med slumptal
            if (gissning < slumptal)
            {
                Console.WriteLine("För lågt!");
            }
            else
            {
                Console.WriteLine("För högt!");
            }
            }
            }
            }

        }
