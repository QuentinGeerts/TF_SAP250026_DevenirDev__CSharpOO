using DemoEncapsulation.Models;

// Internal = uniquement accessible dans le même projet
// Public = accessible de partout
// Protected = uniquement accessible dans la classe de base et ses classes filles (quelque soit l'assembly dans lequel elle se situe)



Etudiant etudiant = new Etudiant();

Console.WriteLine($"{etudiant.nom} {etudiant.prenom}");
