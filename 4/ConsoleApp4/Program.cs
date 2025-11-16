using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("{0,-8} {1,6}", "Name", "Count");

        string item1 = "Orange";
        int count1 = 12000;

        string item2 = "Bananas";
        int count2 = 340;

        string item3 = "Awakado";
        int count3 = 450000;

        Console.WriteLine("{0,-8} {1,6:N0}", item1, count1);
        Console.WriteLine("{0,-8} {1,6:N0}", item2, count2);
        Console.WriteLine("{0,-8} {1,6:N0}", item3, count3);
    }
}
