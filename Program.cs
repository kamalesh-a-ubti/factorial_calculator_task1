using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Non-Negative Number:");
            int number = int.Parse(Console.ReadLine());
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is {factorial}");
        }

        static long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("The Number must be non-negative.");
                return -1; // Return a value to indicate an error
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}
