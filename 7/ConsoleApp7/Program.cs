using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of eggs: ");
        string input = Console.ReadLine();

        try
        {
            int eggs = int.Parse(input);
            Console.WriteLine($"You have {eggs} eggs (parsed with int.Parse).");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input for int.Parse!");
        }

        if (int.TryParse(input, out int eggsTry))
        {
            Console.WriteLine($"You have {eggsTry} eggs (parsed with int.TryParse).");
        }
        else
        {
            Console.WriteLine("Invalid input for int.TryParse!");
        }
    }
}
