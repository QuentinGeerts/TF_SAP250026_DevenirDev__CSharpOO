namespace ExerciceCarwash.Models;

public delegate void CarwashDelegate(Voiture v);

internal class Carwash
{
    private CarwashDelegate traitements = null;

    public Carwash()
    {
        traitements += delegate (Voiture v) { Console.WriteLine($"je prépare la voiture : {v.Plaque}"); };
        traitements += (Voiture v) => { Console.WriteLine($"je lave la voiture : {v.Plaque}"); };
        traitements += (Voiture v) => Console.WriteLine($"je sèche la voiture : {v.Plaque}");
        traitements += v => Console.WriteLine($"je finalise la voiture : {v.Plaque}");
    }

    public void Traiter(Voiture v)
    {
        Console.WriteLine($"Traitement de la voiture {v.Plaque}:");
        traitements?.Invoke(v);
    }
}
