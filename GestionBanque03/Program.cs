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
c2.Depot(20);

Console.WriteLine($"c1: {c1.Solde}");
Console.WriteLine($"c2: {c2.Solde}");

//c1.Retrait(500);
//c2.Retrait(200);

Console.WriteLine($"c1: {c1.Solde}");
Console.WriteLine($"c2: {c2.Solde}");

// 2. Création de la banque

Banque b = new Banque { Nom = "TechnoBank" };
b.Ajouter(c1);
b.Ajouter(c2);
b.Ajouter(c2);

Console.WriteLine($"Liste des comptes:");
Console.WriteLine($"{b.AfficherComptes()}");

//b.Supprimer(c1.Numero);
//b.Supprimer(c1.Numero);

Courant? c2Copie = b[c2.Numero];


// Surcharge des opérateurs

Courant c3 = new Courant
{
    Numero  = "00003",
    Titulaire = p1,
    LigneDeCredit = 0
};
b.Ajouter(c3);
c3.Depot(500);

Console.WriteLine($"{b.AfficherComptes()}");

Console.WriteLine($"Avoir des comptes: p1: {b.AvoirDesComptes(p1)}");
Console.WriteLine($"Avoir des comptes: p2: {b.AvoirDesComptes(p2)}");