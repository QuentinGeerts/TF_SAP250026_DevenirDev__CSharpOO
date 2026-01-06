using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Utils;

namespace HeroesVsMonsters.Models.Personnages.Monstres;

public class Loup : Monstre, ICuir
{

    public Loup() : base(GenerateurNom.Loups[Random.Shared.Next(GenerateurNom.Loups.Length)])
    {
        Cuir = De4.Lance();
    }

    public int Cuir { get; init; }
}
