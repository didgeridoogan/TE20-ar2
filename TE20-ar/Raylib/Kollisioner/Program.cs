using System;
using Raylib_cs;

namespace Kollisioner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiera grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");
            Raylib.SetTargetFPS(60);

            //Några variabler
            int hastighet = 5;
            int poäng = 0;
            int timer = 0;
            Random generator = new Random();

            /* Skapa objekt */
            Rectangle spelare = new Rectangle(100, 100, 50, 50);
            Rectangle fiende = new Rectangle(
                generator.Next(400, 720), 
                generator.Next(0, 520), 
                80, 80);

        
            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                //Räkna antalet frames
                timer++;

                //Avbryt spelet efter 60 sekunder
                if (timer > 3600)
                {
                    Raylib.DrawText("Game Over", 200, 200, 100, Color.DARKGREEN);
                }
                
                /* Rita ut grafiken */
                // Börja rita
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                // Rita ut objekt
                Raylib.DrawRectangleRec(fiende, Color.BLUE);
                Raylib.DrawRectangleRec(spelare, Color.DARKBLUE);

                // Visa poängen
                Raylib.DrawText($"Poäng {poäng}", 200, 100, 50, Color.DARKGREEN);

                //Upptäcka kollision
                if (Raylib.CheckCollisionRecs(spelare, fiende)) 
                {
                    poäng += 1;
                    // Spawna om fiende med slump
                    fiende.x = generator.Next(400, 720);
                    fiende.y = generator.Next(0, 520);
                }

                // Ritat ut på fönstret
                Raylib.EndDrawing();

                /* Interaktion med användare */
                // Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += hastighet;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= hastighet;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += hastighet;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= hastighet;
                }
            }
        }
    }
}