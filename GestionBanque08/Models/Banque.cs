namespace GestionBanque08.Models;

public class Banque
{
    //  Attributs
    private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();


    //  Propriétés
    public string Nom { get; private set; } = string.Empty;


    public Banque(string nom)
    {
        Nom = nom;
    }

    //  Indexeurs
    public Compte? this[string numero]
    {
        get
        {
            if (numero == null) return null;
            if (!_comptes.ContainsKey(numero)) return null;
            return _comptes[numero];
        }
    }


    //  Méthodes
    public void Ajouter(Compte compte)
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

        foreach (KeyValuePair<string, Compte> kvp in _comptes)
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
        foreach (KeyValuePair<string, Compte> kvp in _comptes)
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
