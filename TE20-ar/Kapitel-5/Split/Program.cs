using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Räkna ord");

            Console.Write("Ange en mening: ");
            string mening = Console.ReadLine();
            
            //Dela upp för att hitta alla ord
            //Split = sax
            string[] orden = mening.Split(' ');

            //Skriv ut alla ord på varsin rad
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
            }

            //Hur många ord finns det i arrayen?
            Console.WriteLine($"Antal ord i din mening är {orden.Length}");

            //Sätt samman en ny mening
            string nyMening  = string.Join('/', orden);

            //Skriv ut den nya meningen
            Console.WriteLine(nyMening);

        }
    }
}
