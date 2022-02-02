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
                    cell[i,j]=i+j;
                }
            }


            while(!Raylib.WindowShouldClose()){
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                

                for (var i = 0; i < cell.GetLength(0); i++){for (var j = 0; j < cell.GetLength(1); j++){
                    if(cell[i,j]>0)
                    {
                        Raylib.DrawRectangle(i*200,j*200,200,200,Color.DARKBLUE);
                        Raylib.DrawText($"{Math.Pow(2,cell[i,j])}",5+i*200,75+j*200,50,Color.WHITE);
                }}}
                Raylib.EndDrawing();
}}}}
