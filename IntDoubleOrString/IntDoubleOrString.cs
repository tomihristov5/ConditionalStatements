// Problem 9. Play with Int, Double and String
// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.

using System;

class IntDoubleOrString
{
    static void Main()
    {
        Console.Write("Enter 1 for int, 2 for double, 3 for string: ");
        int type = int.Parse(Console.ReadLine());
        switch (type)
	    {
		default: Console.WriteLine("Not a valid type!");
            break;
        case 1: Console.Write("Enter an integer: ");
            int intValue = int.Parse(Console.ReadLine());
            intValue = intValue + 1;
            Console.WriteLine("The new value is: " + intValue);
            break;
        case 2: Console.Write("Enter a double: ");
            double doubleValue = double.Parse(Console.ReadLine());
            doubleValue = doubleValue + 1;
            Console.Write("The new value is: " + doubleValue);
            break;
        case 3: Console.Write("Enter a string: ");
            string stringValue = Convert.ToString(Console.ReadLine());
            stringValue = stringValue + '*';
            Console.WriteLine("The new string is: " + stringValue);
            break;
	    }
    }
}

