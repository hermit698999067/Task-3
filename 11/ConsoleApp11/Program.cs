using System;

class University
{
    public const string Country = "Казахстан";

    public readonly int FoundedYear;

    public University(int foundedYear)
    {
        FoundedYear = foundedYear;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Страна: {Country}");
        Console.WriteLine($"Год основания: {FoundedYear}");
    }
}

class Program
{
    static void Main()
    {
        University uni = new University(1934);
        uni.PrintInfo();
    }
}
