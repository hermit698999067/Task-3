using System;

class Program
{
    static void Main()
    {
        int fizzCount = 0;
        int buzzCount = 0;
        int fizzBuzzCount = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 15 == 0) 
            {
                Console.WriteLine("FizzBuzz");
                fizzBuzzCount++;
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
                fizzCount++;
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
                buzzCount++;
            }
            else
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Слово 'Fizz' встречается: {fizzCount} раз");
        Console.WriteLine($"Слово 'Buzz' встречается: {buzzCount} раз");
        Console.WriteLine($"Слово 'FizzBuzz' встречается: {fizzBuzzCount} раз");
    }
}
