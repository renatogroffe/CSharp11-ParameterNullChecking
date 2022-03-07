namespace ExemploParameterNullChecking;

public static class MessageHelper
{
    public static void Show(string message!!)
    {
        Console.WriteLine($"- {message}");
    }
}