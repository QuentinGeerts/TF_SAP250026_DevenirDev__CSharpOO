using ExerciceCarwash.Models;

Carwash carwash = new Carwash();


Voiture v1 = new("2-EWB-988");
Voiture v2 = new("2-EWB-989");
Voiture v3 = new("2-EWB-990");

carwash.Traiter(v1);
carwash.Traiter(v2);
carwash.Traiter(v3);