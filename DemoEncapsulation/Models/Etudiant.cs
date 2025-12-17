namespace DemoEncapsulation.Models;

public class Etudiant : Personne
{
    public string prenom = "Anonyme";
    internal string nom = "Anonyme";
    private int age;

    void Information ()
    {
        Console.WriteLine($"{prenom} {nom} {numeroRegistreNational}");
        Console.WriteLine($"{numeroRegistre}");
        Console.WriteLine($"{nomComplet}");
        Console.WriteLine($"{age}");
    }
}
