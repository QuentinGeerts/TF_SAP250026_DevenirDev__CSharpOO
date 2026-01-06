
using DemoAbstract.models;

//Chien chien = new Chien();
//chien.Couleur = "Marron";
//chien.Nom = "Rex";
//chien.Age = 5;
//chien.EmmettreSon();
//chien.SeDeplacer();


//Chat chat = new Chat();
//chat.Couleur = "Noir";
//chat.Nom = "Félix";
//chat.Age = 3;
//chat.EmmettreSon();
//chat.SeDeplacer();

Vehicule v1 = new Vehicule();

Voiture voiture = new Voiture();
voiture.Moteur = "V8";
voiture.Modele = "Mustang";
voiture.NumSerie = Guid.NewGuid();
voiture.FaireLePlein();
//voiture.SeDeplacer();

Bateau bateau = new Bateau();
bateau.Moteur = "Diesel";
bateau.Modele = "Titanic";
bateau.NumSerie = Guid.NewGuid();
bateau.FaireLePlein();
bateau.SeDeplacer();