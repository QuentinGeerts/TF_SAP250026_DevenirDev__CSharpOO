namespace DemoConstructeurDestructeur.models;

internal class Voiture
{
    public string Marque { get; set; } = string.Empty;
    public Proprietaire Proprietaire { get; set; }

    public Voiture()
    {
        Console.WriteLine($"La voiture a été créée.");
    }

    public Voiture(string marque) : this()
    {
        Marque = marque;
    }

    public Voiture(Proprietaire proprietaire)
    {
        Proprietaire = proprietaire;
    }
}
