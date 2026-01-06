using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstract.models
{
    internal class Voiture : Vehicule
    {

        public override void SeDeplacer()
        {
            Console.WriteLine($"La voiture {Modele} roule !");
        }

        public override void FaireLePlein()
        {
            base.FaireLePlein();
            Console.WriteLine($"La voiture a fait le plein ");
        }
    }
}
