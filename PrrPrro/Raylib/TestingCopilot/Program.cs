using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace RaylibTest
{
    class Player
    {
        public Vector2 position;
        public Vector2 velocity;
    }
    class Program
    {
        static public Vector2 screenDimensions = new Vector2(800, 600);
        static void Main(string[] args)
        {
            Raylib.InitWindow((int)screenDimensions.X, (int)screenDimensions.Y, "Raylib Test");
            Raylib.SetTargetFPS(60);
            Player player1 = new Player();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    player1.velocity.X += 0.1f;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    player1.velocity.X -= 0.1f;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W)&&player1.position.Y>=screenDimensions.Y-100)
                {
                    player1.velocity.Y -= 5f;
                }
                if (player1.position.Y < screenDimensions.Y - 100)
                {
                    player1.velocity.Y += 1;
                }
                else
                {
                    player1.position.Y = screenDimensions.Y - 100;
                    if (player1.velocity.Y > 0)
                    {
                        player1.velocity.Y = 0;
                    }
                    player1.velocity.Y = 0;
                }
                player1.position += player1.velocity;
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawRectangle((int)player1.position.X, (int)player1.position.Y, 100, 100, Color.RED);
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}