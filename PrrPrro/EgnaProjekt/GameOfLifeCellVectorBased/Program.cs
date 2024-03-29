﻿using System;
using System.Linq;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace GameOfLifeCellVectorBased
{
    class Program
    {
        static (int, int) window = (800, 800);
        static void Main(string[] args)
        {
            Raylib.InitWindow(window.Item1, window.Item2, "Game Of Life");
            Raylib.SetTargetFPS(60);

            //Initiate the zoom level of the window
            float zoom = 100;

            //Initiate the camera position
            Vector2 cameraPos = new Vector2(0, 0);

            //Initiate the edit mode cursor
            Vector2 editCursor = new Vector2(0, 0);

            //Edit mode boolean
            bool editMode = true;
            float targetGPS = 2;
            float gCoolDown = 0;

            //Initiate a list of current cells and one of potential new cells and new cells
            List<Vector2> cells = new List<Vector2>();
            List<Vector2> potentialCells = new List<Vector2>();
            List<Vector2> checkedCells = new List<Vector2>();
            List<Vector2> newCells = new List<Vector2>();

            cells.Add(new Vector2(0, 0));
            cells.Add(new Vector2(0, 2));
            cells.Add(new Vector2(2, 2));

            //Game loop
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(new Color(0, 0, 0, 255));

                if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) cameraPos.X++;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) cameraPos.X--;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) cameraPos.Y++;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) cameraPos.Y--;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_E)) zoom++;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_Q)) zoom--;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_R)) targetGPS += 0.2f;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_F)) targetGPS -= 0.2f;
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)) editMode = !editMode; 


                if (editMode)
                {
                    editCursor.X = (float)Math.Round((Raylib.GetMouseX() / (zoom / 2)) + 0.5);
                    editCursor.Y = (float)Math.Round((Raylib.GetMouseY() / (zoom / 2)) + 0.5);
                    for (var i = 0; i < 10; i++)
                    {
                        Raylib.DrawLine
                        (
                            (int)((editCursor.X - 5 + i) * zoom / 2),
                            (int)((editCursor.Y + 5) * zoom / 2),
                            (int)((editCursor.X - 5 + i) * zoom / 2),
                            (int)((editCursor.Y - 6) * zoom / 2),
                            new Color(0, 0, 255, 255)
                        );
                    }
                    for (var i = 0; i < 10; i++)
                    {
                        Raylib.DrawLine
                        (
                            (int)((editCursor.X + 5) * zoom / 2),
                            (int)((editCursor.Y - 5 + i) * zoom / 2),
                            (int)((editCursor.X - 6) * zoom / 2),
                            (int)((editCursor.Y - 5 + i) * zoom / 2),
                            new Color(0, 0, 255, 255)
                        );
                    }

                    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        bool found = false;
                        foreach (var cell in cells)
                        {
                            if(cell == new Vector2(editCursor.X-1+cameraPos.X,editCursor.Y-1+cameraPos.Y))
                            {
                                cells.Remove(cell);
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            cells.Add(new Vector2(editCursor.X-1+cameraPos.X,editCursor.Y-1+cameraPos.Y));
                        }
                    }
                }
                else
                {
                    if (gCoolDown <= 0)
                    {
                        //For every cell add all cells in a 3 by 3 area to potential new cells
                        foreach (var cell in cells)
                        {
                            for (var X = -1; X < 2; X++)
                            {
                                for (var Y = -1; Y < 2; Y++)
                                {
                                    potentialCells.Add(new Vector2(cell.X + X, cell.Y + Y));
                                }
                            }
                        }

                        //Count the amount of occurences of a cell in the potential cells list
                        foreach (var cell in potentialCells)
                        {
                            if (!checkedCells.Contains(cell))
                            {
                                checkedCells.Add(cell); 
                                int newCellCount = 0;
                                foreach (var cell2 in potentialCells)
                                {
                                    if (cell == cell2)
                                    {
                                        newCellCount++;
                                    }
                                }

                                //Refer to the rules of game of life
                                if ((newCellCount == 3 && !cells.Contains(cell)) || (newCellCount > 2 && newCellCount < 5 && cells.Contains(cell)))
                                {
                                    newCells.Add(cell);
                                }
                            }
                        }


                        //Set cells to newCells and clear potential and new
                        cells = new List<Vector2>(newCells);
                        newCells.Clear();
                        potentialCells.Clear();
                        checkedCells.Clear();

                        gCoolDown += 1/targetGPS;
                    }
                }

                foreach (var cell in cells)
                {
                    Raylib.DrawRectangle(
                    (int)((cell.X - cameraPos.X) * zoom / 2 + zoom / 40),
                    (int)((cell.Y - cameraPos.Y) * zoom / 2 + zoom / 40),
                    (int)((zoom / 2) - (zoom / 20)),
                    (int)((zoom / 2) - (zoom / 20)),
                    new Color(255, 255, 0, 255));
                }

                Raylib.DrawText($"Camera Position:{cameraPos.X},{cameraPos.Y}\nTarget GPS: {(Math.Round(targetGPS*10))/10}\nFPS: {Raylib.GetFPS()}", 5, 5, 20, new Color(255, 0, 0, 255));

                Raylib.EndDrawing();

                if (gCoolDown > 0) gCoolDown -= Raylib.GetFrameTime();
            }
        }
    }
}
