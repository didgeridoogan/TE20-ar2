using System;

namespace ReadInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datorn godkänner inte förrän du skrivit in ett tal. 
            Console.WriteLine("Ange ett tal: ");
            int tal1, heltal;
            while (int.TryParse(Console.ReadLine(), out heltal) == false)
            {
                Console.WriteLine("Du skrev inte in ett heltal, försök igen.");
            }
            tal1 = heltal;

            Console.WriteLine("Ange ett tal 2: ");
            int tal2;
            while (int.TryParse(Console.ReadLine(), out heltal) == false)
            {
                Console.WriteLine("Du skrev inte in ett heltal, försök igen.");
            }
            

            //Annat
            static int ReadInt()
            {
                int heltal;
                while (int.TryParse(Console.ReadLine(), out heltal) == false)
                {
                    Console.WriteLine("Du skrev inte in ett heltal, försök igen");
                }
                return heltal;
            }
        }
    }
}
