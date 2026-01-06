namespace ExerciceCarwash.Models;

public class Voiture
{
    public string Plaque { get; init; }

    public Voiture(string plaque)
    {
        Plaque = plaque;
    }
}
