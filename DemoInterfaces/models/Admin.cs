using DemoInterfaces.Interfaces;

namespace DemoInterfaces.models;

internal class Admin : Person, IAdmin, ILogger
{
    public int Age { get; set; }
    public string Role { get; set; }
    public void AfficherInfoAdmin()
    {
        Console.WriteLine("Informations Admin");
    }


    public void AjouterUtilisateur(string username)
    {
        Console.WriteLine("Ajout utilisateur Admin");
    }

    public void SupprimerUtilisateur(string username)
    {
        Console.WriteLine("Suppression utilisateur Admin");
    }

    public void AfficherInfoUser()
    {
        Console.WriteLine("Afficher info admin");
    }

    public override void Login()
    {
        if (Username != "admin")
        {
            LogError("Un utilisateur essaie de se connecter avec le compte admin");
        }
        Console.WriteLine($"login admin : {Username} , {Password}");
    }

    public override void Logout()
    {
        Console.WriteLine("Logout admin");
    }

    public void LogInfo(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void LogWarning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void LogError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
