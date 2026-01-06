using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DemoConstructeurDestructeur.models
{
    internal class Invite : User
    {
        public int InviteNumber { get; set; }

        public Invite(int id ,string name ,int inviteNumber )  : base()
        {
            Random rnd = new Random();
            InviteNumber = rnd.Next(1, 9999);
        }


    }
}
