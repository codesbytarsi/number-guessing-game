using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            int attemptsCounter = 0;
            int maxAttempts = 0;
            int maxNumber = 0;
            int randomNumber = 0;

            Random random = new Random();

            Console.WriteLine("\nWelcome to the number guessing game!");

            Console.WriteLine("Choose a difficulty level:");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Normal");
            Console.WriteLine("3 - Hard");
            
            // Difficulty selection
            while (true)
            {
                Console.Write("Your choice: ");
                string levelInput = Console.ReadLine();

                if (int.TryParse(levelInput, out int levelChoice))
                {
                    if (levelChoice == 1)
                    {
                        maxNumber = 50;
                        maxAttempts = 10;
                        break;
                    }
                    else if (levelChoice == 2)
                    {
                        maxNumber = 100;
                        maxAttempts = 8;
                        break;
                    }
                    else if (levelChoice == 3)
                    {
                        maxNumber = 200;
                        maxAttempts = 7;
                        break;
                    }
                }

                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
            }

            // Generate random number after difficulty selection
            randomNumber = random.Next(1, maxNumber + 1);

            Console.WriteLine($"A number between 1 and {maxNumber} has been generated.");
            Console.WriteLine($"You have {maxAttempts} attempts. Good luck!\n");

            // Game loop
            while (!isCorrectGuess && attemptsCounter < maxAttempts)
            {
                Console.WriteLine("Please enter your guess.");
                string input = Console.ReadLine();

                // User input validation
                if (int.TryParse(input, out int guess))
                {
                    if (guess < 1 || guess > maxNumber)
                    {
                        Console.WriteLine($"Your guess must be between 1 and {maxNumber}.");
                        continue;
                    }

                    // Game logic
                    ++attemptsCounter;

                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Your guess is too high.");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Your guess is too low.");
                    }
                    else
                    {
                        isCorrectGuess = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Final result
            if (isCorrectGuess)
            {
                Console.WriteLine("\nCongratulations, you have won the game!");
                Console.WriteLine($"Attempts used: {attemptsCounter}/{maxAttempts}");
            }
            else
            {
                Console.WriteLine("\nGame over!");
                Console.WriteLine("You did not guess the number within the maximum number of attempts.");
                Console.WriteLine($"The correct number was: {randomNumber}");
                Console.WriteLine("Better luck next time!");
            }

            Console.ReadKey();
        }
    }
}