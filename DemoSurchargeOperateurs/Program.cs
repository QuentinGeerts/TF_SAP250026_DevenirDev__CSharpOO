using DemoSurchargeOperateurs.Models;

Fruit banane = new Fruit { Nom = "Banane", Poids = 0.12 };
Fruit banane2 = new Fruit { Nom = "Banane", Poids = 0.12 };
Fruit fraise = new Fruit { Nom = "Fraise", Poids = 0.02 };
Fruit fruitDuDragon = new Fruit { Nom = "Fruit du Dragon", Poids = .52 };
Fruit ananas = new Fruit { Nom = "Ananas", Poids = .625 };

Panier panier1 = new Panier();
panier1.Ajouter(banane, fraise, fruitDuDragon, ananas);

Panier panier2 = new Panier();
panier2.Ajouter(banane2, fraise, ananas);

Console.WriteLine($"Panier 1:");
Console.WriteLine($"{panier1.AfficherListe()}");

Console.WriteLine($"Panier 2:");
Console.WriteLine($"{panier2.AfficherListe()}");


Panier panierFusion = panier1 + panier2;

Console.WriteLine($"Panier fusionné:");
Console.WriteLine($"{panierFusion.AfficherListe()}");


panier1 = panier1 + new Fruit { Nom = "Litchi", Poids = .230};
Console.WriteLine($"Panier 1:");
Console.WriteLine($"{panier1.AfficherListe()}");