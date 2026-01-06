using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInterfaces.models
{
    internal abstract class Person
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public abstract void Login();
        public abstract void Logout();
    }
}
