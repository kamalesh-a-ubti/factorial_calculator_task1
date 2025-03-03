# Time complexity
using System;

namespace FactorialCalculator
{
    class Program 
    {

        // Main Method
        static void Main(string[] args)
        {
          while(true){
          try{ //1
            // Taking input
            Console.WriteLine("Enter the Non-Negative Number:"); //O(1) - //1 
            // Converting the input into int
            int number = int.Parse(Console.ReadLine()); //O(1) - //3
            // Calculating the factorial
            long factorial = CalculateFactorial(number); //O(n) -//n+1
            // Printing the output
            Console.WriteLine($"The factorial of {number} is {factorial}"); //O(1) - //2
            break;
            }
            catch (FormatException) -//1
            {
                Console.WriteLine("Invalid input. Please enter a valid non-negative integer."); //O(1) - //1
            }
             catch (Exception ex) - //1
            {
                Console.WriteLine($"An error occurred: {ex.Message}"); //O(1) - //2
            }}
        }

        static long CalculateFactorial(int n){ //O(n) - //n
            try{
                if (n < 0){  //1
                    // Negative condition
                    throw new ArgumentException("The Number must be non-negative."); //O(1) - //1
                }
                else if (n == 0) //1
                {
                    // Condition when n is zero
                    return 1; //O(1) - //1
                }
                else 
                {
                    // Using recursive function to find factorial
                    return n * CalculateFactorial(n - 1); //O(n) - //n
                }
            }
            catch (Exception ex) - //1
            {
                Console.WriteLine($"An error occurred in CalculateFactorial: {ex.Message}"); //O(1) - //2
                throw; // Re-throw the exception to be handled by the calling method //O(1) - //1
            }
        }
    }
}

## The total time complexity is o(n).