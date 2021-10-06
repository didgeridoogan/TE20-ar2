using System;

namespace Prov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();

            Console.Write("Ange din bruttolön: ");  
            int brutto = int.Parse(Console.ReadLine());
            if (brutto < 10000 || brutto > 45000)
            {
                Console.WriteLine($"{namn}, bruttolön måste vara mellan 10000-45000!");
            }

            else
            {
            Console.Write("Ange din skattesats i %: ");
            int skattesats = int.Parse(Console.ReadLine());

            if (skattesats < 10 || skattesats > 45 )
            {
                Console.WriteLine($"{namn}, skattesatsen måste vara mellan  10-45%!");
            }
            
            else
            {
                Console.WriteLine($"{namn}, din nettolön blir {brutto * (100 - skattesats) /100}. Baserat på bruttolön {brutto} och skattesatsen {skattesats}%");
            }
            }
            
        }
    }
}
