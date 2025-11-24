using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 – Сложить");
            Console.WriteLine("2 – Вычесть");
            Console.WriteLine("3 – Выход");
            Console.Write("Выберите действие: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 3)
            {
                Console.WriteLine("Выход...");
                break;
            }

            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;

                case 2:
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;

                default:
                    Console.WriteLine("Неверный пункт меню!");
                    break;
            }
        }
    }
}
