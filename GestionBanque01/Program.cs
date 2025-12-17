using GestionBanque.Models;


Personne p1 = new Personne
{
    Nom = "Doe",
    Prenom = "John",
    DateNaiss = DateTime.Now
};

Personne p2 = new Personne
{
    Nom = "Geerts",
    Prenom = "Quentin",
    DateNaiss = new DateTime(1996, 4, 3)
};

Courant c1 = new Courant
{
    Numero = "00001",
    Titulaire = p1,
    LigneDeCredit = 0
};


Courant c2 = new Courant
{
    Numero = "00002",
    Titulaire = p2,
    LigneDeCredit = 200
};

c1.Depot(500);
c2.Depot(-500);

Console.WriteLine($"c1: {c1.Solde}");
Console.WriteLine($"c2: {c2.Solde}");

c1.Retrait(500);
c2.Retrait(200);

Console.WriteLine($"c1: {c1.Solde}");
Console.WriteLine($"c2: {c2.Solde}");