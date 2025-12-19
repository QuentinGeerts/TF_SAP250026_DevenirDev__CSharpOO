namespace GestionBanque.Models;

public class Banque
{
    //  Attributs
    private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();


    //  Propriétés
    public string Nom { get; set; } = string.Empty;


    //  Indexeurs
    public Courant? this[string numero]
    {
        get
        {
            if (numero == null) return null;
            if (!_comptes.ContainsKey(numero)) return null;
            return _comptes[numero];
        }
    }


    //  Méthodes
    public void Ajouter(Courant compte)
    {
        if (compte == null) return;
        if (_comptes.ContainsKey(compte.Numero)) return;
        _comptes.Add(compte.Numero, compte);
        Console.WriteLine($"Le compte '{compte.Numero}' a bien été ajouté.");
    }

    public void Supprimer(string numero)
    {
        if (numero == null) return;
        if(_comptes.Remove(numero))
        {
            Console.WriteLine($"Le compte '{numero}' a bien été supprimé.");
        }
        else
        {
            Console.WriteLine($"Le compte '{numero}' n'a pas été trouvé.");
        }
    }

    public string AfficherComptes ()
    {
        string str = "";

        foreach (KeyValuePair<string, Courant> kvp in _comptes)
        {
            str += $"- Compte n°{kvp.Key}, " +
                $"titulaire: {kvp.Value.Titulaire.Nom} {kvp.Value.Titulaire.Prenom}, " +
                $"solde: {kvp.Value.Solde} euro\n";
        }

        return str;
    }

    public double AvoirDesComptes(Personne titulaire)
    {
        double somme = 0;
        foreach (KeyValuePair<string, Courant> kvp in _comptes)
        {
            if (kvp.Value.Titulaire == titulaire)
            {
                //somme = somme + kvp.Value;
                somme += kvp.Value;
            }
        }
        return somme;
    }

}
