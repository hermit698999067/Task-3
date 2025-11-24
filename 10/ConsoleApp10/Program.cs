using System;
using System.Collections.Generic;

class Program
{
    class Record
    {
        public string Name;
        public int Age;
        public int Score;
    }

    static void Main()
    {
        List<Record> validRecords = new List<Record>();
        List<string> errors = new List<string>();

        int lineNumber = 1;

        Console.WriteLine("Введите данные в формате: Имя,Возраст,Баллы");
        Console.WriteLine("Для завершения ввода оставьте строку пустой.");

        while (true)
        {
            Console.Write($"Строка {lineNumber}: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                break;

            string[] parts = input.Split(',');

            if (parts.Length != 3)
            {
                errors.Add($"Строка {lineNumber}: неверное количество элементов");
                lineNumber++;
                continue;
            }

            string name = parts[0].Trim();
            bool ageOk = int.TryParse(parts[1].Trim(), out int age);
            bool scoreOk = int.TryParse(parts[2].Trim(), out int score);

            if (!ageOk)
            {
                errors.Add($"Строка {lineNumber}: неверный возраст");
            }
            else if (age < 0 || age > 120)
            {
                errors.Add($"Строка {lineNumber}: возраст вне диапазона 0–120");
            }

            if (!scoreOk)
            {
                errors.Add($"Строка {lineNumber}: неверные баллы");
            }
            else if (score < 0 || score > 100)
            {
                errors.Add($"Строка {lineNumber}: баллы вне диапазона 0–100");
            }

            if (ageOk && scoreOk && age >= 0 && age <= 120 && score >= 0 && score <= 100)
            {
                validRecords.Add(new Record { Name = name, Age = age, Score = score });
            }

            lineNumber++;
        }

        Console.WriteLine("\nРезультаты:");

        if (validRecords.Count > 0)
        {
            double avgAge = 0;
            double avgScore = 0;

            foreach (var rec in validRecords)
            {
                avgAge += rec.Age;
                avgScore += rec.Score;
            }

            avgAge /= validRecords.Count;
            avgScore /= validRecords.Count;

            Console.WriteLine($"Количество валидных записей: {validRecords.Count}");
            Console.WriteLine($"Средний возраст: {avgAge:F2}");
            Console.WriteLine($"Средние баллы: {avgScore:F2}");
        }
        else
        {
            Console.WriteLine("Нет валидных записей.");
        }

        if (errors.Count > 0)
        {
            Console.WriteLine("\nОшибки:");
            foreach (string err in errors)
            {
                Console.WriteLine(err);
            }
        }
    }
}
