using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Utils;

namespace HeroesVsMonsters.Models.Personnages.Monstres;

public class Dragonnet : Monstre, IOr, ICuir
{
    public Dragonnet() : base(GenerateurNom.Dragonnets[Random.Shared.Next(GenerateurNom.Dragonnets.Length)])
    {
        Cuir = De4.Lance();
        Or = De6.Lance();
    }

    public int Cuir { get; init;}
    public int Or { get; init; }

    public override int Endurance => base.Endurance + 1;
}
