using GestionBanque.Exceptions;
using GestionBanque.Interfaces;

namespace GestionBanque.Models;

// Création du délégué pour le passage en négatif
public delegate void PassageEnNegatifDelegate(Compte compte);

public abstract class Compte : IBanker
{
    public string Numero { get; private set; }
    public double Solde { get; private set; } // Lecture seule
    public Personne Titulaire { get; private set; }

    
    // Création de l'événement basé sur le délégué créé
    public event PassageEnNegatifDelegate PassageEnNegatifEvent;


    public Compte(string numero ,Personne titulaire)
    {
        Numero = numero;
        Titulaire = titulaire;
    }

    public Compte(string numero, Personne titulaire , double solde) : this(numero,titulaire)
    {
        Solde = solde;
    }

    //  Méthodes
    public void Depot(double montant)
    {
        if (montant <= 0) throw new ArgumentOutOfRangeException("Compte - Depot : inferieur ou égale a 0"); // À remplacer plus tard par une exception
        Solde = Solde + montant;
        Console.WriteLine($"Dépot de {montant} euros. [Solde restant: {Solde}]");
    }

    public virtual void Retrait(double montant)
    {
        Retrait(montant, 0);
    }

    protected void Retrait(double montant, double ligneDeCredit)
    {

        if (montant <= 0) throw new ArgumentNullException("Le montant est invalide"); // À remplacer plus tard par une exception
            if (Solde - montant < -ligneDeCredit) throw new SoldeInsuffisantException("Solde insuffisant Retrait" , "Compte") ; // À remplacer plus tard par une exception
            ; // À remplacer plus tard par une exception
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

    protected virtual void EnPassageEnNegatif()
    {
        //if (PassageEnNegatifEvent != null)
        //{
        //    PassageEnNegatifEvent(this);
        //}

        PassageEnNegatifEvent?.Invoke(this);
    }
}
