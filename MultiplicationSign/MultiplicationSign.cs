// Problem 4. Multiplication Sign
// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

using System;

class MultiplicationSign
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
        if (firstNumb < 0 ^ secondNumb < 0 ^ thirdNumb < 0)
        {
            Console.WriteLine("The sign of the result is: -");
        }
        if (firstNumb > 0 ^ secondNumb > 0 ^ thirdNumb > 0)
        {
            Console.WriteLine("The sign of the result is: +");
        }
        if (firstNumb == 0 || secondNumb == 0 || thirdNumb ==0)
        {
            Console.WriteLine("The sign of the result is: 0");
        }
    }
}

