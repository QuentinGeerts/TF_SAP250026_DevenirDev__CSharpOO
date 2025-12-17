namespace DemoEncapsulation.Models;

public class Personne
{
    protected string numeroRegistreNational;
    protected internal string numeroRegistre;
    private protected string nomComplet;

    void Information ()
    {
        Console.WriteLine($"{numeroRegistreNational}");
        Console.WriteLine($"{numeroRegistre}");
        Console.WriteLine($"{nomComplet}");
    }
}
