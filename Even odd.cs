/*
 Author: Zowaib Farooq
 Date1/31/2023
 Description:This is a C# console application provides practical 
             eample of  Iterative statements
*/


using System;

namespace IterativeStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 0;
            string series = "";

            Console.WriteLine("Enter an integer value between 1 and 100:");

            try
            {
                limit = int.Parse(Console.ReadLine());
                if (limit < 1 || limit > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter a series of numbers (even/odd):");
            series = Console.ReadLine().ToLower();
            if (series != "even" && series != "odd")
            {
                Console.WriteLine("Invalid input. Please enter either 'even' or 'odd'.");
                return;
            }

            Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + limit + " are:");
            for (int i = 0; i <= limit; i++)
            {
                if (series == "even" && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (series == "odd" && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
