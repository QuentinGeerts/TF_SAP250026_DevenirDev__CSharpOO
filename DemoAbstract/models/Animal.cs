using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstract.models
{
    internal abstract class Animal
    {
        public int Age { get; set; }

        public string Nom { get; set; }

        public string Couleur { get; set; }

        // Méthode abstraite : pas d'implémentation ici
        public abstract void EmmettreSon();

        // Méthode virtuelle : implémentation par défaut
        public virtual void SeDeplacer()
        {
            Console.WriteLine("L'animal se déplace.");
        }

    }
}
