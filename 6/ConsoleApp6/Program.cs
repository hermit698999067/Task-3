using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите символ: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (char.IsLetter(c))
        {
            Console.WriteLine($"'{c}' — это буква");
        }
        else if (char.IsDigit(c))
        {
            Console.WriteLine($"'{c}' — это цифра");
        }
        else
        {
            Console.WriteLine($"'{c}' — это другой символ");
        }
    }
}
