using System;
using Raylib_cs;

namespace _2048
{
    class Program
    {
        static int windowX=800;
        static int windowY=800;
        Random generator = new Random();

        static void Main(string[] args)
        { 
            Raylib.InitWindow(windowX,windowY,"Board");
            Raylib.SetTargetFPS(60);
            
            int test = 1;
            
            int[,] cell = new int[4,4];
            
            for (var i = 0; i < cell.GetLength(0); i++)
            {
                for (var j = 0; j < cell.GetLength(1); j++)
                {
                    cell[i,j]=j;
                }
            }


            while(!Raylib.WindowShouldClose()){
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                {
                    for (var j = 0; j < cell.GetLength(1); j++)
                    {
                        for (var i = cell.GetLength(0)-1; i > 0; i--)
                        {
                            if(cell[i,j]==0){
                                for (var k = 0; k <cell.GetLength(0)-2; k++)
                                {
                                    cell[i-k,j]=cell[i-k-1,j];
                                    cell[i-k-1,j]=0;
                                }
                            }
                        }
                    }
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                {
                    
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_UP))
                {
                    for (var i = 0; i < cell.GetLength(0); i++){for (var j = 0; j < cell.GetLength(1); j++){
                        
                    }}
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))
                {
                    for (var i = 0; i < cell.GetLength(0); i++){for (var j = 0; j < cell.GetLength(1); j++){
                        
                    }}
                }                

                for (var i = 0; i < cell.GetLength(0); i++){for (var j = 0; j < cell.GetLength(1); j++){
                    if(cell[i,j]>0)
                    {
                        Raylib.DrawRectangle(i*200+1,j*200+1,198,198,Color.DARKBLUE);
                        Raylib.DrawText($"{Math.Pow(2,cell[i,j])}",5+i*200+10,75+j*200,50,Color.WHITE);
                    }
                    Raylib.DrawText($"X{i} Y{j} Value{cell[i,j]}",5+i*200+10,120+j*200,20,Color.RED);
                }}
                Raylib.EndDrawing();
}}}}
