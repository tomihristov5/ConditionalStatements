// Problem 7. Sort 3 Numbers with Nested Ifs
// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("Enter first number: ");
        double firstNumb = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumb = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNumb = double.Parse(Console.ReadLine());
        if (firstNumb > secondNumb)
        {
            if (secondNumb > thirdNumb)
            {
                Console.WriteLine("The sorted numbers in descending order are: " + firstNumb + secondNumb + thirdNumb);
            }
            else
                Console.WriteLine("The sorted numbers in descending order are: " + firstNumb + thirdNumb + secondNumb);
        }
        else 
            if (secondNumb > thirdNumb)
            {
                if (thirdNumb > firstNumb)
                {
                    Console.WriteLine("The sorted numbers in descending order are: " + secondNumb + thirdNumb + firstNumb);
                }
                else
                    Console.WriteLine("The sorted numbers in descending order are: " + secondNumb + firstNumb + thirdNumb);
            }
            else
                if (thirdNumb > firstNumb)
                {
                    if (firstNumb > secondNumb)
                    {
                    Console.WriteLine("The sorted numbers in descending order are: " + thirdNumb + firstNumb + secondNumb);
                    }
                    else
                        Console.WriteLine("The sorted numbers in descending order are: " + thirdNumb + secondNumb + firstNumb);
        }
    }
}

