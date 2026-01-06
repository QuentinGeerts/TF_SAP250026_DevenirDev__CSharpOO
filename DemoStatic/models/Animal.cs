namespace DemoStatic.models;

internal class Animal
{
    // Membre d'instance = lié à l'objet créé
    public string Nom { get; set; } = string.Empty;


    // Membre de classe = lié à la classe
    public static void Cri ()
    {
        Console.WriteLine($"Agreuh");
    }
}
