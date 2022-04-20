using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice game");

            Random roll = new Random();

            int rolls = 0;
            int rounds = 0;
            int currentRoll = 0;
            string currentRolls = "";
            int dice = 0;

            while(true)
            {
                rounds ++;
                dice = 0;
                currentRolls = "";
                
                rolls++;
                currentRoll = roll.Next(4)+1;
                if(currentRoll == 4)
                {
                    dice++;
                    currentRolls += "4, ";
                }

                if(dice == 1)
                {
                    rolls++;
                    currentRoll = roll.Next(6)+1;
                    if(currentRoll == 6)
                    {
                        dice++;
                        currentRolls += "6, ";
                    }
                }

                if(dice == 2)
                {
                    rolls++;
                    currentRoll = roll.Next(8)+1;
                    if(currentRoll == 8)
                    {
                        dice++;
                        currentRolls += "8, ";
                    }
                }

                if(dice == 3)
                {
                    rolls++;
                    currentRoll = roll.Next(10)+1;
                    if(currentRoll == 10)
                    {
                        dice++;
                        currentRolls += "10, ";
                    }
                }

                if(dice == 4)
                {
                    rolls++;
                    currentRoll = roll.Next(12)+1;
                    if(currentRoll == 12)
                    {
                        dice++;
                        currentRolls += "12, ";
                    }
                }

                if(dice == 5)
                {
                    rolls++;
                    currentRoll = roll.Next(20)+1;
                    if(currentRoll == 20)
                    {
                        currentRolls += "20";
                        break;
                    }
                }
                Console.WriteLine($"rounds:{rounds} rolls:{rolls} {currentRolls}{currentRoll}");
            }
            Console.WriteLine($"rounds:{rounds} rolls:{rolls} {currentRolls} Success!");
        }
    }
}
