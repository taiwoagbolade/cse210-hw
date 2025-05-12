using System;

class Program
{
    static void Main(string[] args)
    {
        // This is a get my number game

        bool PlayAgain = true;

        while (PlayAgain)
        {
            // Initialize the random number generator
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // Random number between 1 and 100

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I have selected a magic numebr between 1 and 100. Can you guess it?");

            // Loop until the user guesses the number
            while (guess != magicNumber)
            {
                Console.Write("Enter your guess: ");
                string userinput = Console.ReadLine();

                // Validate the input
                if (!int.TryParse(userinput, out guess))
                {
                    guessCount++;

                    // Check if the guess is correct
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the magic number {magicNumber} in {guessCount} tries.");
                    }
                }

                // Ask if the user wants to play again
                Console.Write("Do you want to play again? (y/n): ");
                string response = Console.ReadLine().Trim().ToLower();
                if (response != "yes")
                {
                    PlayAgain = false;
                    Console.WriteLine("Thanks for playing! Goodbye.");
                }
            }
        }
    }