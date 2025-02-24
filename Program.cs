using System;

namespace FactorialCalculator
{
    class Program
    {

        // Main Method
        static void Main(string[] args)
        {
            //Taking input
            Console.WriteLine("Enter the Non-Negative Number:");
            //converting the input into int
            int number = int.Parse(Console.ReadLine());
            //calculating the factorial
            long factorial = CalculateFactorial(number);
            //printing the output
            Console.WriteLine($"The factorial of {number} is {factorial}");
        }

        static long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                //neagtive condition
                Console.WriteLine("The Number must be non-negative.");
                return -1; // Return a value to indicate an error
            }
            else if (n == 0)
            {
                //condition when nis zero 
                return 1;
            }
            else
            {
                //using recursive function to find factorial
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}