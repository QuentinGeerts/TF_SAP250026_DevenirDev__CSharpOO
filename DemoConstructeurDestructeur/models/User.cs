using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConstructeurDestructeur.models
{
    internal class User
    {
        public int Id { get; set; }

        public string Name { get;  set; }

        public int Age { get; set; }

        public double Montant { get; set; }

        public void AfficheInfo(User user)
        {
            if(this.Name != user.Name)
            {
                Console.WriteLine("ce n'est pas la meme personne");
            }

        }


        public User()
        {
            Random rnd = new Random();
            Id = rnd.Next(1, 1000);
        }

        public User(int id,string name) : this()
        {
            Name = name;
        }

        public User(int id , string name , int age) : this(id,name)
        {
            Age = age;
        }

        ~User()
        {
            Console.WriteLine("Appel du desctructeur");
        }

    }
}
