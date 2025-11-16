using System;

class Program
{
    static void Main()
    {
        string? nickname = null;

        Console.Write("Enter your nickname (or leave empty): ");
        string input = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(input))
            nickname = null;
        else
            nickname = input;

        int length = GetNicknameLength(nickname);

        Console.WriteLine($"Nickname length: {length}");
    }

    static int GetNicknameLength(string? nickname)
    {
        return nickname?.Length ?? 0;
    }
}
