// Problem 3. Check for a Play Card
// Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
// Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

using System;
using System.Linq; // To use the "Contains" method

class CheckForAPlayCard
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        // Using an array to put the designated card signs in it
        string[] deckOfCards = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        Console.Write("Enter a playing card: ");
        string card = Convert.ToString(Console.ReadLine());
        if (deckOfCards.Contains(card)) //Checking if the card sign entered belong to the deck
        {
            Console.WriteLine("Yes, {0} is a valid card!", card);
        }
        else
            Console.WriteLine("No, the card is invalid!");
    }
}

