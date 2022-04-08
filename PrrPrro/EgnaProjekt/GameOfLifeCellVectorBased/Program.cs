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

            float zoom = 1;

            List<Vector2> cells = new List<Vector2>();
            List<Vector2> newCells = new List<Vector2>();

            while(!Raylib.WindowShouldClose()){
                foreach (var cell in cells)
                {
                    for (var X = -1; X < 1; X++)
                    {
                        for (var Y = -1; Y < 1; Y++)
                        {
                            newCells.Add(new Vector2(cell.X+X,cell.Y+Y));
                        }
                    }
                }
                cells.Clear();
                int newCellIndex=0;
                foreach (var cell in newCells)
                {
                    int newCellCount=0;
                    foreach (var cell2 in newCells)
                    {
                        if (cell==cell2)
                        {
                            newCellCount++;
                            newCells.Remove(cell2);
                        }
                    }
                    if(newCellCount>2)
                    {
                        cells.Add(cell);
                    }
                    newCellIndex++;
                }
                newCells.Clear();
            }
        }
    }
}
