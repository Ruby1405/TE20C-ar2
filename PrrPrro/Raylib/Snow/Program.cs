using System;
using Raylib_cs;

namespace Snow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 1000;
            const int fönsterH = 800;

            Raylib.InitWindow(fönsterB, fönsterH, "Snöflingor");
            Raylib.SetTargetFPS(60);

            // TODO: Infoga variabler och objekt här

            Random generator = new Random();
            Rectangle[] snow = new Rectangle[1000];
            float wind = 0;
            float speed = 0;
            for (int i = 0; i < snow.Length;i++)
            {
                float size = generator.Next(2,20);
                snow[i] = new Rectangle(0,0,size,size);
                snow[i].x = generator.Next(-30,fönsterB+30);
                snow[i].y = generator.Next(-20,fönsterH);
            }

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                wind += (generator.Next(1,10)-5)/(float)10;
                if(wind*wind > 100)wind/=2;
                Console.WriteLine(wind);
                speed += (generator.Next(1,10)-5)/10;
                for (var i = 0; i < snow.Length; i++)
                {
                    snow[i].x += wind * snow[i].height/(float)20;
                    snow[i].y += (5 + speed)* snow[i].height/(float)20;
                    if(snow[i].y > fönsterH)
                    {
                        snow[i].y = -20;
                        snow[i].x = generator.Next(0,fönsterB);
                    }
                    if(snow[i].x > fönsterB+30)
                    {
                        snow[i].x = -20;
                        snow[i].y = generator.Next(0,fönsterH);
                    }else if (snow[i].x < -30)
                    {
                        snow[i].x = fönsterB+20;
                        snow[i].y = generator.Next(0,fönsterH);
                    }
                }
                

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKGRAY);

                for (var i = 0; i < snow.Length; i++)
                {
                    Raylib.DrawRectangleRec(snow[i], Color.WHITE);
                }

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}