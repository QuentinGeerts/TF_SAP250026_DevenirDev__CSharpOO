namespace GestionBanque.Models;

public class Courant
{
    // Champs
    private double _ligneDeCredit;


    // Propriétés
    public string Numero { get; set; }
    public double Solde { get; private set; } // Lecture seule
    public double LigneDeCredit
    {
        get { return _ligneDeCredit; }
        set {
            if (value < 0) return; // À remplacer plus tard par une exception
            _ligneDeCredit = value;
        }
    }
    public Personne Titulaire { get; set; }


    // Méthodes
    public void Depot(double montant)
    {
        if (montant <= 0) return; // À remplacer plus tard par une exception
        Solde = Solde + montant;
        Console.WriteLine($"Dépot de {montant} euros. [Solde restant: {Solde}]");
    }
    public void Retrait(double montant)
    {
        if (montant <= 0) return; // À remplacer plus tard par une exception
        if (Solde - montant < -LigneDeCredit) return; // À remplacer plus tard par une exception
        Solde -= montant;
        Console.WriteLine($"Retrait de {montant} euros. [Solde restant: {Solde}]");
    }


    //  Surcharge d'opérateurs
    public static double operator +(double somme, Courant courant)
    {
        //if (courant.Solde >= 0) return courant.Solde + somme;
        //else return 0;

        return courant.Solde >= 0 ? courant.Solde + somme : 0;
    }
}
