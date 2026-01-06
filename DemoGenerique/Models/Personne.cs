using DemoGenerique.Interfaces;

namespace DemoGenerique.Models;

public class Personne : BaseEntity, IBaseEntity
{
    public string Nom { get; set; } = string.Empty;
    public string Prenom { get; set; } = string.Empty;

    public Personne()
    {
        
    }

    public Personne(string nom, string prenom)
    {
        Nom = nom;
        Prenom = prenom;
    }
}
