namespace DemoHeritagePolymorphisme.Models.Terrestre;

internal class Moto : VehiculeTerrestre
{
    public Moto(int nbRoues, string marque, string modele) : this(marque, modele)
    {
        NbRoues = nbRoues;
    }

    public Moto(string marque, string modele) : base(marque, modele)
    {
    }

    public Moto() : this("", "")
    {
        
    }

    public int NbRoues { get; set; } = 2;

    // Redéfinition de la méthode Demarrer présente dans Vehicule
    public override void Demarrer()
    {
        Console.WriteLine($"La moto démarre...");
    }
}
