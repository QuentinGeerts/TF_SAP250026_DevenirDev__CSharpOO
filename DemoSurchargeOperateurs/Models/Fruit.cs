namespace DemoSurchargeOperateurs.Models;

public class Fruit
{
    public string Nom { get; set; }
    public double Poids { get; set; }

    public override string ToString()
    {
        return $"{Nom} - {Poids} kg";
    }
}
