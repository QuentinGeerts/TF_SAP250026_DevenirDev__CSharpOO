namespace DemoHeritagePolymorphisme.Models.Terrestre;

internal class Voiture : VehiculeTerrestre
{
    public Voiture() : this(string.Empty, "", 5)
    {
        
    }

    public Voiture(string marque, string modele, int nbPortes) : base(marque, modele)
    {
        NbPortes = nbPortes;
    }

    public int NbPortes { get; set; } = 5;
}
