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

    protected override double CalculInteret()
    {
        double result = 0;
        if(Solde >= 0)
        {
            result = Solde * 0.03;
        }
        else
         if(Solde < 0)
        {
            result =  Solde * 0.075;
        }
        return result;
    }
}
