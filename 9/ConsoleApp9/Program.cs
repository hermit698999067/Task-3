using System;

class Program
{
    static void Main()
    {
        bool continueCalc = true;

        while (continueCalc)
        {
            try
            {
                Console.Write("Введите первое число: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Введите оператор (+, -, *, /): ");
                string opirationCalc = Console.ReadLine();

                double result;

                switch (opirationCalc)
                {
                    case "+":
                        result = a + b;
                        Console.WriteLine($"{a} + {b} = {result}");
                        break;

                    case "-":
                        result = a - b;
                        Console.WriteLine($"{a} - {b} = {result}");
                        break;

                    case "*":
                        result = a * b;
                        Console.WriteLine($"{a} * {b} = {result}");
                        break;

                    case "/":
                        if (b == 0)
                            throw new DivideByZeroException();
                        result = a / b;
                        Console.WriteLine($"{a} / {b} = {result}");
                        break;

                    default:
                        Console.WriteLine("Недопустимый оператор!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль невозможно!");
            }

            Console.Write("Хотите продолжить? (y/n): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y")
                continueCalc = false;
        }

        Console.WriteLine("Программа завершена.");
    }
}
