using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstract.models
{
    internal class Chat : Animal
    {

        public override void EmmettreSon()
        {
            Console.WriteLine("Le chat miaule !");
        }

        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.WriteLine("Le chat se deplace");
        }
    }
}
