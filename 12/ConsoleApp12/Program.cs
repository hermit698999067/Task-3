using System;

class Printer
{
    public void Print(string text)
    {
        Console.WriteLine(text);
    }

    public void Print(string text, int repeat)
    {
        for (int i = 0; i < repeat; i++)
        {
            Console.WriteLine(text);
        }
    }
}

class Program
{
    static void Main()
    {
        Printer printer = new Printer();

        printer.Print("Привет!");
        printer.Print("Повторяю...", 3);
    }
}
