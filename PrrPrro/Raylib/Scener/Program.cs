using System;
using Raylib_cs;

namespace Scener
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1600, 1000, "Mitt Raylib fönster");
            Raylib.SetTargetFPS(60);

            Rectangle player = new Rectangle(100, 900, 193, 50);
            Rectangle ball = new Rectangle(50, 50, 110, 50);
            Texture2D DVD = Raylib.LoadTexture(@"./resources/DVD.png");
            Texture2D wii = Raylib.LoadTexture(@"./resources/wii.png");
            float velX = 4;
            float velY = 4;
            int points = 0;
            int scene = 1;
            float sec = 10;

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                

                if(scene==1){
                    Raylib.DrawRectangleRec(player, Color.RED);
                    Raylib.DrawRectangleRec(ball, Color.GREEN);
                    Raylib.DrawText($"{points}", 10, 50, 50, Color.RED);
                    Raylib.DrawTexture(DVD, (int)ball.x, (int)ball.y, Color.WHITE);
                    Raylib.DrawTexture(wii, (int)player.x, (int)player.y, Color.WHITE);

                    Raylib.EndDrawing();

                    if (ball.x < 5) velX *= -1;
                    if (ball.y < 5) velY *= -1;
                    if (ball.x > 1495) velX *= -1;
                    if (ball.y > 845) if (ball.y > 950)
                        {
                            scene=0;
                        }
                        else if (ball.x > (player.x - 5) && ball.x < (player.x + 105))
                        {
                            velY *= -1;
                            points++;
                        }

                    ball.x += velX;
                    ball.y += velY;
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) player.x += 5;
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) player.x -= 5;
                }else if(scene==0){
                    Raylib.DrawText($"There was a problem\nwith the disk.\nShutting down in\n{Math.Round(sec)}", 300, 200, 100, Color.RED);
                    Raylib.EndDrawing();
                    if(sec <= 0)scene=2;
                    sec-=Raylib.GetFrameTime();
                }else if(scene==2){
                    Raylib.ClearBackground(Color.BLACK);
                    Raylib.EndDrawing();
                }

                
            }
        }            
    }
}
