using DemoStatic.models;

// Appel de la méthode statique WriteLine de la classe Console
Console.WriteLine();

//Math.Sqrt(16); // 4


// Instanciation d'un objet Chien pour pouvoir l'utiliser
Chien chien = new Chien();
chien.Nom = "Pluto";
chien.Age = 5;
Chien.Cri();
Animal.Cri();


// Une classe statique n'as pas besoin d'instance pour être utilisée

// affichage simple d'une valeur
Tools.AfficheMenu();

// recuperation d'une valeur
int value = Tools.GetInt();
Console.WriteLine($"Vous avez entré la valeur {value}");

// Une classe non statique peut contenir des méthodes statiques
testStatic.AffichageInformations();


bool again = true;

int nb1 = 0;

string op = "";

int nb2 = 0;

while (again)
{
    nb1 = Tools.GetInt();

    op = Tools.getOperator();

    nb2 = Tools.GetInt();

    switch (op)
    {
        case "+":
            Console.WriteLine(Calculatrice.Addition(nb1, nb2));
            break;
        case "-":
            Console.WriteLine(Calculatrice.Soustraction(nb1, nb2));
            break;
        case "*":
            Console.WriteLine(Calculatrice.Multiplication(nb1, nb2));
            break;
        case "/":
            Console.WriteLine(Calculatrice.Division(nb1, nb2));
            break;
    }
     
    again = Tools.GetAnswer();
}


Console.WriteLine($"Pi: {Calculatrice.PI}");
