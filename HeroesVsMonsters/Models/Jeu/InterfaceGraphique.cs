using HeroesVsMonsters.Models.Personnages;

namespace HeroesVsMonsters.Models.Jeu;

public static class InterfaceGraphique
{
    public static string AfficherBarreVie(Personnage p)
    {
        int barresRemplies = (int)Math.Round((double)p.PointsVie / p.PointsVieMax * 10);
        barresRemplies = Math.Clamp(barresRemplies, 0, 10);

        string barreRemplie = new string('█', barresRemplies);
        string barreVide = new string(' ', 10 - barresRemplies);

        return $"[ {barreRemplie}{barreVide} ] ({p.PointsVie}/{p.PointsVieMax})";
    }
}
