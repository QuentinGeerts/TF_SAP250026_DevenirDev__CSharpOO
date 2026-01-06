using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBanque08.Interfaces
{
    internal interface ICustomer
    {
        double Solde { get; }

        void Retrait(double montant);
        void Depot(double montant);
    }
}
