// Problem 6. The Biggest of Five Numbers
// Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Enter first number: ");
        double firstNumb = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumb = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNumb = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double forthNumb = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double fifthNumb = double.Parse(Console.ReadLine());
        if (firstNumb > secondNumb && firstNumb > thirdNumb && firstNumb > forthNumb && firstNumb > fifthNumb)
        {
            Console.WriteLine("The first number is the greatest!");
        }
        if (secondNumb > thirdNumb && secondNumb > forthNumb && secondNumb > fifthNumb && secondNumb > fifthNumb)
        {
            Console.WriteLine("The second number is the greatest!");
        }
        if (thirdNumb > forthNumb && thirdNumb > fifthNumb && thirdNumb > firstNumb && thirdNumb > secondNumb)
        {
            Console.WriteLine("The third number is the greatest!");
        }
        if (forthNumb > fifthNumb && forthNumb > firstNumb && forthNumb > secondNumb && forthNumb > thirdNumb)
        {
            Console.WriteLine("The forth number is the greatest!");
        }
        if (fifthNumb > firstNumb && fifthNumb > secondNumb && fifthNumb > thirdNumb && fifthNumb > forthNumb)
        {
            Console.WriteLine("The fifth number is the greatest!");
        }
    }
}

