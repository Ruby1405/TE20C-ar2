using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace GameOfLifeCellVectorBased
{
    class Program
    {
        static (int, int) window = (800,800);
        static void Main(string[] args)
        {
            Raylib.InitWindow(window.Item1,window.Item2, "Game Of Life");
            Raylib.SetTargetFPS(60);            

            //Initiate the zoom level of the window
            float zoom = 100;

            //Initiate the camera position
            Vector2 cameraPos = new Vector2(0,0);

            //Initiate a list of current cells and one of potential new cells and new cells
            List<Vector2> cells = new List<Vector2>();
            List<Vector2> potentialCells = new List<Vector2>();
            List<Vector2> newCells = new List<Vector2>();

            //Game loop
            while(!Raylib.WindowShouldClose()){

                //For every cell add all cells in a 3 by 3 area to potential new cells
                foreach (var cell in cells)
                {
                    for (var X = -1; X < 1; X++)
                    {
                        for (var Y = -1; Y < 1; Y++)
                        {
                            potentialCells.Add(new Vector2(cell.X+X,cell.Y+Y));
                        }
                    }
                }

                //Count the amount of occurences of a cell in the potential cells list
                foreach (var cell in potentialCells)
                {
                    int newCellCount=0;
                    foreach (var cell2 in potentialCells)
                    {
                        if (cell==cell2)
                        {
                            newCellCount++;
                            potentialCells.Remove(cell2);
                        }
                    }

                    //Refer to the rules of game of life
                    if((newCellCount == 3 && !cells.Contains(cell)) || (newCellCount > 2 && newCellCount < 5 && cells.Contains(cell)))
                    {
                        newCells.Add(cell);
                    }
                }
                //Set cells to newCells and clear potential and new
                cells = newCells;
                newCells.Clear();
                potentialCells.Clear();

                foreach (var cell in cells)
                {
                    Raylib.DrawRectangle(
                    (int)(cell.X*zoom/2),
                    (int)(cell.Y*zoom/2),
                    (int)((zoom/2)-(zoom/20)),
                    (int)((zoom/2)-(zoom/20)),
                    new Color(255,0,0,255));
                }
            }
        }
    }
}
