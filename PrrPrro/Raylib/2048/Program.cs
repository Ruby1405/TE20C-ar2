using System;
using Raylib_cs;

namespace _2048
{
    class Program
    {
        static void Main(string[] args)
        {
            const int windowX=800;
            const int windowY=800;
            Raylib.InitWindow(windowX,windowY,"Board");
            Raylib.SetTargetFPS(60);

            Random generator = new Random();

            int[,] cell = new int[4,4];

            
            for (var i = 0; i < cell.GetLength(0); i++)
            {
                for (var j = 0; j < cell.GetLength(1); j++)
                {
                    cell[i,j]=0;
                }
            }


            while(!Raylib.WindowShouldClose()){
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.EndDrawing();
            }
        }
    }
}
