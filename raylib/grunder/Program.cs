using System;
using Raylib_cs;

namespace grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Raylib!");

            //Starta ett fönster
            Raylib.InitWindow(800,600,"Ett Raylib fönster");

            //Ställ in fps
            Raylib.SetTargetFPS(60);

            //En egen färg
            Color GoldenRed = new Color(218,165,32,170);

            //Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                //Börja rita
                Raylib.BeginDrawing();

                //Tömma ritytan
                Raylib.ClearBackground(Color.GRAY);

                //Rita flagga
                Raylib.DrawRectangle(100,100,600,400,Color.DARKBLUE);

                //Rita en fin halvmåne
                Raylib.DrawCircle(350,300,100,Color.WHITE);
                Raylib.DrawCircle(400,300,100,Color.DARKBLUE);

                //Rita text
                Raylib.DrawText("Hallå där!",100,500,50, Color.WHITE);

                //Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
