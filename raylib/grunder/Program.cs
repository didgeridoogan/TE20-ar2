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

                //Rita Ukrainas flagga
                Raylib.DrawRectangle(100,100,600,400,Color.YELLOW);
                Raylib.DrawRectangle(100,100,600,200,Color.BLUE);

                //Rita en fin cirkel
                Raylib.DrawCircle(400,300,100,Color.GOLD);

                //Rita text
                Raylib.DrawText("Hallå där!",100,500,50, Color.DARKBLUE);

                //Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
