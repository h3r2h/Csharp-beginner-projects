using System;
using System.ComponentModel;

namespace DiceGame
{
    internal class Program
    {
        // The Main method is the starting point of every C# application. Code runs from here.
        static void Main(string[] args)
        {
            // Print introductory instructions and rules to the console screen
            Console.WriteLine("Hello let's play a game!");
            Console.WriteLine("We need to roll two dice add them together and if they match then double the score");
            Console.WriteLine("Say 'yes' when you want to play, you can say no if you want to quit");

            // Read what the user types into the console and store it in a string variable named 'answer'
            string answer = Console.ReadLine();

            // Check if the user's answer is equal to "yes" to proceed with the game
            if (answer == "yes")
            {
                // Create a Random object to generate random numbers
                Random rand = new Random();

                // Generate a random integer from 1 to 6 for the player (1 is inclusive, 7 is exclusive)
                int player = rand.Next(1, 7);
                // Generate a random integer from 1 to 6 for the computer
                int computer = rand.Next(1, 7);

                // Output the random dice values to the console
                Console.WriteLine("You rolled: " + player);
                Console.WriteLine("Computer rolled: " + computer);

                // Compare the player's roll against the computer's roll to determine the outcome
                if (player > computer)
                {
                    Console.WriteLine("You win!");
                }
                else if (computer > player)
                {
                    Console.WriteLine("Computer wins!");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }
            }
        }
    }
}