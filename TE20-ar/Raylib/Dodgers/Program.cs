using System;
using Raylib_cs;

namespace Dodgers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 600;

            Raylib.InitWindow(fönsterB, fönsterH, "Snöflingor");
            Raylib.SetTargetFPS(60);

            // TODO: Infoga variabler och objekt här
            //Game state variabler
            int poäng = 0;
            int liv = 3;
            float tid = 0;
            int hastighet = 3;

            Random generator = new Random();
            Rectangle mynt = new Rectangle(400, 0, 50, 50);
            Rectangle spelare = new Rectangle(100, fönsterH - 50, 100, 10);
            Rectangle monster = new Rectangle(400,0,50,50);
            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------

                //Räkna upp tiden
                tid += Raylib.GetFrameTime();
                if (tid > 30)
                {
                    hastighet++;
                }

                //Hastigheter och nedre gräns
                mynt.y += hastighet;
                if (mynt.y > fönsterH)
                {
                    mynt.y = -100;
                    mynt.x = generator.Next(0, fönsterB);
                }

                monster.y += hastighet;
                if (monster.y > fönsterH)
                {
                    monster.y = -100;
                    monster.x = generator.Next(0,fönsterB);   
                }

                //Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    if (spelare.x > 0)
                    {
                       spelare.x -= 8; 
                    }
                }
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    if (spelare.x < fönsterB - 100)
                    {
                        spelare.x += 8;
                    }
                }

                //Om spelaren träffar ett mynt
                if (Raylib.CheckCollisionRecs(spelare, mynt))
                {
                    mynt.y = 0;
                    mynt.x = generator.Next(0, fönsterB);
                    poäng += 5;
                }

                //Om spelaren träffar ett monster
                if (Raylib.CheckCollisionRecs(spelare, monster))
                {
                    monster.y = 0;
                    monster.x = generator.Next(0, fönsterB);
                    liv--;
                }
                //----------------------------------------------------------------------------------

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawRectangleRec(mynt, Color.VIOLET);
                Raylib.DrawRectangleRec(spelare, Color.DARKPURPLE);
                Raylib.DrawText($"Poäng: {poäng} Liv: {liv} Tid: {(int)tid}", 10, 10, 20, Color.BLUE);

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}