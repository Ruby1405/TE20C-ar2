using System;
using Raylib_cs;

namespace _2048
{
    class Program
    {
        static int windowX=800;
        static int windowY=800;
        static void Main(string[] args)
        { 
            Raylib.InitWindow(windowX,windowY,"Board");
            Raylib.SetTargetFPS(60);
            
            int test = 1;
            
            Random generator = new Random();
            
            int[,] cell = new int[4,4];
            
            for (var i = 0; i < cell.GetLength(0); i++)
            {
                for (var j = 0; j < cell.GetLength(1); j++)
                {
                    cell[i,j]=0;
                }
            }

            cell[generator.Next(cell.GetLength(0)),generator.Next(cell.GetLength(1))]=1;


            while(!Raylib.WindowShouldClose()){
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                bool moved = false;

                if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                {
                    for (var j = 0; j < cell.GetLength(1); j++)
                    {
                        for (var k = cell.GetLength(0)-1; k > 0; k--)
                        {
                            if(cell[k,j]!=0)
                            {
                                var i = 1;
                                while(cell[k-i,j]==0)
                                {
                                    if(k-i-1>=0)i++;
                                    else break;
                                }
                                if(cell[k,j]==cell[k-i,j])
                                {
                                    cell[k,j]++;
                                    cell[k-i,j]=0;
                                    moved = true;
                                }
                            }
                        }
                    }
                    for (var i = 0; i < cell.GetLength(0); i++)
                    {
                        for (var j = 0; j < cell.GetLength(1); j++)
                        {
                            for (var k = cell.GetLength(0)-1; k > 0; k--)
                            {
                                if(cell[k,j]==0){
                                    cell[k,j]=cell[k-1,j];
                                    cell[k-1,j]=0;
                                    moved = true;
                                }
                            }
                        }
                    }
                    
                    while(moved)
                    {
                        var i = generator.Next(cell.GetLength(0));
                        var j =generator.Next(cell.GetLength(1));
                        if(cell[i,j]==0)
                        {
                            cell[i,j]=1;
                            break;
                        }
                    }
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                {
                    for (var j = 0; j < cell.GetLength(1); j++)
                    {
                        for (var k = 1; k < cell.GetLength(0); k++)
                        {
                            if(cell[k,j]!=0)
                            {
                                var i = 1;
                                while(cell[k+i,j]==0)
                                {
                                    if(k+i+1>=0)i++;
                                    else break;
                                }
                                if(cell[k,j]==cell[k+i,j])
                                {
                                    cell[k,j]++;
                                    cell[k+i,j]=cell.GetLength(0);
                                    moved = true;
                                }
                            }
                        }
                    }
                    for (var i = 0; i < cell.GetLength(0); i++)
                    {
                        for (var j = 0; j < cell.GetLength(1); j++)
                        {
                            for (var k = 1; k < cell.GetLength(0); k++)
                            {
                                if(cell[k,j]==0){
                                    cell[k,j]=cell[k+1,j];
                                    cell[k+1,j]=0;
                                    moved = true;
                                }
                            }
                        }
                    }
                    
                    while(moved)
                    {
                        var i = generator.Next(cell.GetLength(0));
                        var j =generator.Next(cell.GetLength(1));
                        if(cell[i,j]==0)
                        {
                            cell[i,j]=1;
                            break;
                        }
                    }
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_UP))
                {
                    while(moved)
                    {
                        var i = generator.Next(cell.GetLength(0));
                        var j =generator.Next(cell.GetLength(1));
                        if(cell[i,j]==0)
                        {
                            cell[i,j]=1;
                            break;
                        }
                    }
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))
                {
                    while(moved)
                    {
                        var i = generator.Next(cell.GetLength(0));
                        var j =generator.Next(cell.GetLength(1));
                        if(cell[i,j]==0)
                        {
                            cell[i,j]=1;
                            break;
                        }
                    }
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
