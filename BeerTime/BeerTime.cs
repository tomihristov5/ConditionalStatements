// Problem 10.* Beer Time
// A beer time is after 1:00 PM and before 3:00 AM.
// Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] 
// and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time 
// if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        CultureInfo currentCulture = CultureInfo.InvariantCulture;
        DateTime startBeerTime = DateTime.ParseExact("01:00 PM", "hh:mm tt", currentCulture);
        DateTime endBeerTime = DateTime.ParseExact("03:00 AM", "hh:mm tt", currentCulture);
        Console.Write("Enter time in format \"hh:mm tt\" :");
        string input = Console.ReadLine();
        DateTime beerTime = DateTime.ParseExact(input, "h:mm tt", currentCulture);
        if (beerTime.TimeOfDay >= startBeerTime.TimeOfDay || beerTime.TimeOfDay < endBeerTime.TimeOfDay)
        {
            Console.WriteLine("Beer time!");
        }
        else
        {
            Console.WriteLine("Non-beer time!");
        }
    }
}

