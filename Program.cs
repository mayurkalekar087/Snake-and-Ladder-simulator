using System;

namespace Snake_and_Ladder_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder Game!");
            Random rand = new Random();
            int checkDice = rand.Next(1, 7);
            Console.WriteLine(checkDice);
            int snakeladder = rand.Next(1, 4);
            switch (snakeladder)
            {
                case 1:
                    
                    Console.WriteLine("player moves ahead ");
                  
                    break;
                case 2:
                    
                    Console.WriteLine("Player Moves behind ");
                    break;
                case 3:
                    Console.WriteLine("no play ");
                    break;

            }
        }

	}
    
}
