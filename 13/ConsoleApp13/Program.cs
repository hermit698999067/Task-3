using System;

record Passport(string Number, string Country);

class Program
{
    static void Main()
    {
        Passport passport1 = new Passport("AB123456", "Казахстан");

        Passport passport2 = passport1 with { Number = "CD789012" };

        Console.WriteLine(passport1);
        Console.WriteLine(passport2);

        Console.WriteLine("Равны ли паспорта? " + (passport1 == passport2));
    }
}
