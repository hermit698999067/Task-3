using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        double number = 1234567.89;

        string[] cultures = { "ru-RU", "en-US", "de-DE" };

        foreach (var cultureName in cultures)
        {
            CultureInfo culture = new CultureInfo(cultureName);

            Console.WriteLine($"Culture: {cultureName}");

            Console.WriteLine($"Date: {now.ToString(culture)}");

            Console.WriteLine($"Number (N): {number.ToString("N", culture)}");
            Console.WriteLine($"Number (C): {number.ToString("C", culture)}");

            Console.WriteLine(new string('-', 30));
        }
    }
}
