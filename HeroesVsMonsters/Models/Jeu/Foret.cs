using HeroesVsMonsters.Enums;
using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Models.Personnages;
using HeroesVsMonsters.Models.Personnages.Heros;
using HeroesVsMonsters.Models.Personnages.Monstres;
using HeroesVsMonsters.Utils;

namespace HeroesVsMonsters.Models.Jeu;

public class Foret
{
    public Foret()
    {
        Initialisation();
    }

    private Hero Hero { get; set; }
    private List<Monstre> Monstres { get; set; } = new List<Monstre>();

    private int NbCombat { get; set; }
    private int Position { get; set; }

    private void Initialisation()
    {
        // Début du jeu
        Typing.Write("Bienvenue dans la forêt de « Shorewood », forêt enchantée du pays de « Stormwall ».");
        Typing.Write("Dans cette forêt, se livre un combat acharné entre les héros d’une part et les monstres d’autre part.");

        Typing.WaitForEnter();

        Jouer();
    }

    public void Jouer()
    {
        Typing.Write($"[ Heros vs Monsters ]");

        // Création du personnage
        CreationHero();

        // Génération des monstres
        CreationMonstres();

        // Bagarre
        Expedition();

    }


    private void MortPersonnage(Personnage p)
    {
        if (p is Hero h)
        {
            Console.Clear();

            Console.WriteLine($" >> Game Over");

            Console.WriteLine($"Or amassés: {Hero.Or}");
            Console.WriteLine($"Cuir amassés: {Hero.Cuir}");
        }
        else
        {
            AfficherStatut(Hero, (Monstre)p);
            Typing.Write($"{p.Nom} meurt.");
            NbCombat++;

            Typing.WaitForEnter();
            Console.Clear();
            Hero.Loot(p);
            Hero.SeReposer();

            Monstres.Remove((Monstre)p);
            Typing.WaitForEnter();

            // Lancement du prochain combat
            Expedition();
        }
    }

    private void Expedition()
    {
        Console.Clear();
        if (Monstres.Count > 0)
        {
            Combat(Hero, Monstres[Random.Shared.Next(Monstres.Count)]);
        }
        else
        {
            Typing.Write("Plus d'ennemi à combattre. Félicitations !");

            Console.WriteLine($"Or amassés: {((IOr)Hero).Or}");
            Console.WriteLine($"Cuir amassés: {((ICuir)Hero).Cuir}");
        }
    }

    private void CreationHero()
    {
        Typing.Write($"[ Création du héro ]");

        Typing.Write($"Liste des classes disponibles: ");

        foreach (Heros classe in Enum.GetValues<Heros>())
        {
            Typing.Write($" - [{(int)classe}] {classe}");
        }

        Typing.Write("Choix: ", false);

        Heros hero;

        while (!Enum.TryParse(Console.ReadLine(), true, out hero) || !Enum.IsDefined(hero))
        {
            Console.WriteLine($"Erreur, réessayez: ");
        }

        Typing.Write($"Entrez votre pseudo: ", false);
        string pseudo = Console.ReadLine() ?? "NoName";

        Hero = hero switch
        {
            Heros.Humain => new Humain(pseudo),
            Heros.Nain => new Nain(pseudo)
        };

        Hero.Meurt += MortPersonnage;

        Console.WriteLine($"\n{Hero}");

        Typing.WaitForEnter();
    }


    private void CreationMonstres()
    {
        Typing.Write($"[ Création des monstres ]");

        for (int i = 0; i < 10; i++)
        {
            // Expression switch
            Monstre monstre = Random.Shared.Next(Enum.GetValues<Monstres>().Length) switch
            {
                0 => new Loup(),
                1 => new Orque(),
                _ => new Dragonnet()
            };
            monstre.Meurt += MortPersonnage;
            Monstres.Add(monstre);
        }

        Typing.WaitForEnter();
    }

    private void Combat(Hero hero, Monstre monstre)
    {
        Typing.Write($"Combat n°{NbCombat + 1} entre {hero.Nom} [{hero.GetType().Name}] et {monstre.Nom} [{monstre.GetType().Name}]");

        bool tourHero = true;
        Position = 4;


        while (hero.PointsVie > 0 && monstre.PointsVie > 0)
        {
            AfficherStatut(hero, monstre);

            if (tourHero)
            {
                hero.Frappe(monstre);
            }
            else
            {
                monstre.Frappe(hero);
            }

            tourHero = !tourHero;
        }
    }

    private void AfficherStatut(Hero hero, Monstre monstre)
    {
        Console.SetCursorPosition(0, 2);
        Console.WriteLine($"{hero.Nom}: {InterfaceGraphique.AfficherBarreVie(hero)} \t{monstre.Nom}: {InterfaceGraphique.AfficherBarreVie(monstre)}");
        Console.SetCursorPosition(0, Position++);
    }
}
