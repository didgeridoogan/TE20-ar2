using System;

namespace Lön
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ange löner
            Console.WriteLine("Skriv in månadslöner: " );
            int lön1 = int.Parse(Console.ReadLine());
            int lön2 = int.Parse(Console.ReadLine());
            int lön3 = int.Parse(Console.ReadLine());

            //Rökna ut medelvärdet
            float medelvärde = (lön1 + lön2 + lön3) / 3;

            //Skriv ut resultatet
            Console.Write($"Medellönen för alla är {medelvärde}");

        }
    }
}
