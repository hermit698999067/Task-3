using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string age = Console.ReadLine();

        Console.WriteLine($"Hello {name}, you look good for {age}.");
    }
}
