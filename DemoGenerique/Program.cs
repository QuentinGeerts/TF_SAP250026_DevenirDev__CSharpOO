
using DemoGenerique.Models;
using DemoGenerique.Models.Animals;

ArrayListPersonne personnes = new ArrayListPersonne();
personnes.Add(new Personne());
// personnes.Add(new Animal());


ListGeneric<Personne> personnes2 = new ListGeneric<Personne>();
personnes2.Add(new Personne());


ListGeneric<Animal> animaux = new ListGeneric<Animal>();
animaux.Add(new Chat());
animaux.Add(new Chien());
animaux.Add(new Chien());

List<Chat> chats = animaux.Filter<Chat>();
List<Chien> chiens = animaux.Filter<Chien>();

//List<Animal> chats2 = animaux.Filter(typeof(Chat));

ListGeneric<Vehicule> vehicules = new ListGeneric<Vehicule>();

//ListGeneric<Coordonnee> coordonnees = new ListGeneric<Coordonnee>();
