using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Models.Personnages;

namespace HeroesVsMonsters.Models.Personnages.Heros;

public abstract class Hero : Personnage, ICuir, IOr
{
    public Hero(string nom) : base(nom)
    {
    }

    public int Cuir { get; set; }

    public int Or { get; set; }


    public void Loot(Personnage p)
    {
        if (p is IOr cibleOr)
        {
            Console.WriteLine($"[Loot] Récupération de {cibleOr.Or}x Or.");
            Or += cibleOr.Or;
        }

        if (p is ICuir cibleCuir)
        {
            Console.WriteLine($"[Loot] Récupération de {cibleCuir.Cuir}x Cuir.");
            Cuir += cibleCuir.Cuir;
        }
    }
}
