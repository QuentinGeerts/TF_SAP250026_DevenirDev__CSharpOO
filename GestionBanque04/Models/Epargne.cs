namespace GestionBanque.Models;

public class Epargne : Compte
{
    //  Propriétés
    public DateTime DateDernierRetrait { get; private set; }

    public override void Retrait(double montant)
    {
        base.Retrait(montant);
        DateDernierRetrait = DateTime.Now;
    }
}
