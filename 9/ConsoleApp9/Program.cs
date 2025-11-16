using System;

class Program
{
    static void Main()
    {
        string name;
        do
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(name));

        int age;
        while (true)
        {
            Console.Write("Enter your age (0-120): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out age) && age >= 0 && age <= 120)
                break;
            Console.WriteLine("Invalid age. Please try again.");
        }

        double height;
        while (true)
        {
            Console.Write("Enter your height in meters: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out height) && height > 0)
                break;
            Console.WriteLine("Invalid height. Please try again.");
        }

        decimal salary;
        while (true)
        {
            Console.Write("Enter your salary: ");
            string input = Console.ReadLine();
            if (decimal.TryParse(input, out salary) && salary > 0)
                break;
            Console.WriteLine("Invalid salary. Please try again.");
        }

        Console.WriteLine("\nUser Summary:");
        Console.WriteLine("{0,-10} {1,6} {2,8} {3,12}", "Name", "Age", "Height", "Salary");
        Console.WriteLine("{0,-10} {1,6} {2,8:N2} {3,12:C}", name, age, height, salary);
    }
}
