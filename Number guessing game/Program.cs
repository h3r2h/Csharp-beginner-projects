using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Initialize the Random object to pick a secret number
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // Picks a number between 1 and 100

            // Set up variables to track the player's guess and how many tries it takes
            int playerGuess = 0;
            int scoreAttempts = 0;

            // 2. Display the welcome banner to the player
            Console.WriteLine("=================================");
            Console.WriteLine("  Welcome to the Guessing Game!  ");
            Console.WriteLine("=================================");
            Console.WriteLine("I have picked a number between 1 and 100. Can you guess it?\n");

            // 3. Main game loop: Keep running until the player guesses the correct number
            while (playerGuess != targetNumber)
            {
                Console.Write("Enter your guess: ");
                string userInput = Console.ReadLine();

                // 4. Safely check if the input is a valid number and convert it
                // int.TryParse prevents the program from crashing if the user types letters
                if (int.TryParse(userInput, out playerGuess))
                {
                    scoreAttempts++; // Increment attempt counter on every valid guess

                    // 5. Compare the guess against the secret target number
                    if (playerGuess > targetNumber)
                    {
                        Console.WriteLine("Too high! Try a lower number.\n");
                    }
                    else if (playerGuess < targetNumber)
                    {
                        Console.WriteLine("Too low! Try a higher number.\n");
                    }
                    else
                    {
                        // Player guessed correctly! Exit the loop message
                        Console.WriteLine($"\n🎉 CORRECT! You found the number in {scoreAttempts} attempts!");
                    }
                }
                else
                {
                    // Handles invalid text or blank inputs safely
                    Console.WriteLine("Invalid input! Please enter a valid number.\n");
                }
            }

            // 6. Pause the console window so the player can see their final score before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
