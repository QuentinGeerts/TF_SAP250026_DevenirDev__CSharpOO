namespace DemoHeritagePolymorphisme.Models.Aerien;

internal class VehiculeAerien : Vehicule
{
    public VehiculeAerien(string marque = "", string modele = "") : base(marque, modele)
    {
    }

    public void Decoller()
    {
        Console.WriteLine($"Le véhicule aérien décolle...");
    }
    
    public void Atterir()
    {
        Console.WriteLine($"Le véhicule aérien atterit...");
    }

    public override void Demarrer()
    {
        base.Demarrer();
    }
}
