namespace DemoHeritagePolymorphisme.Models.Terrestre;

internal class VehiculeTerrestre : Vehicule
{
    
    public VehiculeTerrestre(string marque = "", string modele = "") : base(marque, modele)
    {
        
    }

    public int Vitesse { get; private set; }

    public void Accelerer()
    {
        Console.WriteLine($"Le véhicule terrestre accélère...");
        Vitesse++;
    }

    public void Accelerer(int vitesse)
    {
        Console.WriteLine($"Le véhicule terrestre accélère...");
        Vitesse += vitesse;
    }


    public void Freiner ()
    {
        Console.WriteLine($"Le véhicule terrestre freine...");
        Vitesse--;
    }
}
