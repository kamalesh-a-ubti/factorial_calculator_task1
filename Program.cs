using System;

namespace FactorialCalculator
{
    class Program
    {
        // Main Method
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // Taking input
                    Console.WriteLine("Enter the Non-Negative Number:");
                    // Converting the input into int
                    int number = int.Parse(Console.ReadLine());
                    // Calculating the factorial
                    long factorial = CalculateFactorial(number);
                    // Printing the output
                    Console.WriteLine($"The factorial of {number} is {factorial}");
                    break; // Exit the loop if input is valid
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative integer.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        static long CalculateFactorial(int n)
        {
            try
            {
                if (n < 0)
                {
                    // Negative condition
                    throw new ArgumentException("The Number must be non-negative.");
                }
                else if (n == 0)
                {
                    // Condition when n is zero
                    return 1;
                }
                else
                {
                    // Using recursive function to find factorial
                    return n * CalculateFactorial(n - 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in CalculateFactorial: {ex.Message}");
                throw; // Re-throw the exception to be handled by the calling method
            }
        }
    }
}
