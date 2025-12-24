using System;

class BankCard
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Сумма пополнения должна быть больше 0");
            return;
        }

        balance += amount;
        Console.WriteLine($"Баланс пополнен на {amount}. Текущий баланс: {balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Сумма снятия должна быть больше 0");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Недостаточно средств");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Снято {amount}. Текущий баланс: {balance}");
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankCard card = new BankCard();

        card.Deposit(1000);
        card.Withdraw(300);
        card.Withdraw(1000); // ошибка — нельзя уйти в минус

        Console.WriteLine("Баланс через метод: " + card.GetBalance());
    }
}
