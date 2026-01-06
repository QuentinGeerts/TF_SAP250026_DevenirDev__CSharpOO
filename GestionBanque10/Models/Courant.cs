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
            if (value < 0)
            {
                throw new InvalidOperationException("La ligne de credit ne peut être négatif");
            }
            else
            {
                // À remplacer plus tard par une exception
                _ligneDeCredit = value;
            }
        }
    }

    public Courant(string numero , Personne titulaire, double ligneDeCredit) : base(numero,titulaire)
    {
        LigneDeCredit = ligneDeCredit;
    }

    // Méthodes
    public override void Retrait(double montant)
    {
        double soldeAvantRetrait = Solde;

        base.Retrait(montant, LigneDeCredit);

        if (soldeAvantRetrait >= 0 && Solde < 0) EnPassageEnNegatif();
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
