using System;

namespace TP_frågor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slumpa fram en fråga!");

        // Namnge korten (array)
            string[] korten = {
            "När uppfördes Verdi?",             // 0
            "Vem vann fotbolls-EM 1984",        // 1
            "Vem skrev Frankenstein?",          // 2
            "Vad är 5+5?",                      // 3
            "När startades WW2?",               // 4
            "Vem är USAs nuvarande president?", // 5
            };

            // Kasta tärningen
            Random tärning = new Random();
            int slumptal = tärning.Next(0, 6); // 0 till 5

            // Skriver utslaget
            Console.WriteLine($"Tärningen slog {slumptal}");

            // Skriv ut fråga 
            Console.WriteLine($"Frågan: {korten[slumptal]}");    
        }
    }
}
