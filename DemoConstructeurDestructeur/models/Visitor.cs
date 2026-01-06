using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConstructeurDestructeur.models
{
    internal class Visitor : Invite
    {
        public string VisitorName { get; set; }

        public Visitor(int id , string name,int numero) : base(id , name , numero)
        {
            VisitorName = "Visitor";
        }
    }
}
