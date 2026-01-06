namespace ExerciceCarwash.Models;

public delegate void CarwashDelegate(Voiture v);

internal class Carwash
{
    private CarwashDelegate traitements = null;

    public Carwash()
    {
        traitements += Preparer;
        traitements += Laver;
        traitements += Secher;
        traitements += Finaliser;
    }

    private void Preparer(Voiture v)
    {
        Console.WriteLine($"je prépare la voiture : {v.Plaque}");
    }
    private void Laver(Voiture v)
    {
        Console.WriteLine($"je lave la voiture : {v.Plaque}");
    }
    private void Secher(Voiture v)
    {
        Console.WriteLine($"je sèche la voiture : {v.Plaque}");
    }
    private void Finaliser(Voiture v)
    {
        Console.WriteLine($"je finalise la voiture : {v.Plaque}");
    }
    public void Traiter(Voiture v)
    {
        Console.WriteLine($"Traitement de la voiture {v.Plaque}:");
        traitements?.Invoke(v);
    }
}
