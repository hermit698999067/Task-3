using System;

class Program
{
    static void Main()
    {
        object height = 1.88;      
        object name = "Artyom";    

        double realHeight = (double)height;
        string realName = (string)name;

        int nameLength = realName.Length;

        Console.WriteLine($"Height: {realHeight}");
        Console.WriteLine($"Name length: {nameLength}");
    }
}
