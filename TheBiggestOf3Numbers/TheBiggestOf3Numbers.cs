// Problem 5. The Biggest of 3 Numbers
// Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOf3Numbers
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
        if (firstNumb > secondNumb && firstNumb > thirdNumb)
        {
            Console.WriteLine("The first number is the greatest!");
        }
        else
            if (secondNumb > thirdNumb)
            {
                Console.WriteLine("The second number is the greatest!");
            }
            else
                Console.WriteLine("The third number is the greatest!");
    }
}

