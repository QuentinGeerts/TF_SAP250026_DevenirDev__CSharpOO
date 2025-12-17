using DemoEncapsulation.Models;
using DemoEncapsulationDependance.Models;

Etudiant etudiant = new Etudiant();

Console.WriteLine($"{etudiant.prenom}");


Professeur professeur = new Professeur();
professeur.Information();