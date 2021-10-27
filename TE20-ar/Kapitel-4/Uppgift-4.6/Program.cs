using System;

namespace Uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Detta är ett meddelande";

            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}