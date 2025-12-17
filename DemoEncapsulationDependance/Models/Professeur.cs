using DemoEncapsulation.Models;

namespace DemoEncapsulationDependance.Models;

internal class Professeur : Personne
{
    string matricule;

    internal void Information ()
    {
        Console.WriteLine($"{numeroRegistreNational}");
        Console.WriteLine($"{numeroRegistre}");
        //Console.WriteLine($"{nomComplet}"); // Ne fonctionne pas
    }
}
