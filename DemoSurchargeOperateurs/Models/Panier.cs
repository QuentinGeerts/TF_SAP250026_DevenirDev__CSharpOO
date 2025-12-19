namespace DemoSurchargeOperateurs.Models;

public class Panier
{
    private List<Fruit> _fruits = new List<Fruit>();

    public void Ajouter(params Fruit[] fruits)
    {
        foreach (var fruit in fruits)
        {
            if (fruit == null) return;
            if (_fruits.Contains(fruit)) return;

            _fruits.Add(fruit);
        }
    }

    public string AfficherListe()
    {
        return string.Join("\n", _fruits);
    }

    //  Surcharge d'opérateurs
    public static Panier operator +(Panier panier1, Panier panier2)
    {
        Panier panierFusionne = new Panier();

        panierFusionne.Ajouter([.. panier1._fruits, .. panier2._fruits]); // Spread operator

        return panierFusionne;
    }

    public static Panier operator + (Panier panier, Fruit fruit)
    {
        panier.Ajouter(fruit);
        return panier;
    }


}
