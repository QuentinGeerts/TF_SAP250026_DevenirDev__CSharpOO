namespace DemoHeritagePolymorphisme.Models;

internal class Vehicule
{
    public Vehicule(string marque, string modele)
    {
        Marque = marque;
        Modele = modele;
    }

    //  Caractéristiques
    public string Marque { get; init; } = string.Empty;
    public string Modele { get; init; } = string.Empty;


    //  Méthodes

    // virtual: indique que la méthode peut être redéfinie dans les enfants
    public virtual void Demarrer()
    {
        Console.WriteLine($"Le véhicule démarre...");
    }

    public void Arreter()
    {
        Console.WriteLine($"Le véhicule s'arrête...");
    }
}
