using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the List to hold the numbers 
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a Lis of numbers, type 0 when finished.");

        // Input Loop
        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            bool isNumber = int.TryParse(input, out int number);

            if (!isNumber)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            if (number == 0)
            {
                break; // Stop input on 0 (don't add it to the list)
            }
            numbers.Add(number);
        }

        // Ensure there are numbers to process
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // Compute the sum of the numbers
        int sum = numbers.Sum();

        // Compute the average (use double to aviod integer division)
        double average = numbers.Average();

        // Find the Largest number
        int max = numbers.Max();

        // DispLay the core results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // --- stretch CaLLenge ---

        // Find the smallest positive number
        // Filter positive numbers and find the smallest one
        var positiveNumbers = numbers.Where(n => n > 0);

        if (positiveNumbers.Any())
        {
            int smallestPositive = positiveNumbers.Min();
            Console.WriteLine($ "The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the lsit.");
        }

        // Sort the list and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}