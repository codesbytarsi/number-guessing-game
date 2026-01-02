using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            int attemptsCounter = 0;
            const int MAX_ATTEMPTS = 8;

            Random random = new Random();

            int randomNum = random.Next(1, 101);

            Console.WriteLine("\nWelcome to the number guessing game!");
            Console.WriteLine("A number between 1 and 100 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!\n");

            while (!isCorrectGuess && attemptsCounter < MAX_ATTEMPTS)
            {
                Console.WriteLine("\nPlease enter your guess.");
                string input = Console.ReadLine();

                // User input validation
                if (int.TryParse(input, out int guess))
                {
                    // Range validation
                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Your guess must be between 1 and 100.");
                        continue;
                    }

                    // Game logic
                    ++attemptsCounter;

                    if (guess > randomNum)
                    {
                        Console.WriteLine("Your guess is too high.");
                    }
                    else if (guess < randomNum)
                    {
                        Console.WriteLine("Your guess is too low.");
                    }
                    else
                    {
                        Console.WriteLine("\nCongratulations, you have won the game!");
                        Console.WriteLine($"Attempts: {attemptsCounter}");
                        isCorrectGuess = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine("\nGame over!");
            Console.WriteLine("You did not guess the number within the maximum number of attempts.");
            Console.WriteLine($"The correct number was: {randomNum}");


            Console.ReadKey();
        }
    }
}