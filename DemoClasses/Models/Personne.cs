namespace DemoClasses.Models;

internal class Personne
{
    // Champs
    private List<Chat> _chats = new List<Chat>();
    private string _nom;
    private string _prenom;
    private int _age = 29;
    private string _role = "user";

    public DateOnly DateNaissance { get; set; } // Auto-propriété

    // Propriété en lecture seule
    // Mais modifiable qu'à la création de l'objet
    public int MyProperty { get; init; }

    // Pas besoin de vérification => prop
    // Besoin de vérification => propfull


    //public int MyProperty { get; set; } // prop → tab

    private string matricule; // propfull → tab
    public string Matricule
    {
        get { return matricule; }
        set { matricule = value; }
    }

    public string Role
    {
        get => _role;
        private set { _role = value; }
    }


    // Getters et setters (accesseurs et mutateurs)
    //internal int getAge()
    //{
    //    return age;
    //}

    //internal void setAge(int newAge)
    //{
    //    if (newAge < 0) return;
    //    age = newAge;
    //}

    // Propriétés
    internal int Age
    {
        get
        {
            return _age;
        }

        set
        {
            if (value < 0) return;
            _age = value;
        }
    }

    internal string Prenom // Full-propriété
    {
        get
        {
            return _prenom;
        }

        set
        {
            _prenom = value;
        }
    }
    public string Nom { get => _nom; set => _nom = value; }

    public string NomComplet 
    { 
        get => $"{Nom} {Prenom}"; 
    }

    private void UpgradeRole ()
    {
        if (_role == "user")
        {
            Role = "admin"; // Acces car directement dans la classe
        }

}
