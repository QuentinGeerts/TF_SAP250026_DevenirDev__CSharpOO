

using DemoTryCatch;
using System.Numerics;

// il est possible de declencher une erreur avec le mot clef throw
// il est possible de capturer les erreurs avec le mot clef try catch
double division(double a, double b)
{
    if (b == 0)
    {
        throw new Exception("Division par zero impossible");
    }

    if (a == 15)
    {
        throw new Exception("Cette valeur n'est pas autoriser");
    }
    return a / b;

}

// L'appel de la fonction doit pouvoir recupérer l'exception
// pour la traiter dans le bloc ou l'on souhaite la traiter
void Calculatrice()
{
    // Appel de la fonction de division qui declenche une exception
    division(10, 0);

}


// L'exception est capturée dans le bloc try catch dans le main
// Il ne peut y avoir qu'un seul bloc try
// mais plusieurs blocs catch pour capturer differentes exceptions
try
{
    Calculatrice();
    throw new MyException("Mon exception à été levé");
}
catch(MyException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Une exception Argument outOfRange a été levée : " + e.Message);
}
catch (ArgumentNullException e)
{
    Console.WriteLine("Une exception ArgumentNullException a été levée : " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Une exception a été levée : " + e.Message);
}


try
{

User user = new User();

user.SePresenter(null);
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}