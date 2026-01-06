namespace GestionBanque.Models;

public class Epargne : Compte
{
    //  Propriétés
    public DateTime DateDernierRetrait { get; private set; }

    public Epargne(string numero , Personne titulaire) : base(numero , titulaire)
    {
        
    }
    public override void Retrait(double montant)
    {
        base.Retrait(montant);
        DateDernierRetrait = DateTime.Now;
    }

    protected override double CalculInteret()
    {
        return Solde * 0.045;
    }
}
