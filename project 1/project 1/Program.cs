using System;

namespace PrimeNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the start and end of the range
            Console.Write("Enter the start of the range: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end of the range: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            // Check each number in the range to see if it is prime
            for (int i = n1; i <= n2; i++)
            {
                // Assume the number is prime
                bool isPrime = true;

                // Check if the number is evenly divisible by any other number in the range
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        // If it is, the number is not prime
                        isPrime = false;
                        break;
                    }
                }

                // If the number is prime, print it to the console
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}