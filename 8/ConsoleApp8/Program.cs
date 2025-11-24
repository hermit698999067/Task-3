using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int number = 0;

        Console.WriteLine("Введите числа (0 — завершить):");

        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                if (number == 0) 
                    break;

                sum += number;
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное число!");
            }
        }

        Console.WriteLine($"Сумма чисел = {sum}");
    }
}
