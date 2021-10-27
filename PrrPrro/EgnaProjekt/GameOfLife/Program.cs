using System;

namespace GameOfLife
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Running: John Conway's Game of life, adapted by Benjamin Calmerman\n---------------------------------\nFirstly let's run a test of how many cells you can display.\nThe program will write 256 numbered lines in the console.\nWhen it's done write the number of the last line before the lines get split between rows.\nPress enter to continue...");
            Console.ReadKey();

            for (var i = 1; i < 256; i++)
            {
                Console.Write($"\n{i}\n");
                for (var j = 0; j < i; j++)
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("\nWhat was the last line to not get split?");
            int sizeX = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank you, now the program will write 256 numbered rows, when it is done write the highest number you still see.\nPress enter to continue...");
            Console.ReadKey();

            for (var i = 0; i < 256; i++)
            {
                Console.WriteLine(256-i);
            }

            int sizeY = int.Parse(Console.ReadLine());

            int[,] currentCells = new int[sizeY,sizeX];
            int[,] futureCells = new int[sizeY,sizeX];
            Console.WriteLine($"The map will be {currentCells.GetLength(0)} rows long.");
            Console.WriteLine($"The map will be {currentCells.GetLength(1)} columns wide.\nPress enter to continue and run the program.");
            Console.ReadKey();
            Console.Clear();

            while (true)
            {   
                //Calculating future map FORTSÄTT HÄR------------------------------------
                for (var y = 0; y < currentCells.GetLength(0); y++)
                {
                    for (var x = 0; x < currentCells.GetLength(1); x++)
                    {
                        int sum = 0;
                        if(y==0){
                            if(x==0){
                                sum = 
                                currentCells[0,1]+
                                currentCells[1,1]+
                                currentCells[1,0];
                            }else if(x==currentCells.GetLength(1)){
                                sum = 
                                currentCells[0,currentCells.GetLength(1)-1]+
                                currentCells[1,currentCells.GetLength(1)]+
                                currentCells[1,currentCells.GetLength(1)-1];
                            }else{
                                sum = 
                                currentCells[0,x+1]+
                                currentCells[0+1,x+1]+
                                currentCells[0+1,x]+
                                currentCells[0+1,x-1]+
                                currentCells[0,x-1];
                            }
                        }else if(y==currentCells.GetLength(0)){
                            if(x==0){
                                sum = 
                                currentCells[currentCells.GetLength(0)-1,0]+
                                currentCells[currentCells.GetLength(0),1]+
                                currentCells[currentCells.GetLength(0)-1,1];
                            }else if(x==currentCells.GetLength(1)){
                                sum = 
                                currentCells[currentCells.GetLength(0),currentCells.GetLength(1)-1]+
                                currentCells[currentCells.GetLength(0)-1,currentCells.GetLength(1)-1]+
                                currentCells[currentCells.GetLength(0)-1,currentCells.GetLength(1)];
                            }else{
                                sum = 
                                currentCells[currentCells.GetLength(0),x+1]+
                                currentCells[currentCells.GetLength(0)-1,x+1]+
                                currentCells[currentCells.GetLength(0)-1,x]+
                                currentCells[currentCells.GetLength(0)-1,x-1]+
                                currentCells[currentCells.GetLength(0),x-1];
                            }
                        }else{
                            if(x==0){
                                sum =
                                currentCells[y+1,0]+
                                currentCells[y+1,0+1]+
                                currentCells[y,0+1]+
                                currentCells[y-1,0+1]+
                                currentCells[y-1,0];
                            }else if(x==currentCells.GetLength(1)){
                                sum =
                                currentCells[x+1,currentCells.GetLength(1)]+
                                currentCells[x+1,currentCells.GetLength(1)-1]+
                                currentCells[x,currentCells.GetLength(1)-1]+
                                currentCells[x-1,currentCells.GetLength(1)-1]+
                                currentCells[x-1,currentCells.GetLength(1)];
                            }else{
                                sum =
                                currentCells[y-1,x+1]+
                                currentCells[y-1,x]+
                                currentCells[y-1,x-1]+
                                currentCells[y,x+1]+
                                currentCells[y,x-1]+
                                currentCells[y+1,x+1]+
                                currentCells[y+1,x]+
                                currentCells[y+1,x-1];
                            }
                        }
                        switch(sum){
                            case <2:
                                futureCells[y,x]=0;
                            break;
                            case 3:
                                futureCells[y,x]=1;
                            break;
                            case >3:
                                futureCells[y,x]=0;
                            break;
                            case 2:
                                futureCells[y,x]=currentCells[y,x];
                            break;
                        }
                        
                    }
                    Console.Write(47-y+"\n");
                }
                //Resetting current map
                for (var y = 0; y < currentCells.GetLength(0); y++)
                {
                    for (var x = 0; x < currentCells.GetLength(1); x++)
                    {
                        currentCells[y,x] = futureCells[y,x];
                    }
                    Console.Write(47-y+"\n");
                }
                //Drawing map
                for (var y = 0; y < currentCells.GetLength(0); y++)
                {
                    for (var x = 0; x < currentCells.GetLength(1); x++)
                    {
                        Console.Write(currentCells[y,x]);
                    }
                    Console.Write(47-y+"\n");
                }
            }
        }
    }
}
