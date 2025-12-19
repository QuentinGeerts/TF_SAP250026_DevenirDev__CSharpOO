/*
 * Démonstration 06 - Héritage / polymorphisme
 */

using DemoHeritagePolymorphisme.Models;
using DemoHeritagePolymorphisme.Models.Aerien;
using DemoHeritagePolymorphisme.Models.Maritime;
using DemoHeritagePolymorphisme.Models.Terrestre;

// 1. Création des objets et accès aux membres hérités

Vehicule vehicule = new Vehicule("Kia", "Ceed");
vehicule.Demarrer();
vehicule.Arreter();

VehiculeAerien va = new VehiculeAerien();
va.Demarrer();
va.Decoller();
va.Atterir();
va.Arreter();

VehiculeMaritime vm = new VehiculeMaritime();
vm.Demarrer();
vm.DemarrerHelice();
vm.ArreterHelice();
vm.Arreter();

VehiculeTerrestre vt = new VehiculeTerrestre();
vt.Demarrer();
vt.Accelerer();
vt.Freiner();
vt.Arreter();

Avion avion = new Avion();
avion.Demarrer();
avion.Decoller();
avion.Atterir();
avion.Arreter();
avion.Envergure = 50;

// Pareil pour bateau, moto et voiture...

//  2. Polymorphisme

// - Polymorphisme d'héritage
//  → Instance d'un enfant stocké dans la variable de type parent
// - Polymorphisme d'ad hoc
//  → Redéfinition de méthodes (changer le comportement initial)
// - Polymorphisme paramétrique
//  → Surcharge de méthodes (créer d'autres méthodes avec la même signature mais paramètres !=)

// a.  Polymorphisme d'héritage

Vehicule v1 = new VehiculeAerien();
Vehicule v2 = new VehiculeMaritime();
Vehicule v3 = new VehiculeTerrestre();
Vehicule v4 = new Avion();
Vehicule v5 = new Bateau();
Vehicule v6 = new Voiture();
Vehicule v7 = new Moto(3, "Yamaha", "Menfou");

Bateau b1 = new Bateau();
Moto m1 = (Moto)v7; // <!> fonctionne uniquement si la variable v7 contient l'instance d'une moto
//Moto m2 = (Moto)v6; // Ne fonctionne pas car une voiture n'est pas une moto


// b.  Polymorphisme d'ad hoc
m1.Demarrer();
b1.Demarrer();
avion.Demarrer();

// c.  Polymorphisme paramétrique

Voiture voiture = new Voiture();
voiture.Demarrer();
voiture.Accelerer(); // Vitesse accélère de 1
voiture.Accelerer(10); // Vitesse accélère de 10


Console.WriteLine($"Vitesse: {voiture.Vitesse}");

Console.WriteLine($"Marque voiture: {voiture.Marque}");

Vehicule vehicule1 = new Vehicule("Kia", "Ceed");

Voiture voiture1 = new Voiture();

