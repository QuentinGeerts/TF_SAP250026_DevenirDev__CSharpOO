namespace DemoDelegues.Models;

internal static class SystemMessage
{
    public static void AfficherDansConsole(string message)
    {
        Console.WriteLine($"Console: {message}");
    }

    public static void AfficherEnMajuscule(string message)
    {
        Console.WriteLine($"Majuscule: {message.ToUpper()}");
    }

    public static void AfficherEnMinuscule(string message)
    {
        Console.WriteLine($"Minuscule: {message.ToLower()}");
    }

    public static void EnvoyerParPigeon(string message)
    {
        Console.WriteLine($"Pigeon: {message}");
    }

    public static void EnvoyerParSMS(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }

    public static void EnvoyerParEmail(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}
