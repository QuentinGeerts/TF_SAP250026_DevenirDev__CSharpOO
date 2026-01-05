/*
 * Démonstration 12 - Délégués
 * Un type qui représente une référence à une méthode
 */

using DemoDelegues.Delegates;
using DemoDelegues.Models;

// 1.  Délégué simple

// Créer une variable du type du délégué qui va stocker la référence pour l'exécuter plus tard

AfficherMessageDelegate messageDelegate; // = null

//Console.WriteLine(SystemMessage.AfficherDansConsole); // Affichage de la référence
//Console.WriteLine(SystemMessage.AfficherDansConsole()); // Affichage du retour

// Affectation de la référence
messageDelegate = SystemMessage.AfficherDansConsole;

// Appeler le délégué (invoquer)
messageDelegate("Hello les loulous"); // Raccourcis
messageDelegate.Invoke("Hello les loulous");

messageDelegate = SystemMessage.AfficherEnMajuscule;

if (messageDelegate != null) messageDelegate.Invoke("Hello les loulous");
messageDelegate?.Invoke("Hello les loulous");

Console.Clear();

// 2.  Délégué multicast (chaîne de méthodes)

AfficherMessageDelegate systemeNotification; // = null

// Opérateur pour ajouter des références: +=
// Opérateur pour supprimer des références: -=

systemeNotification = SystemMessage.EnvoyerParEmail;
systemeNotification += SystemMessage.EnvoyerParSMS;
systemeNotification += SystemMessage.EnvoyerParPigeon;

// Déclenchement du délégué
systemeNotification?.Invoke("Hello les loulous");

systemeNotification -= SystemMessage.EnvoyerParSMS;

systemeNotification?.Invoke("Hello les loulous");

Console.Clear();

// Avec la classe NotificationService

NotificationService service = new NotificationService();
//service.Ajouter(SystemMessage.EnvoyerParSMS);
//service.Ajouter(SystemMessage.EnvoyerParPigeon);
//service.Ajouter(SystemMessage.EnvoyerParSMS);

service.Notifier("Bonsoir les enfants.");

//NotificationDelegate secret = service._notification;
//secret("Hello");

//service.Supprimer(SystemMessage.EnvoyerParSMS);

//service.Notifier("Bonsoir les enfants.");

Console.Clear();

// 3.  Délégué comme callback

List<Personne> personnes = [
    new Personne { Nom = "Geerts", Prenom = "Quentin", Age = 15, Sexe = Sexe.Homme },
    new Personne { Nom = "Geerts", Prenom = "Mélanie", Age = 37, Sexe = Sexe.Femme },
    new Personne { Nom = "Morre", Prenom = "Thierry", Age = 55, Sexe = Sexe.Homme },
    new Personne { Nom = "Person", Prenom = "Michael", Age = 40, Sexe = Sexe.Homme },
    new Personne { Nom = "Herssens", Prenom = "Caroline", Age = 40, Sexe = Sexe.Femme },
    new Personne { Nom = "Doe", Prenom = "Jane", Age = 17, Sexe = Sexe.Femme}
];


var men = FilterToolBox.FilterBySexeHomme(personnes);

Console.WriteLine($"Liste des hommes :");

foreach (var p in men)
{
    Console.WriteLine($" - {p.Nom} {p.Prenom}");
}

var geertsFamily = FilterToolBox.FilterByNameGeerts(personnes);

Console.WriteLine($"Liste des Geerts :");

foreach(var p in geertsFamily)
{
    Console.WriteLine($" - {p.Nom} {p.Prenom}");
}

var majeurs = FilterToolBox.Filter(personnes, estMajeur);

bool estMajeur(Personne p)
{
    return p.Age >= 18;
}

Console.WriteLine($"Liste des majeurs :");

foreach (var p in majeurs)
{
    Console.WriteLine($" - {p.Nom} {p.Prenom}");
}

// 4.  Délégué anonyme
var mineurs = FilterToolBox.Filter(personnes, delegate (Personne p) { return p.Age < 18; });

CompareFnDelegate compareFn = delegate (Personne p) 
{ 
    return p.Age == 22; 
};

// 5.  Délégué lambda (fléchée)
var mineurs2 = FilterToolBox.Filter(personnes, (Personne p)  => { 
    // ...
    return p.Age < 18; 
});

var mineurs3 = FilterToolBox.Filter(personnes, (Personne p) => p.Age < 18);

var caroEtMicha = FilterToolBox.Filter(personnes, p => p.Prenom == "Caroline" || p.Prenom == "Michael");

foreach (var p in caroEtMicha)
{
    Console.WriteLine($" - {p.Nom} {p.Prenom}");
}
