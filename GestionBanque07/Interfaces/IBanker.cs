using GestionBanque.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBanque07.Interfaces
{
    internal interface IBanker : ICustomer
    {
        void AppliquerInteret();

        Personne Titulaire { get;  }

        string Numero { get; }

    }
}
