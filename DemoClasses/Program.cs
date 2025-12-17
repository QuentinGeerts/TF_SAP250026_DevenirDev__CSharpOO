/*
 * Démonstration 03 - Les classes et propriétés
 */

using DemoClasses.Models;

// Déclaration (réserver) de type Chat
Chat chat1 = new Chat(); // Instancier = créer l'instance de l'objet en mémoire

chat1.Meow();
chat1.Eat();


Personne quentin = new Personne();

// Avec méthodes get et set

//quentin.setAge(-5);
//Console.WriteLine($"quentin: {quentin.getAge()}");
//quentin.setAge(15);
//Console.WriteLine($"quentin: {quentin.getAge()}");

// Avec propriétés

Console.WriteLine($"Quentin: {quentin.Age}");

quentin.Age = -5;

Console.WriteLine($"Quentin: {quentin.Age}");

quentin.Age = 15;

quentin.Nom = "Geerts";
quentin.Prenom = "Quentin";
// quentin.NomComplet = "Quentin Geerts"; // Impossible car lecture seule

Console.WriteLine($"Quentin: {quentin.NomComplet} {quentin.Age}");

Console.WriteLine($"Role: {quentin.Role}");

//quentin.Role = "admin"; // Lecture seule en dehors de la classe
