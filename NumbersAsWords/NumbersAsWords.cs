// Problem 11.* Number as Words
// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumbersAsWords
{
    static void Main()
    {
        string[] zeroTo19 = new string[] { "Zero", "One", "Two", "three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fiftheen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] twenties = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        Console.Write("Enter an integer from 0 to 999: ");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0 && number <= 19)
        {
            Console.WriteLine("The number as word is: " + zeroTo19[number]);
        }
        if (number >= 20 && number <= 99)
        {
            if (number % 10 == 0)
            {
                Console.WriteLine(twenties[(number / 10) - 2]);
            }
            else
            Console.WriteLine(twenties[(int)(number / 10) - 2] + " " + zeroTo19[number % 10]);
        }
        if (number >= 100 && number <= 999)
        {
            if (number % 100 == 0)
            {
                Console.WriteLine(zeroTo19[number / 100] + " hundred");
            }
            else
                if (number % 10 == 0)
                {
                    Console.WriteLine(zeroTo19[(int)(number / 100)] + " hundred and " + twenties[(number / 10) % 10 - 2]);
                }
                else
                    Console.WriteLine(zeroTo19[(int)(number / 100)] + " hundred and " + twenties[(number / 10) % 10 - 2] + " " + zeroTo19[(number % 100) % 10]);
        }
        else
            Console.WriteLine("The number is out of range!");
    }
}

