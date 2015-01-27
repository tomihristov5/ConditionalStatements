﻿// Problem 1. Exchange If Greater
// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater 
// than the second one. As a result print the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Enter first variable: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second variable: ");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            double mask = a;
            a = b;
            b = mask;
            Console.WriteLine("The new values are: {0} {1}", a, b);
        }
    }
}

