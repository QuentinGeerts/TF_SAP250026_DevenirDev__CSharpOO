using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Utils;

namespace HeroesVsMonsters.Models.Personnages.Monstres;

public class Orque : Monstre, IOr
{
    public Orque() : base(GenerateurNom.Orques[Random.Shared.Next(GenerateurNom.Orques.Length)])
    {
        Or = De6.Lance();
    }

    public int Or { get; init; }
    public override int Force => base.Force + 1;
}
