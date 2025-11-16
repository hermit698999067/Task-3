using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter something: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int intValue))
        {
            Console.WriteLine("This is an int.");
            return;
        }

        if (double.TryParse(input, out double doubleValue))
        {
            Console.WriteLine("This is a double.");
            return;
        }

        if (bool.TryParse(input, out bool boolValue))
        {
            Console.WriteLine("This is a bool.");
            return;
        }

        Console.WriteLine("This is a string.");
    }
}
