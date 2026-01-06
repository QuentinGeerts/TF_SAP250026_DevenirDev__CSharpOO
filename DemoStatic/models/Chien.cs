namespace DemoStatic.models;

internal class Chien : Animal
{
    public int Age { get; set; }
    public static new void Cri()
    {
        //Animal.Cri();
        Console.WriteLine($"Wouaf !");
    }
}
