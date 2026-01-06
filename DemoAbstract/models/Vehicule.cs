using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstract.models
{
    internal abstract class Vehicule
    {
        public string Moteur { get; set; }

        public Guid NumSerie { get; set; }

        public string Modele { get; set; }

        public virtual void FaireLePlein()
        {
            Console.WriteLine($"Le vehicule {NumSerie} fait le plein");
        }

        public abstract void SeDeplacer();

        //public virtual void Demarrer()
        //{
        //    SeDeplacer();
        //}
    }
}
