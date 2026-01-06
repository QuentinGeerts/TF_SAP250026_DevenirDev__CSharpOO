using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstract.models
{
    internal class Chien : Animal
    {

        public override void EmmettreSon()
        {
            Console.WriteLine("Le chien aboie !");
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Le chien se deplace");
        }
    }
}
