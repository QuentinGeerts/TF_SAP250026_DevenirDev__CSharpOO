namespace DemoHeritagePolymorphisme.Models.Maritime;

internal class Bateau : VehiculeMaritime
{
    public Bateau()
    {
    }

    public Bateau(string marque, string modele) : base(marque, modele)
    {
    }

    public bool AVoile { get; set; }

    public override void Demarrer()
    {
        // base: la référence du parent
        base.Demarrer(); // Utilisation de la méthode Demarrer présente dans le parent
        Console.WriteLine($"PS: c'est un bateau");
    }
}
