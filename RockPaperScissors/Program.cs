using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Rock, Paper, Scissors ===");
            Console.Write("How many rounds do want to play? ");
            int rounds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Alright... let's play!\n");

            Random random = new Random();

            int playerScore = 0;
            int computerScore = 0;
            char playerChoice;
            char computerChoice;
            char[] choices = { 'r', 'p', 's' };

            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine("* ROUND {0} - You: {1}, Me: {2}",
                    i + 1, playerScore, computerScore);
                Console.WriteLine("[R]ock");
                Console.WriteLine("[P]aper");
                Console.WriteLine("[S]cissors");
                Console.Write(">> Pick: ");
                playerChoice = Convert.ToChar(Console.ReadLine().ToLower());
                computerChoice = choices[random.Next(3)];

                Console.WriteLine("I picked: {0}", computerChoice);
                if ((playerChoice == 'r') && (computerChoice == 'p'))
                {
                    Console.WriteLine("I won!\n");
                    computerScore++;
                }
                else if ((playerChoice == 'r') && (computerChoice == 's'))
                {
                    Console.WriteLine("You won!\n");
                    playerScore++;
                }
                else if ((playerChoice == 'p') && (computerChoice == 'r'))
                {
                    Console.WriteLine("You won!\n");
                    playerScore++;
                }
                else if ((playerChoice == 'p') && (computerChoice == 's'))
                {
                    Console.WriteLine("I won!\n");
                    computerScore++;
                }
                else if ((playerChoice == 's') && (computerChoice == 'r'))
                {
                    Console.WriteLine("I won!\n");
                    computerScore++;
                }
                else if ((playerChoice == 's') && (computerChoice == 'p'))
                {
                    Console.WriteLine("You won!\n");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("It's a tie...\n");
                }
            }

            Console.WriteLine("Final result - You: {0}, Me {1}",
                playerScore, computerScore);
            if (playerScore > computerScore)
            {
                Console.WriteLine("You are the winner!");
            }
            else if (playerScore < computerScore)
            {
                Console.WriteLine("I am the winner!");
            }
            else
            {
                Console.WriteLine("That's a draw...");
            }
        }
    }
}
