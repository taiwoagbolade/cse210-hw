using System;

class Program
{
    // Displays a welcome message to the user
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Prompts the user to enter their name and returns it as a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Prompts the user to enter their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        int number;
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    // Accepts an integer and returns its square
    static int Square(int number)
    {
        return number * number;
    }

    // Displays the user's name along with the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    // The Main method orchestrates the calling of the functions
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squared = Square(favoriteNumber);

        DisplayResult(userName, squared);
    }

}