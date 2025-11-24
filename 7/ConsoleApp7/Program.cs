using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        int number;

        try
        {
            number = int.Parse(input);
            Console.WriteLine($"Успешно! Вы ввели число: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод! Пытаемся преобразовать безопасно...");

            if (int.TryParse(input, out number))
            {
                Console.WriteLine($"Безопасное преобразование удалось! Число: {number}");
            }
            else
            {
                Console.WriteLine("Ошибка: строку невозможно преобразовать в число.");
            }
        }
    }
}
