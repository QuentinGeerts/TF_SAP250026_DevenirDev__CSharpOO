

using DemoIndexeurs.Models;

Ludotheque ludotheque = new Ludotheque();

JeuVideo godOfWar = new JeuVideo
{
    Titre = "God of War",
    Studio = "Santa Monica",
    AnneeParution = 2005
};

ludotheque.AjouterJeu(godOfWar);

JeuVideo monsterHunter = new()
{
    Titre = "Monster Hunter",
    Studio = "Capcom",
    AnneeParution = 2004
};

ludotheque.AjouterJeu(monsterHunter);

ludotheque.AjouterJeu(new JeuVideo
{
    Titre = "Dark Souls",
    Studio = "FromSoftWare",
    AnneeParution = 2011
});

ludotheque.AjouterJeu(new JeuVideo
{
    Titre = "Baldur's Gate 3",
    Studio = "Larian Studio",
    AnneeParution = 2023
});

Console.WriteLine(ludotheque.AfficherListe());

Console.WriteLine($"Jeu vidéo: {godOfWar.ToString()}");
Console.WriteLine($"Ludothèque: {ludotheque.ToString()}");

JeuVideo copieIllegale = new JeuVideo
{
    Titre = "God of War",
    Studio = "Santa Monica",
    AnneeParution = 2005
};

Console.WriteLine($"null: {godOfWar.Equals(null)}"); // false
Console.WriteLine($"godOfWar: {godOfWar.Equals(godOfWar)}"); // true
Console.WriteLine($"monsterHunter: {godOfWar.Equals(monsterHunter)}"); // false
Console.WriteLine($"copieIllegale: {godOfWar.Equals(copieIllegale)}"); // true

JeuVideo jv1 = ludotheque[0]; // Récupération de God of War
ludotheque[0] = godOfWar; // Ne va pas fonctionner
ludotheque[0] = null; // Ne va pas fonctionner
ludotheque[0] = monsterHunter; // Ne va pas fonctionner
ludotheque[0] = new JeuVideo
{
    Titre = "Clair Obscur: Expédition 33",
    Studio = "Sandfall",
    AnneeParution = 2025
}; // Fonctionne

Console.WriteLine(ludotheque.AfficherListe());

Console.WriteLine($"{monsterHunter.Titre}");