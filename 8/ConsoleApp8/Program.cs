using System;

class Book
{
    public string Title;
    public string Author;
    public int Year;

    public Book(string title)
    {
        Title = title;
        Author = "Неизвестен";
        Year = 0;
    }

    public Book(string title, string author, int year)
        : this(title)
    {
        Author = author;
        Year = year;
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("1984");
        Book book2 = new Book("Мастер и Маргарита", "М. Булгаков", 1967);

        Console.WriteLine($"{book1.Title}, {book1.Author}, {book1.Year}");
        Console.WriteLine($"{book2.Title}, {book2.Author}, {book2.Year}");
    }
}
