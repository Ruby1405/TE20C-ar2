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

            Rectangle player = new Rectangle(100,500,100,50);
            Rectangle ball = new Rectangle(50,50,10,10);
            float velX = 4;
            float velY = 4;

            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawRectangleRec(player, Color.RED);
                Raylib.DrawRectangleRec(ball, Color.GREEN);

                Raylib.EndDrawing();

                if(ball.x<5) velX *=-1;
                if(ball.y<5) velY *=-1;
                if(ball.x>795) velX *=-1;
                if(ball.y>495)if(ball.y>550)ball.y=5;else if(ball.x>(player.x-5) && ball.x<(player.x+105))velY *=-1;
                ball.x += velX;
                ball.y += velY;
                if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) player.x += 5;
                if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) player.x -= 5;
            }
        }
    }
}
