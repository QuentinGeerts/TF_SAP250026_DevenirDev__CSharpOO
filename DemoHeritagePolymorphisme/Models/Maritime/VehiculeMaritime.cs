namespace DemoHeritagePolymorphisme.Models.Maritime;

internal class VehiculeMaritime : Vehicule
{
    public VehiculeMaritime() : this("", "")
    {
        
    }
    public VehiculeMaritime(string marque, string modele) : base(marque, modele)
    {
    }

    public void DemarrerHelice()
    {
        Console.WriteLine($"Le véhicule maritime démarre l'hélice...");
    }

    public void ArreterHelice()
    {
        Console.WriteLine($"Le véhicule maritime arrête l'hélice...");
    }
}
