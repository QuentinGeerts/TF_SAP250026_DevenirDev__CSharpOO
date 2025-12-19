namespace DemoHeritagePolymorphisme.Models.Aerien;

internal class Avion : VehiculeAerien
{
    public double Envergure { get; set; }

    public override void Demarrer()
    {
        base.Demarrer();
    }
}
