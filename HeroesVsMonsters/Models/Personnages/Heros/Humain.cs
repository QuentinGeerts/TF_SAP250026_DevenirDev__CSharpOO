namespace HeroesVsMonsters.Models.Personnages.Heros;

internal class Humain : Hero
{
    public Humain(string nom) : base(nom)
    {
    }

    public override int Endurance => base.Endurance + 1; // (modifier l'endurance pour plus de points de vie et tanker :)
    public override int Force => base.Force + 1;
}
