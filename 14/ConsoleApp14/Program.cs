using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Order
{
    public List<Product> Products { get; set; } = new List<Product>();

    public void AddProduct(Product p)
    {
        Products.Add(p);
        Console.WriteLine($"Добавлен продукт: {p.Name}, цена {p.Price}");
    }

    public void RemoveProduct(string name)
    {
        Product product = Products.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            Products.Remove(product);
            Console.WriteLine($"Удалён продукт: {name}");
        }
        else
        {
            Console.WriteLine($"Продукт {name} не найден");
        }
    }

    public decimal TotalPrice
    {
        get
        {
            return Products.Sum(p => p.Price);
        }
    }

    public void PrintProducts()
    {
        Console.WriteLine("Список продуктов:");
        foreach (var p in Products)
        {
            Console.WriteLine($"{p.Name} — {p.Price}");
        }
        Console.WriteLine($"Общая сумма: {TotalPrice}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Order order = new Order();

        Product p1 = new Product("Хлеб", 100);
        Product p2 = new Product("Молоко", 200);
        Product p3 = new Product("Сыр", 500);

        order.AddProduct(p1);
        order.AddProduct(p2);
        order.AddProduct(p3);

        order.PrintProducts();

        order.RemoveProduct("Молоко");
        order.PrintProducts();

        order.RemoveProduct("Яйца");
    }
}
