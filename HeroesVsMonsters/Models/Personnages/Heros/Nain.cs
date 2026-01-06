namespace HeroesVsMonsters.Models.Personnages.Heros;

internal class Nain : Hero
{
    public Nain(string nom) : base(nom)
    {
    }

    public override int Endurance => base.Endurance + 2;
}
