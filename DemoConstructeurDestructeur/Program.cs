using DemoConstructeurDestructeur.models;


// a partir du moment ou un constructeur avec parametres est defini
// on ne peut plus utiliser le constructeur par defaut
//User user = new();


// Le constructeur avec le bon nombre et type de parametres est appele
// en fonction des arguments fournis


Visitor visitor = new Visitor(1, "John Doe",1);
Visitor visitor2 = new (1, "John Doe",1);

Invite invite = new Invite(2, "Jane Doe", 1234);




// Demo Ecriture Dans un fichier 
// fournir le chemin complet du fichier
using (StreamWriter writer = new StreamWriter("C:\\Users\\boual\\Desktop\\File.txt"))
{
    // ecriture dans le fichier
    writer.WriteLine("Hello, World!");
}


// Demo Lecture d'un fichier 
// fournir le chemin complet du fichier
using (StreamReader reader = new StreamReader("C:\\Users\\boual\\Desktop\\File.txt"))
{
    // Lecture du contenu du fichier
    string content = reader.ReadToEnd();
    // affichage du contenu lu
    Console.WriteLine(content);
}

Console.WriteLine("Ecriture terminée");
Console.ReadLine();

// utilisation de la classe StreamTools
// lecture de fichier simplifiée
StreamTools.WriteFile("C:\\Users\\boual\\Desktop\\File.txt", "Message à ajouter");

// lecture du fichier
string result = StreamTools.ReadFile("C:\\Users\\boual\\Desktop\\File.txt");


Voiture v = new Voiture();
v.Marque = "Kia";


Voiture v2 = new Voiture()
{
    Marque = "Kia"
};

Voiture v3 = new Voiture("Kia");
Voiture v4 = new Voiture(new Proprietaire { Nom = "Geerts", Prenom = "Quentin" });



VoitureSport vs = new VoitureSport();