using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Utils;

namespace HeroesVsMonsters.Models.Personnages;

public abstract class Personnage
{
    private int _pointsVie;
    private int _maxPv;
    public Personnage(string nom)
    {
        Nom = nom;
        // Initialisation des statistiques
        Endurance = InitialisationStatistique();
        Force = InitialisationStatistique();
        PointsVie = _maxPv = Endurance + Modificateur(Endurance);
    }

    public string Nom { get; init; }
    public virtual int Endurance { get; private set; }
    public virtual int Force { get; private set; }
    public int PointsVie
    {
        get
        {
            return _pointsVie;
        }

        private set
        {
            _pointsVie = value;

            if (_pointsVie <= 0) Meurt?.Invoke(this);
        }
    }

    public int PointsVieMax => _maxPv;

    public De De4 { get; } = new De(4);
    public De De6 { get; } = new De(6);


    // Événement pour la mort
    public event Action<Personnage> Meurt;


    // Méthodes

    public void Frappe(Personnage cible)
    {
        int degats = De4.Lance() + Modificateur(Force);

        Typing.Write($"[Frappe] {Nom} inflige {degats} à {cible.Nom}.", delay:10, delayOut: 250);

        cible.PointsVie -= degats;
    }

    public void SeReposer()
    {
        PointsVie = _maxPv;
        Console.WriteLine($"[Repos] {Nom} s'est reposé.");
    }


    // Redéfinitions de méthodes
    public override string ToString()
    {
        return $"Nom: {Nom}" +
            $"\nType: {GetType().Name}" +
            $"\nPoints de vie: {PointsVie}" +
            $"\nForce: {Force}" +
            $"\nEndurance: {Endurance}" +
            $"{(this is IOr ? $"\nOr: {((IOr)this).Or}" : "")}" +
            $"{(this is ICuir ? $"\nCuir: {((ICuir)this).Cuir}" : "")}";
    }


    // Méthodes utilitaires
    private int Modificateur(int statistique)
    {
        return statistique < 5 ? -1
            : statistique < 10 ? 0
            : statistique < 15 ? 1
            : 2;
    }

    private int InitialisationStatistique()
    {
        List<int> lances = new();

        // 4 lancés du dé de 6 face 
        for (int i = 0; i < 4; i++)
        {
            lances.Add(De6.Lance());
        }

        lances.Sort((a, b) => b - a); // Permet de trier dans l'ordre inverse

        return lances[0] + lances[1] + lances[2];
    }

}
