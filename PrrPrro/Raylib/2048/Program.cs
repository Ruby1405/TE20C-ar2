using System;
using System.Numerics;
using System.Collections.Generic;
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
            
            bool gameover = false;

            int test = 1;
            
            Random generator = new Random();
            
            int[,] cell = new int[4,4];
            
            for (var i = 0; i < cell.GetLength(0); i++)
            {
                for (var j = 0; j < cell.GetLength(1); j++)
                {
                    cell[i,j]=j;
                }
            }

            //cell[generator.Next(cell.GetLength(0)),generator.Next(cell.GetLength(1))]=1;


            while(!Raylib.WindowShouldClose()){
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                bool moved = false;

                if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT)) //Right key press
                {
                    for (var j = 0; j < cell.GetLength(1); j++) //Cycle through rows top to bottomm
                    {
                        for (var k = cell.GetLength(0)-1; k > 0; k--) //Cycle through columns from left to right skipping 0
                        {
                            if(cell[k,j]!=0) //If cell isn't equal to 0 define i as 1
                            {
                                var i = 1;
                                while(cell[k-i,j]==0) //While cell[k-i,j] is 0 ([k-i,j] is the next cell from [k,j])
                                {
                                    /*Catches for index out of range exception, 
                                    if the next cell to be checked is outside of the array it won't attempt it.*/
                                    if(k-i-1>=0)i++; 
                                    else break;
                                }
                                /*If the while loop either stops because it's found a value not equal to 0 or if it breaks
                                check if the cells are equal and in that case combine them and tell the system movement occured.*/
                                if(cell[k,j]==cell[k-i,j]) 
                                {
                                    cell[k,j]++;
                                    cell[k-i,j]=0;
                                    moved = true;
                                }
                            }
                        }
                    }
                    for (var i = 0; i < cell.GetLength(0); i++) //Cycle through columns, left to right
                    {
                        for (var j = 0; j < cell.GetLength(1); j++) //Cycle through rows top to bottom
                        {
                            for (var k = cell.GetLength(0)-1; k > 0; k--) //Cycles through cells on the same row
                            {
                                /*If the cell equal to 0 then if the previous cell in the movement direction isn't equal to 0
                                tell the system movement occured*/
                                if(cell[k,j]==0){
                                    if(cell[k-1,j]!=0)moved = true;
                                    //Move the previous cell to this one
                                    cell[k,j]=cell[k-1,j];
                                    cell[k-1,j]=0;
                                }
                            }
                        }
                    }
                    //If movement ocurred set a random empty cell to 1
                    if(moved)
                    {
                        List<Vector2> emptyList = new List<Vector2>(); //Make a list of coordinates
                        for (var i = 0; i < cell.GetLength(0); i++) //Cycle through cell array
                        {
                            for (var j = 0; j < cell.GetLength(1); j++)
                            {
                                if(cell[i,j]==0) //If the cell = 0 add it to the vector list
                                {
                                    emptyList.Add(new Vector2(i, j));
                                }
                            }
                        }
                        int randomIndex = generator.Next(emptyList.Count); //Pick a random cell from the vector list and make it 1
                        cell[(int)emptyList[randomIndex].X, (int)emptyList[randomIndex].Y] = 1;
                    }
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                {
                    for (var j = 0; j < cell.GetLength(1); j++)
                    {
                        for (var k = 0; k < cell.GetLength(0)-1; k++)
                        {
                            /* cell[k,j]=test;
                            test++; */
                            if(cell[k,j]!=0)
                            {
                                var i = 1;
                                while(cell[k+i,j]==0) //While cell[k+i,j] is 0 ([k+i,j] is the next cell from [k,j])
                                {
                                    //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                                    if(k+i+1<=cell.GetLength(0)-1)i++; 
                                    else break;
                                }
                                //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them and tell the system movement occured.
                                if(cell[k,j]==cell[k+i,j]) 
                                {
                                    cell[k,j]++;
                                    cell[k+i,j]=0;
                                    moved = true;
                                }
                            }
                        }
                    }
                    for (var i = 0; i < cell.GetLength(0); i++)
                    {
                        for (var j = 0; j < cell.GetLength(1); j++)
                        {
                            for (var k = 0; k < cell.GetLength(0)-1; k++)
                            {
                                if(cell[k,j]==0){
                                    cell[k,j]=cell[k+1,j];
                                    cell[k+1,j]=0;
                                    moved = true;
                                }
                            }
                        }
                    }
                    
                    //If movement ocurred set a random empty cell to 1
                    if(moved)
                    {
                        List<Vector2> emptyList = new List<Vector2>(); //Make a list of coordinates
                        for (var i = 0; i < cell.GetLength(0); i++) //Cycle through cell array
                        {
                            for (var j = 0; j < cell.GetLength(1); j++)
                            {
                                if(cell[i,j]==0) //If the cell = 0 add it to the vector list
                                {
                                    emptyList.Add(new Vector2(i, j));
                                }
                            }
                        }
                        int randomIndex = generator.Next(emptyList.Count); //Pick a random cell from the vector list and make it 1
                        cell[(int)emptyList[randomIndex].X, (int)emptyList[randomIndex].Y] = 1;
                    }
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_UP))
                {
                    if(moved)
                    {
                        List<Vector2> emptyList = new List<Vector2>();
                        for (var i = 0; i < cell.GetLength(0); i++)
                        {
                            for (var j = 0; j < cell.GetLength(1); j++)
                            {
                                if(cell[i,j]==0)
                                {
                                    emptyList.Add(new Vector2(i, j));
                                }
                            }
                        }
                        int randomIndex = generator.Next(emptyList.Count);
                        cell[(int)emptyList[randomIndex].X, (int)emptyList[randomIndex].Y] = 1;
                    }
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))
                {
                    //If movement ocurred set a random empty cell to 1
                    if(moved)
                    {
                        List<Vector2> emptyList = new List<Vector2>(); //Make a list of coordinates
                        for (var i = 0; i < cell.GetLength(0); i++) //Cycle through cell array
                        {
                            for (var j = 0; j < cell.GetLength(1); j++)
                            {
                                if(cell[i,j]==0) //If the cell = 0 add it to the vector list
                                {
                                    emptyList.Add(new Vector2(i, j));
                                }
                            }
                        }
                        int randomIndex = generator.Next(emptyList.Count); //Pick a random cell from the vector list and make it 1
                        cell[(int)emptyList[randomIndex].X, (int)emptyList[randomIndex].Y] = 1;
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
