namespace HeroesVsMonsters.Utils;

public class De
{
    public De(int max)
    {
        Maximum = max;
    }


    public int Minimum { get; } = 1;
    public int Maximum { get; init; }


    public int Lance()
    {
        return Random.Shared.Next(Minimum, Maximum + 1);
    }
}
