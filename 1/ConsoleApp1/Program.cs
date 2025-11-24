using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine($"{n} — чётное число");
        else
            Console.WriteLine($"{n} — нечётное число");
    }
}
