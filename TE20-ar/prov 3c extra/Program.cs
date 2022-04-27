using System;

namespace prov_3c_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in din epost: ");
            string epost = Console.ReadLine();
            
            //Kolla att texten innehåller @
            if (epost.Contains("@"))
            {
                Console.WriteLine("Det verkar som du skrivit in en korrekt epost adress");
            }

            //1 + 2 + 3, 2 * 6, 10 / 3
            Console.Write("Mata in ett mattetal: ");
            string mattetal = Console.ReadLine();
            
            //Berätta om : + eller * eller / har använts
            bool flagga = false;
            if (mattetal.Contains("+"))
            {
                Console.WriteLine("Du använder operator +");
                flagga = true;
            }
            if (mattetal.Contains("-"))
            {
                Console.WriteLine("Du använder operator -");
            }
            if (flagga == true)
            {
                Console.WriteLine("Du använder *, -, /");
            }
        }
    }
}