// Problem 11.* Number as Words
// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumbersAsWords
{
    static void Main()
    {
        Console.Write("Enter an integer from 0 to 999: ");
        int number = int.Parse(Console.ReadLine());
        Convert.ToString(number);
        Console.WriteLine();

    }
}

