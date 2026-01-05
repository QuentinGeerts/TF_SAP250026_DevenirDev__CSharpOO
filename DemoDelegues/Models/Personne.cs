namespace DemoDelegues.Models;

public enum Sexe { Homme, Femme }

public class Personne
{
    public string Nom { get; set; } = string.Empty;
    public string Prenom { get; set; } = string.Empty;
    public Sexe Sexe { get; set; }
    public int Age { get; set; }
}
