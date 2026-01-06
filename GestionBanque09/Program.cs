using GestionBanque.Exceptions;
using GestionBanque.Models;


Personne p1 = new Personne("Dupont", "Jean", new DateTime(1980, 1, 1));

Courant c1 = new Courant("BE4201", p1, 0);
Courant c2 = new Courant("BE0001", p1, 150);

Epargne e1 = new Epargne("BE4202", p1);


Banque maBanque = new Banque("Axa");


try
{

    Console.WriteLine("Ajout des comptes a la banque");
    maBanque.Ajouter(c1);
    maBanque.Ajouter(e1);

    double result = maBanque.AvoirDesComptes(p1);
    Console.WriteLine($"Avoir des comptes de {p1.Nom} - {p1.Prenom} = {result}");

    Console.WriteLine("Solde c1");
    Console.WriteLine(c1.Solde);

    Console.WriteLine("Depot de -500");
    c1.Depot(-500);
    Console.WriteLine("Solde c1");
    Console.WriteLine(c1.Solde);

    Console.WriteLine("Retrait de 600");
    c1.Retrait(600);
    Console.WriteLine("Solde c1");
    Console.WriteLine(c1.Solde);
}
catch (SoldeInsuffisantException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Solde c1");
Console.WriteLine(c1.Solde);


maBanque.Ajouter(c2);

try
{
    c2.Retrait(100);
}
catch (Exception e)
{
    Console.WriteLine($"Erreur: {e.Message}");
}

c2.Depot(150);
c2.Retrait(50);
c2.Retrait(50);