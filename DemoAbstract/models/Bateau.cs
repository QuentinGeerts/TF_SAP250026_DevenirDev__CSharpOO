using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstract.models
{
    internal class Bateau : Vehicule
    {
        public override void SeDeplacer()
        {
            Console.WriteLine($"Le bateau {Modele} navigue !");
        }
    }
}
