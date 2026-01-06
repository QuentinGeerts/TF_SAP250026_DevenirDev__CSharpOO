namespace GestionBanque.Interfaces;

internal interface ICustomer
{
    double Solde { get; }

    void Retrait(double montant);
    void Depot(double montant);
}
