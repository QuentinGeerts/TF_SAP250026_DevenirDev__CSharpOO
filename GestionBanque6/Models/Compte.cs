namespace GestionBanque.Models;

public abstract class Compte
{
    public string Numero { get; set; }
    public double Solde { get; private set; } // Lecture seule
    public Personne Titulaire { get; set; }


    //  Méthodes
    public void Depot(double montant)
    {
        if (montant <= 0) return; // À remplacer plus tard par une exception
        Solde = Solde + montant;
        Console.WriteLine($"Dépot de {montant} euros. [Solde restant: {Solde}]");
    }

    public virtual void Retrait(double montant)
    {
        Retrait(montant, 0);
    }

    protected void Retrait(double montant, double ligneDeCredit)
    {
        if (montant <= 0) return; // À remplacer plus tard par une exception
        if (Solde - montant < -ligneDeCredit) return; // À remplacer plus tard par une exception
        Solde -= montant;
        Console.WriteLine($"Retrait de {montant} euros. [Solde restant: {Solde}]");
    }

    //  Surcharge d'opérateurs
    public static double operator +(double somme, Compte courant)
    {
        //if (courant.Solde >= 0) return courant.Solde + somme;
        //else return 0;

        return courant.Solde >= 0 ? courant.Solde + somme : 0;
    }

    protected abstract double CalculInteret();

    public void AppliquerInteret()
    {
        Solde += CalculInteret();
    }
}
