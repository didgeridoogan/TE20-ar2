using System;

namespace Uppgift5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] talLista = { 432, 231, 32, -123, 20 };

            int summa = 0;

            foreach (int tal in talLista)
            {
                summa += tal;
            }

            Console.WriteLine($"Summan av talen är {summa}");

        }
    }
}