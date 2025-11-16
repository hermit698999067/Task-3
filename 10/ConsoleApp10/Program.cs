using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Значения по умолчанию
        string name = "User";
        decimal sum = 1000m;
        string currencyCode = "USD";
        string cultureCode = "en-US";

        // Разбор аргументов командной строки
        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--name":
                    if (i + 1 < args.Length && !string.IsNullOrWhiteSpace(args[i + 1]))
                        name = args[i + 1];
                    i++;
                    break;
                case "--sum":
                    if (i + 1 < args.Length && decimal.TryParse(args[i + 1], out decimal parsedSum))
                        sum = parsedSum;
                    i++;
                    break;
                case "--currency":
                    if (i + 1 < args.Length && !string.IsNullOrWhiteSpace(args[i + 1]))
                        currencyCode = args[i + 1].ToUpper();
                    i++;
                    break;
            }
        }

        // Определяем культуру для валюты
        CultureInfo culture;
        try
        {
            culture = new CultureInfo(cultureCode);
        }
        catch
        {
            culture = CultureInfo.InvariantCulture;
        }

        // Создаём формат валюты
        NumberFormatInfo nfi = (NumberFormatInfo)culture.NumberFormat.Clone();
        nfi.CurrencySymbol = currencyCode;

        // Вывод с интерполяцией строк
        Console.WriteLine($"Hello {name}, your sum is {sum.ToString("C", nfi)}");
    }
}
