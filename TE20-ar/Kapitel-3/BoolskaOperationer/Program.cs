using System;

namespace BoolskaOperationer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coronasymptom");

            Console.Write("Har du feber? (j/n) ");
            string feber = Console.Readline();

            Console.Write("Hostar du? (j/n) ");
            string hosta = Console.Readline();

            Console.Write("Har du tappat smaken? (j/n) ");
            string smak = Console.Readline();

            //Om dessa 3 villkor är uppfyllda
        
             if (feber == "ja" || hosta == ja" && smak == "ja")
            {
                Console.WriteLine("Du har troligen Covid-19");
            }

        }
    }
}
