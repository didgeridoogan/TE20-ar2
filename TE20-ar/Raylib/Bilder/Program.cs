using System;
using Raylib_cs;

namespace Bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            // Ladda in bilden
            Texture2D bug = Raylib.LoadTexture(@"./resurser/bug.png");

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.DARKGRAY);

                // Rita ut bilder
                Raylib.DrawTexture(bug, 100, 100, Color.WHITE);

                // Ritat ut på fönstret
                Raylib.EndDrawing();
            }
        }
    }
}