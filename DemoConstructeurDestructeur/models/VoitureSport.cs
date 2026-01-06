namespace DemoConstructeurDestructeur.models;

internal class VoitureSport : Voiture
{
    public VoitureSport()
    {
    }

    public VoitureSport(string marque) : base(marque)
    {
        
    }

    public VoitureSport(Proprietaire proprietaire) : base(proprietaire)
    {
    }

    ~VoitureSport()
    {
        Console.WriteLine($"Suppression de la voiture de sport");
    }
}
