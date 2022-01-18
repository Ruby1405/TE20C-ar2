using System;
using Raylib_cs;

namespace Bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");
            Raylib.SetTargetFPS(60);
            Texture2D bus = Raylib.LoadTexture(@"./resources/bus.png");

            while(!Raylib.WindowShouldClose()){
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.LIGHTGRAY);

                Raylib.DrawTexture(bus,10,10,Color.WHITE);

                Raylib.EndDrawing();
            }
        }
    }
}
