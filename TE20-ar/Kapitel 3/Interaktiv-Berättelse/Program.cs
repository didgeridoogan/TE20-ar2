﻿using System.Text;
using System;
 
namespace Interaktiv_Berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.Write("Interaktiv berättelse. Du är en liten råtta vid namn August. Du måste snabbt fly hem innan det blir morgon så att du kan sno din husägares ost. ");
 
            Console.WriteLine("Först, väljer du att gå åt höger eller vänster? (vänster/höger) ");
            string answer1 = Console.ReadLine();
            if (answer1 == "vänster")
            {
                Console.Write("Du stötte på katten Gustav, han åt upp dig för han trodde du var lasagne :( Du tror att du är död, men du lever faktiskt inuti katten! Detta betyder att du lätt och snabbt kan bryta dig in i huset nu medans du gömmer dig i Gustav...");
                Console.WriteLine(" Du lyckades till slut komma ur katten och är nu inuti köket. Väljer du att leta efter osten i kylskåpet eller på bordet? (kylskäpet/bordet) ");
                string answer2 = Console.ReadLine();
 
                if (answer2 == "kylskåpet")
                {
                     Console.WriteLine("Den var inte där, Kim! Kylskåpsdörren stängdes bakom dig och du frös till döds. Må du vila i frid...");
                    Console.WriteLine("THE END");
                }
                else
                {
                    Console.WriteLine("Du hittade osten på bordet tur nog! Nu får du äntligen njuta av ditt hårda arbete och käka lite smarrig pastoriserad mjölk, grattis! 🤪");
                    Console.WriteLine("THE END");
                }
 
            }
            else
            {
              
              Console.Write("Mot höger hittade du en annan råtta med samma mål som du. Vad vill du göra med denna nyfunna råttan...?");
              Console.Write(" Överge eller bli vän? (överge/vän) ");  
              string answer3 = Console.ReadLine();
              if (answer3 == "överge")
              {
                  Console.WriteLine("Du lyfter upp din fellow råtta och kastar honom åt motsatt håll du kom från! Men, det fanns tydligen en katt där! Råttan du kastade sprang fram till dig och kastade istället dig som, nu blev istället du offret!  Du är död snart...");
                  Console.WriteLine("THE END");
              }
              else
              {
                System.Console.WriteLine("Han valde istället att överge dig och använda dig som ett offer till en katt som tydligen gömde sig i mörkret! Åh nej, du är död!");
                Console.WriteLine("THE END");
          
              }
            }
        }
    }
    
}
 
