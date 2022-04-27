﻿using System;

namespace ovning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Kolla att användaren matar in ett tal eller inte
                Console.Write("Mata in ett tal 0-100: ");

                //Ger alltid en string
                string stringTal = Console.ReadLine();

                //Kolla om det går att omvandla från ett string till ett tal
                int tal = 0;
                //bool lyckadesParsa = int.TryParse(stringTal, out tal);

                if (int.TryParse(stringTal, out tal))
                {
                    Console.WriteLine("Ja, användaren matade ett tal");
                }
                else
                {
                    Console.WriteLine("Nej, användaren matade inte ett tal");
                }
            }
        }
    }
}
