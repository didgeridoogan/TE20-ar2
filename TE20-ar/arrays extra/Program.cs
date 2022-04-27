using System;

namespace arrays_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Program for listing countries!");

            //Array of country names
            string[] countries = {"Andorra", "Afghanistan", "Antigua", "Bulgarien", "Vitryssland", "Benin", "Chile", "Kina", "Dominikanska republiken", "Eritrea", "Indonesien", "Kirgizistan", "Liechenstein", "Madagaskar", "Papua New Guinea"};

            //maxlength for names to output
            int maxLength = 0; //man vill inte hårdkoda

            //Users inputs maxLength
            Console.WriteLine("Please input max length: ");
            maxLength = InputInt();

            //Output all countries
            foreach (var country in countries)
            {
                if (country.Length <= maxLength)
                {
                    Console.WriteLine($"* {country}");
                }
            }
        }

        //Method for inputting an int
        static int InputInt()
        {
            int max = 0;
            while (!int.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine("Du måste mata ett heltal, försök igen: ");
            }
            return max;
        }
    }
}
