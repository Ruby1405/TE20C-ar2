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

        static Random generator = new Random();

        static void CellGen(ref int[,] cell)
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
            
            int scene = 0;

            int score = 0;

            //int test = 1;

            int[,] cell = {{0},{0}};

            Vector2 size = new Vector2(4,4);

            Color shade = new Color(0, 0, 0, 16);

            while(!Raylib.WindowShouldClose()){
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                if(scene==0)
                {
                    Raylib.DrawRectangle(1,1,198,198,new Color((256/11)-1,0,100,255));
                    Raylib.DrawRectangle(401,1,198,198,new Color((256/11)*2-1,0,100,255));
                    Raylib.DrawRectangle(601,1,198,198,new Color((256/11)*3-1,0,100,255));
                    Raylib.DrawText($"2",75,50,100,Color.WHITE);
                    Raylib.DrawText($"0",275,50,100,Color.WHITE);
                    Raylib.DrawText($"4",475,50,100,Color.WHITE);
                    Raylib.DrawText($"8",675,50,100,Color.WHITE);
                    Raylib.DrawText($"Use the arrow keys to adjust playing field\nPress enter when you are satisfied",125,250,25,Color.WHITE);

                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_UP))size.Y--;
                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))size.X++;
                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))size.X--;
                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))size.Y++;
                    Raylib.SetWindowSize((int)size.X*200,(int)size.Y*200);

                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        cell = new int[(int)size.X,(int)size.Y];
                
                        /* for (var i = 0; i < cell.GetLength(0); i++)
                        {
                            for (var j = 0; j < cell.GetLength(1); j++)
                            {
                                cell[i,j]=10;
                            }
                        } */

                        cell[generator.Next(cell.GetLength(0)),generator.Next(cell.GetLength(1))]=1;
                        scene=1;
                    }
                }

                if(scene==1)
                {

                    bool moved = false;

                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT)) //Right key press
                    {
                        for (var y = 0; y < cell.GetLength(1); y++) //Cycle through rows top to bottomm
                        {
                            for (var x = cell.GetLength(0)-1; x > 0; x--) //Cycle through columns from left to right skipping 0
                            {
                                //CellMerge(ref cell, ref score, ref moved, x, y, -1, 0);
                                if(cell[x,y]!=0) //If cell isn't equal to 0 define i as 1
                                {
                                    var i = 1;
                                    while(cell[x-i,y]==0) //While cell[x-i,y] is 0 ([x-i,y] is the next cell from [x,y])
                                    {
                                        //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                                        if(x-i-1>=0)i++; 
                                        else break;
                                    }
                                    //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them and tell the system movement occured.
                                    if(cell[x,y]==cell[x-i,y]) 
                                    {
                                        cell[x,y]++;
                                        cell[x-i,y]=0;
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
                                    //If the cell equal to 0 then if the previous cell in the movement direction isn't equal to 0 tell the system movement occured
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
                        for (var y = 0; y < cell.GetLength(1); y++) //Cycle through rows top to bottomm
                        {
                            for (var x = 0; x < cell.GetLength(0)-1; x++)
                            {
                                /* cell[x,y]=test;
                                test++; */
                                if(cell[x,y]!=0)
                                {
                                    var i = 1;
                                    while(cell[x+i,y]==0) //While cell[x+i,y] is 0 ([x+i,y] is the next cell from [x,y])
                                    {
                                        //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                                        if(x+i+1<=cell.GetLength(0)-1)i++; 
                                        else break;
                                    }
                                    //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them and tell the system movement occured.
                                    if(cell[x,y]==cell[x+i,y]) 
                                    {
                                        cell[x,y]++;
                                        cell[x+i,y]=0;
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
                        for (var x = 0; x < cell.GetLength(0); x++)
                        {
                            for (var y = 0; y < cell.GetLength(1)-1; y++)
                            {
                                /* cell[x,y]=test;
                                test++; */
                                if(cell[x,y]!=0)
                                {
                                    var i = 1;
                                    while(cell[x,y+i]==0) //While cell[x,y+i] is 0 ([x,y+i] is the next cell from [x,y])
                                    {
                                        //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                                        if(y+i+1<=cell.GetLength(1)-1)i++; 
                                        else break;
                                    }
                                    //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them and tell the system movement occured.
                                    if(cell[x,y]==cell[x,y+i]) 
                                    {
                                        cell[x,y]++;
                                        cell[x,y+i]=0;
                                        moved = true;
                                        score++;
                                    }
                                }
                            }
                        }

                        for (var x = 0; x < cell.GetLength(0); x++)
                        {
                            for (var y = 0; y < cell.GetLength(1)-1; y++)
                            {
                                if(cell[x,y]==0)
                                {
                                    var i = 1;
                                    while(cell[x,y+i]==0)
                                    {
                                        if(y+i<cell.GetLength(1)-1)i++;
                                        else break;
                                    }
                                    if(cell[x,y+i]!=0)
                                    {
                                        cell[x,y]=cell[x,y+i];
                                        cell[x,y+i]=0;
                                        moved = true;
                                    }
                                }
                            }
                        }
                    }

                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))
                    {
                        for (var x = 0; x < cell.GetLength(0); x++)
                        {
                            for (var y = cell.GetLength(1)-1; y > 0; y--)
                            {
                                /* cell[x,y]=test;
                                test++; */
                                if(cell[x,y]!=0)
                                {
                                    var i = 1;
                                    while(cell[x,y-i]==0) //While cell[x,y-i] is 0 ([x,y-i] is the next cell from [x,y])
                                    {
                                        //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                                        if(y-i-1>=0)i++; 
                                        else break;
                                    }
                                    //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them and tell the system movement occured.
                                    if(cell[x,y]==cell[x,y-i]) 
                                    {
                                        cell[x,y]++;
                                        cell[x,y-i]=0;
                                        moved = true;
                                        score++;
                                    }
                                }
                            }
                        }


                        for (var x = 0; x < cell.GetLength(0); x++)
                        {
                            for (var y = cell.GetLength(1)-1; y > 0; y--)
                            {
                                if(cell[x,y]==0)
                                {
                                    var i = -1;
                                    while(cell[x,y+i]==0)
                                    {
                                        if(y+i>0)i--;
                                        else break;
                                    }
                                    if(cell[x,y+i]!=0)
                                    {
                                        cell[x,y]=cell[x,y+i];
                                        cell[x,y+i]=0;
                                        moved = true;
                                    }
                                }
                            }
                        }
                    }

                    if(moved)CellGen(ref cell); //If movement ocurred set a random empty cell to 1

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
                }
                Raylib.EndDrawing();
}}}}
