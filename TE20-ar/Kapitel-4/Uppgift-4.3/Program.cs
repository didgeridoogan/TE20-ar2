using System;

namespace Uppgift_4._3{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket är Europas minsta land (även världens minsta)?");
            string svar = Console.ReadLine();
            int antalGissningar = 1;

            while (svar != "Vatikanstaten")
            {
                if (antalGissningar >= 5)
                {
                    Console.WriteLine("Dina gissningar är tyvärr slut");
                    break;
                }
                Console.WriteLine("Fel svar, försök igen");
                svar = Console.ReadLine();
                antalGissningar++;
            }

            if (svar == "Vatikanstaten")
            {
                Console.WriteLine("Ditt svar är rätt, bra jobbat!");
            }

        }
    }
}