using System.Collections.ObjectModel;
using System;

namespace ovning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en string-array med namnen på fem olika leksaker
            string[] leksaker = {"boll", "racket", "hopprep","sak 1", "sak 2"};

            //Alternativ 1: Skriv ut innehållet i arrayen
            for (int i = 0; i < leksaker.Length; i++) //Length i denna string visar att man inte behöver "hårdkoda"
            {
                Console.WriteLine(leksaker[i]); //leksaker[0] = "boll"
            }

            //Alternativ 2
            foreach (var leksak in leksaker)
            {
                Console.WriteLine(leksak);
            }
        }
    }
}
