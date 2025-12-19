namespace GestionBanque.Models;

public class Courant : Compte
{
    // Champs
    private double _ligneDeCredit;


    // Propriétés
    public double LigneDeCredit
    {
        get { return _ligneDeCredit; }
        set {
            if (value < 0) return; // À remplacer plus tard par une exception
            _ligneDeCredit = value;
        }
    }


    // Méthodes
    public override void Retrait(double montant)
    {
        base.Retrait(montant, LigneDeCredit);
    }

}
