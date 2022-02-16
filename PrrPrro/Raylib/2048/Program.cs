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
                         /* static void CellMerge(ref int[,] cell, ref int score, ref bool moved, int k, int j, int a, int b) 
        //cell is the cell array, score is the score int, moved is the moved bool, k and j are from the loops, a and b are for directions
        {
            if(cell[k,j]!=0) //If cell isn't equal to 0 define i as 1
            {
                var i = a+b;
                while(cell[k+a,j+b]==0) //While cell[k-i,j] is 0 ([k-i,j] is the next cell from [k,j])
                {
                    //Catches for index out of range exception, 
                    //if the next cell to be checked is outside of the array it won't attempt it.
                    if(a!=0)
                    {
                        if(k+a+i>=0)a++;
                        else break;
                    }
                    else
                    {
                        if(j+b+i>=0)b++;
                        else break;
                    }
                }
                //If the while loop either stops because it's found a value not equal to 0 or if it breaks
                //check if the cells are equal and in that case combine them and tell the system movement occured.
                if(cell[k,j]==cell[k+a,j+b]) 
                {
                    cell[k,j]++;
                    cell[k+a,j+b]=0;
                    moved = true;
                    score++;
                }
            }
        }*/
        static void Main(string[] args)
        { 
            Raylib.InitWindow(windowX,windowY,"2048");
            Raylib.SetTargetFPS(60);
            
            //bool gameover = false;

            int score = 0;

            //int test = 1;

            Color shade = new Color(0, 0, 0, 16);
            
            Random generator = new Random();
            
            int[,] cell = new int[4,4];
            
            /* for (var i = 0; i < cell.GetLength(0); i++)
            {
                for (var j = 0; j < cell.GetLength(1); j++)
                {
                    cell[i,j]=10;
                }
            } */

            cell[generator.Next(cell.GetLength(0)),generator.Next(cell.GetLength(1))]=1;


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
                            //CellMerge(ref cell, ref score, ref moved, k, j, -1, 0);
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
                                    score++;
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
                                if(cell[k,j]==0&&cell[k-1,j]!=0){
                                    //Move the previous cell to this one
                                    cell[k,j]=cell[k-1,j];
                                    cell[k-1,j]=0;
                                    moved = true;
                                }
                            }
                        }
                    }    
                }

                if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT)) //Left key press
                {
                    for (var j = 0; j < cell.GetLength(1); j++) //Cycle through rows top to bottomm
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
                                    score++;
                                }
                            }
                        }
                    }
                    for (var i = 0; i < cell.GetLength(0); i++) //Cycle through the play field
                    {
                        for (var j = 0; j < cell.GetLength(1); j++)
                        {
                            for (var k = 0; k < cell.GetLength(0)-1; k++) //Check all cells to the right of a cell that is 0, if it finds a cell that isn't 0 move it and tell the system that movement occured
                            {
                                if(cell[k,j]==0&&cell[k+1,j]!=0){
                                    cell[k,j]=cell[k+1,j];
                                    cell[k+1,j]=0;
                                    moved = true;
                                }
                            }
                        }
                    }
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_UP))
                {
                    for (var j = 0; j < cell.GetLength(0); j++)
                    {
                        for (var k = 0; k < cell.GetLength(1)-1; k++)
                        {
                            /* cell[j,k]=test;
                            test++; */
                            if(cell[j,k]!=0)
                            {
                                var i = 1;
                                while(cell[j,k+i]==0) //While cell[j,k+i] is 0 ([j,k+i] is the next cell from [j,k])
                                {
                                    //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                                    if(k+i+1<=cell.GetLength(1)-1)i++; 
                                    else break;
                                }
                                //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them and tell the system movement occured.
                                if(cell[j,k]==cell[j,k+i]) 
                                {
                                    cell[j,k]++;
                                    cell[j,k+i]=0;
                                    moved = true;
                                    score++;
                                }
                            }
                        }
                    }
                    for (var i = 0; i < cell.GetLength(0); i++) //Cycle through the play field
                    {
                        for (var j = 0; j < cell.GetLength(1); j++)
                        {
                            for (var k = 0; k < cell.GetLength(1)-1; k++) //Check all cells down from a cell that is 0, if it finds a cell that isn't 0 move it and tell the system that movement occured
                            {
                                if(cell[j,k]==0&&cell[j,k+1]!=0){
                                    cell[j,k]=cell[j,k+1];
                                    cell[j,k+1]=0;
                                    moved = true;
                                }
                            }
                        }
                    }
                }

                if(Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))
                {
                    for (var j = 0; j < cell.GetLength(0); j++)
                    {
                        for (var k = cell.GetLength(1)-1; k > 0; k--)
                        {
                            /* cell[j,k]=test;
                            test++; */
                            if(cell[j,k]!=0)
                            {
                                var i = 1;
                                while(cell[j,k-i]==0) //While cell[j,k-i] is 0 ([j,k-i] is the next cell from [j,k])
                                {
                                    //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                                    if(k-i-1>=0)i++; 
                                    else break;
                                }
                                //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them and tell the system movement occured.
                                if(cell[j,k]==cell[j,k-i]) 
                                {
                                    cell[j,k]++;
                                    cell[j,k-i]=0;
                                    moved = true;
                                    score++;
                                }
                            }
                        }
                    }

                    for (var i = 0; i < cell.GetLength(0); i++) //Cycle through the play field
                    {
                        for (var j = 0; j < cell.GetLength(1); j++)
                        {
                            for (var k = 1; k < cell.GetLength(1); k++) //Check all cells up from a cell that is 0, if it finds a cell that isn't 0 move it and tell the system that movement occured
                            {
                                if(cell[j,k]==0&&cell[j,k-1]!=0){
                                    cell[j,k]=cell[j,k-1];
                                    cell[j,k-1]=0;
                                    moved = true;
                                }
                            }
                        }
                    }
                }

                if(moved) //If movement ocurred set a random empty cell to 1
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

                for (var i = 0; i < cell.GetLength(0); i++){for (var j = 0; j < cell.GetLength(1); j++){
                    if(cell[i,j]>0)
                    {
                        if(cell[i,j]<12)
                        Raylib.DrawRectangle(i*200+1,j*200+1,198,198,new Color((256/11)*cell[i,j]-1,0,100,255));
                        else if (cell[i,j]<23)
                        Raylib.DrawRectangle(i*200+1,j*200+1,198,198,new Color(255,(256/11)*(cell[i,j]-11)-1,100,255));
                        else
                        Raylib.DrawRectangle(i*200+1,j*200+1,198,198,new Color(255,255,100,255));
                        Raylib.DrawText($"{Math.Pow(2,cell[i,j])}",5+i*200+10,75+j*200,50,Color.WHITE);
                    }
                    //Raylib.DrawText($"X{i} Y{j} Value{cell[i,j]}",5+i*200+10,120+j*200,20,Color.RED);//debug
                    
                }}
                Raylib.DrawText($"Score: {score}",10,10,20,Color.WHITE);
                Raylib.EndDrawing();
}}}}
