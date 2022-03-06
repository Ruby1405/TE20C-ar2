using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

namespace _2048
{
    class Program
    {
        static int windowX = 800;
        static int windowY = 800;

        static Random generator = new Random();

        /// <summary>
        /// Generates a new 2 by making a list of empty cells and picking one
        /// </summary>
        /// <param name="cell"></param>
        static void CellGen(ref int[,] cell)
        {
            List<Vector2> emptyList = new List<Vector2>(); //Make a list of coordinates
            for (var i = 0; i < cell.GetLength(0); i++) //Cycle through cell array
            {
                for (var j = 0; j < cell.GetLength(1); j++)
                {
                    if (cell[i, j] == 0) //If the cell = 0 add it to the vector list
                    {
                        emptyList.Add(new Vector2(i, j));
                    }
                }
            }
            int randomIndex = generator.Next(emptyList.Count); //Pick a random cell from the vector list and make it 1
            cell[(int)emptyList[randomIndex].X, (int)emptyList[randomIndex].Y] = 1;
        }

        /// <summary>
        /// Moves all cells that can be moved right right and merges all cells that can be merged right right
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="score"></param>
        /// <param name="moved"></param>
        static void MoveRight(ref int[,] cell, ref int score, ref bool moved)
        {
            for (var y = 0; y < cell.GetLength(1); y++) //Cycle through the playing field
            {
                for (var x = cell.GetLength(0) - 1; x > 0; x--)
                {
                    if (cell[x, y] != 0) //If cell isn't equal to 0 define i as 1
                    {
                        var i = 1;
                        while (cell[x - i, y] == 0) //While the next cell is 0
                        {
                            //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                            if (x - i - 1 >= 0) i++;
                            else break;
                        }
                        //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them, tell the system movement occured and increase the score.
                        if (cell[x, y] == cell[x - i, y])
                        {
                            cell[x, y]++;
                            cell[x - i, y] = 0;
                            moved = true;
                            score++;
                        }
                    }
                }
            }
            for (var i = 0; i < cell.GetLength(0); i++) //Cycle through the playing field
            {
                for (var j = 0; j < cell.GetLength(1); j++) 
                {
                    for (var k = cell.GetLength(0) - 1; k > 0; k--)  //Check all previous cells in the movement direction, if it finds a cell that isn't 0 move it and tell the system that movement occured
                    {
                        if (cell[k, j] == 0 && cell[k - 1, j] != 0)
                        {
                            cell[k, j] = cell[k - 1, j];
                            cell[k - 1, j] = 0;
                            moved = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Moves all cells that can be moved left left and merges all cells that can be merged left left
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="score"></param>
        /// <param name="moved"></param>
        static void MoveLeft(ref int[,] cell, ref int score, ref bool moved)
        {
            for (var y = 0; y < cell.GetLength(1); y++) //Cycle through the playing field
            {
                for (var x = 0; x < cell.GetLength(0) - 1; x++)
                {
                    if (cell[x, y] != 0) //If cell isn't equal to 0 define i as 1
                    {
                        var i = 1;
                        while (cell[x + i, y] == 0) //While the next cell is 0
                        {
                            //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                            if (x + i + 1 <= cell.GetLength(0) - 1) i++;
                            else break;
                        }
                        //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them, tell the system movement occured and increase the score.
                        if (cell[x, y] == cell[x + i, y])
                        {
                            cell[x, y]++;
                            cell[x + i, y] = 0;
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
                    for (var k = 0; k < cell.GetLength(0) - 1; k++) //Check all previous cells in the movement direction, if it finds a cell that isn't 0 move it and tell the system that movement occured
                    {
                        if (cell[k, j] == 0 && cell[k + 1, j] != 0)
                        {
                            cell[k, j] = cell[k + 1, j];
                            cell[k + 1, j] = 0;
                            moved = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Moves all cells that can be moved up up and merges all cells that can be merged up up
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="score"></param>
        /// <param name="moved"></param>
        static void MoveUp(ref int[,] cell, ref int score, ref bool moved)
        {
            for (var x = 0; x < cell.GetLength(0); x++) //Cycle through the playing field
            {
                for (var y = 0; y < cell.GetLength(1) - 1; y++)
                {
                    if (cell[x, y] != 0) //If cell isn't equal to 0 define i as 1
                    {
                        var i = 1;
                        while (cell[x, y + i] == 0) //While the next cell is 0
                        {
                            //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                            if (y + i + 1 <= cell.GetLength(1) - 1) i++;
                            else break;
                        }
                        //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them, tell the system movement occured and increase the score.
                        if (cell[x, y] == cell[x, y + i])
                        {
                            cell[x, y]++;
                            cell[x, y + i] = 0;
                            moved = true;
                            score++;
                        }
                    }
                }
            }

            for (var x = 0; x < cell.GetLength(0); x++) //Cycle through the playing field
            {
                for (var y = 0; y < cell.GetLength(1) - 1; y++)
                {
                    if (cell[x, y] == 0)  //If the cell is 0 move the next cell that isn't 0 here and tell the system movement occured
                    {
                        var i = 1;
                        while (cell[x, y + i] == 0)
                        {
                            if (y + i < cell.GetLength(1) - 1) i++;
                            else break;
                        }
                        if (cell[x, y + i] != 0)
                        {
                            cell[x, y] = cell[x, y + i];
                            cell[x, y + i] = 0;
                            moved = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Moves all cells that can be moved up up and merges all cells that can be merged up up
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="score"></param>
        /// <param name="moved"></param>
        static void MoveDown(ref int[,] cell, ref int score, ref bool moved)
        {

            for (var x = 0; x < cell.GetLength(0); x++) //Cycle through the playing field
            {
                for (var y = cell.GetLength(1) - 1; y > 0; y--)
                {
                    if (cell[x, y] != 0) //If cell isn't equal to 0 define i as 1
                    {
                        var i = 1;
                        while (cell[x, y - i] == 0) //While the next cell is 0
                        {
                            //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                            if (y - i - 1 >= 0) i++;
                            else break;
                        }
                        //If the while loop either stops because it's found a value not equal to 0 or if it breaks check if the cells are equal and in that case combine them, tell the system movement occured and increase the score.
                        if (cell[x, y] == cell[x, y - i])
                        {
                            cell[x, y]++;
                            cell[x, y - i] = 0;
                            moved = true;
                            score++;
                        }
                    }
                }
            }


            for (var x = 0; x < cell.GetLength(0); x++) //Cycle through the playing field
            {
                for (var y = cell.GetLength(1) - 1; y > 0; y--)
                {
                    if (cell[x, y] == 0)  //If the cell is 0 move the next cell that isn't 0 here and tell the system movement occured
                    {
                        var i = -1;
                        while (cell[x, y + i] == 0)
                        {
                            //Catches for index out of range exception, if the next cell to be checked is outside of the array it won't attempt it.
                            if (y + i > 0) i--;
                            else break;
                        }
                        if (cell[x, y + i] != 0)
                        {
                            cell[x, y] = cell[x, y + i];
                            cell[x, y + i] = 0;
                            moved = true;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Raylib.InitWindow(windowX, windowY, "2048");
            Raylib.SetTargetFPS(60);

            int scene = 0;

            int score = 0;

            int cellRes = 1; //The dimensions in pixels of the cells. All graphical elements are in some way dependant on this

            int[,] cell = { { 0 }, { 0 } }; //Create the array for the cell values

            Vector2 size = new Vector2(4, 4); //The size of the playing field

            Color shade = new Color(0, 0, 0, 16); //I honestly don't know what this is but it works great!

            while (!Raylib.WindowShouldClose())
            {

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                if (scene == 0) //If the game is on the start screen
                {
                    //Draw logo
                    Raylib.DrawRectangle(1, 1, cellRes - 2, cellRes - 2, new Color((256 / 11) - 1, 0, 100, 255));
                    Raylib.DrawRectangle(2 * cellRes + 1, 1, cellRes - 2, cellRes - 2, new Color((256 / 11) * 2 - 1, 0, 100, 255));
                    Raylib.DrawRectangle(3 * cellRes + 1, 1, cellRes - 2, cellRes - 2, new Color((256 / 11) * 3 - 1, 0, 100, 255));
                    Raylib.DrawText($"2", (3 * cellRes) / 8, cellRes / 4, cellRes / 2, Color.WHITE);
                    Raylib.DrawText($"0", (11 * cellRes) / 8, cellRes / 4, cellRes / 2, Color.WHITE);
                    Raylib.DrawText($"4", (19 * cellRes) / 8, cellRes / 4, cellRes / 2, Color.WHITE);
                    Raylib.DrawText($"8", (27 * cellRes) / 8, cellRes / 4, cellRes / 2, Color.WHITE);

                    //Draw instructions
                    Raylib.DrawText($"Use the arrow keys to adjust playing field\nPress enter when you are satisfied\nCurrent size: {size.X}:{size.Y}", (5 * cellRes) / 8, (5 * cellRes) / 4, cellRes / 8, Color.WHITE);

                    //Checks for arrow key signals and adjusts the playing field size accordingly unless it becomes smaller than 1 in any dimension
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP) && size.Y > 1) size.Y--;
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT)) size.X++;
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) && size.X > 1) size.X--;
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN)) size.Y++;
                    Raylib.SetWindowSize((int)size.X * cellRes, (int)size.Y * cellRes);

                    //Adjust the playing field to fit on the screen and not be smaller than neccesary
                    if (size.X > (int)Raylib.GetMonitorWidth(0) / cellRes || size.Y > (int)Raylib.GetMonitorHeight(0) / cellRes) cellRes--;
                    else if (size.X < (int)Raylib.GetMonitorWidth(0) / cellRes && size.Y < (int)Raylib.GetMonitorHeight(0) / cellRes) cellRes++;

                    //When enter is pressed the game starts, the cells are defined and the scene is set to 1
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        //Redefine the cell array to match the size selected in the startup
                        cell = new int[(int)size.X, (int)size.Y];

                        //test code
                        /* for (var i = 0; i < cell.GetLength(0); i++)
                        {
                            for (var j = 0; j < cell.GetLength(1); j++)
                            {
                                cell[i,j]=10;
                            }
                        } */

                        //Set a random cell to 1
                        cell[generator.Next(cell.GetLength(0)), generator.Next(cell.GetLength(1))] = 1;
                        
                        scene = 1;
                    }
                }

                if (scene == 1) //If the game is being played
                {
                    //Default to not having moved
                    bool moved = false;

                    //If an arrow key is pressed run the appropriate method
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT)) MoveRight(ref cell, ref score, ref moved);

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT)) MoveLeft(ref cell, ref score, ref moved);

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP)) MoveUp(ref cell, ref score, ref moved);

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN)) MoveDown(ref cell, ref score, ref moved);

                    if (moved) CellGen(ref cell); //If movement ocurred set a random empty cell to 1

                    for (var i = 0; i < cell.GetLength(0); i++) //Cycle through the playing field
                    {
                        for (var j = 0; j < cell.GetLength(1); j++)
                        {
                            if (cell[i, j] > 0) //If the cell isn't 0 draw graphics for it and lable it
                            {
                                //Dynamic colouring, the colour is decided by the value. Also makes sure it doesn't accidentally call for an invalid colour
                                if (cell[i, j] < 12)
                                    Raylib.DrawRectangle(i * cellRes + 1, j * cellRes + 1, cellRes - 2, cellRes - 2, new Color((256 / 11) * cell[i, j] - 1, 0, 100, 255));
                                else if (cell[i, j] < 23)
                                    Raylib.DrawRectangle(i * cellRes + 1, j * cellRes + 1, cellRes - 2, cellRes - 2, new Color(255, (256 / 11) * (cell[i, j] - 11) - 1, 100, 255));
                                else
                                    Raylib.DrawRectangle(i * cellRes + 1, j * cellRes + 1, cellRes - 2, cellRes - 2, new Color(255, 255, 100, 255));
                                //Write the value
                                Raylib.DrawText($"{Math.Pow(2, cell[i, j])}", 15 + i * cellRes, (3 * cellRes) / 8 + j * cellRes, cellRes / 4, Color.WHITE);
                            }
                            //Raylib.DrawText($"X{i} Y{j} Value{cell[i, j]}", 15 + i * cellRes, (6 * cellRes) / 10 + j * cellRes, cellRes / 10, Color.RED);//debug

                        }
                    }
                    //Write the score
                    Raylib.DrawText($"Score: {score}", 10, 10, cellRes / 10, Color.WHITE);
                }
                Raylib.EndDrawing();
            }
        }
    }
}
