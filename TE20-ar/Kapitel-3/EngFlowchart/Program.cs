﻿using System.Text;
using System;

namespace EngFlowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("Engineering flowchart");

            Console.Write("Does it move? (y/n) ");
            string answer1 = Console.ReadLine();
            if (answer1 == "y")
            {
                Console.Write("Should it? (y/n) ");
                string answer2 = Console.ReadLine();

                if (answer2 == "y")
                {
                     Console.WriteLine("No problem! 😀");
                }
                else
                {
                    Console.WriteLine("Use duct tape! 🤪");
                }

            }
            else
            {
              Console.Write("Should it? (y/n) ");  
              string answer3 = Console.ReadLine();
              if (answer3 == "n")
              {
                  Console.WriteLine("No problem! 😀");
              }
              else
              {
                System.Console.WriteLine("Use WD-40! 🤪");  
              }
            }
        }
    }
    
}
