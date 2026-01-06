using GestionBanque.Models;

namespace GestionBanque.Interfaces;

internal interface IBanker : ICustomer
{
    void AppliquerInteret();

    Personne Titulaire { get;  }

    string Numero { get; }

}
