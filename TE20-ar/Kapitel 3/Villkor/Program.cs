using System;

namespace Villkor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren om ålder
            Console.Write("Hur gammal är du? (heltal)");
            int ålder = int.Parse(Console.ReadLine());

            // Om ålder större än 18 "Du får ta körkort"
            if (ålder >= 18)
            {
                Console.WriteLine("Du får ta körkort!");
            }

            // Om ålder är 15 eller högre -> "Du får ta mopedkörkort!"
            if (ålder >= 15)
            {
                Console.WriteLine("Du får ta mopedkörkort!");
            }

            // Fråga användaren "Vad heter ABBAs senaste album?"
            Console.WriteLine("Vad heter ABBAs senaste album?");
            string album = Console.ReadLine();
            
            // Är svaret korrekt?
            if (album == "Voyage" || album == "voyage")
            {
                Console.WriteLine("Bra svarat!");
            }
            else
            {
                Console.WriteLine("Fel svar! Albumet heter Voyage...");
            }

            // Sista TP-fråga
            Console.Write("Vem missade straffet i matchen England V Frankrike? (efternamn)");
            
            // Läs in och tvinga till små bokstäver. Mbappe -> mbappe/ mBappe -> mbappe
            string spelare = Console.ReadLine().ToLower();
            
            if (spelare == "Mbappe")
            {
                Console.WriteLine("Bra, du är en expert!");
            }
            else
            {
                Console.WriteLine("Dåligt, du är sämst! Det var Mbappe");
            }

        }
    }
}
