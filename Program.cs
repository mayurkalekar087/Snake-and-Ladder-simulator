using System;

namespace Snake_and_Ladder_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder Game!");
            int playerposition = 0;
            int totalNoOfDicePlayed = 0;

            Random rand = new Random();

            while (playerposition != 100)
            {

                int checkDice = rand.Next(1, 7);
                int snakeladder = rand.Next(1, 4);
                Console.WriteLine(checkDice);
                switch (snakeladder)
                {
                    case 1:
                        playerposition += checkDice;
                        Console.WriteLine("player moves ahead " + playerposition);
                        totalNoOfDicePlayed++;
                        break;
                    case 2:
                        playerposition -= checkDice;
                        Console.WriteLine("Player Moves behind " + playerposition);
                        if (playerposition < 0)
                        {
                            playerposition = 0;
                        }
                        totalNoOfDicePlayed++;
                        break;
                    case 3:
                        playerposition += 0;
                        Console.WriteLine("no play " + playerposition);
                        totalNoOfDicePlayed++;
                        break;

                }

               
            }
          

        }

    }

}