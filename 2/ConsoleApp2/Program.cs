using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
            sum += i;
        }

        Console.WriteLine($"Сумма = {sum}");
    }
}
