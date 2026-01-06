using DemoInterfaces.Interfaces;

namespace DemoInterfaces.models;

internal class User : Person, IUser
{
    public void AfficherInfoUser()
    {
        Console.WriteLine("Afficher info user");
    }

    public override void Login()
    {
        Console.WriteLine($"Login user: {Username} , {Password}");
    }

    public override void Logout()
    {
        Console.WriteLine("");
    }
}
