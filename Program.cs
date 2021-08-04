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

        }

	}
    
}
