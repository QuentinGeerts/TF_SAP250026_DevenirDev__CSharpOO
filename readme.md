# TF_SAP250026 - Devenir Dev - C# Orienté Objet

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120?logo=csharp)](https://docs.microsoft.com/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-Educational-blue.svg)]()

Ce repository contient l'ensemble des démonstrations et exercices pratiques du cours de programmation orientée objet en C#. Chaque projet illustre des concepts clés de la POO avec des exemples concrets et progressifs.

## 📚 Table des Matières

- [Structure du Projet](#-structure-du-projet)
- [Démonstrations](#-démonstrations)
- [Exercices Pratiques](#-exercices-pratiques)
- [Technologies](#-technologies-utilisées)
- [Installation](#-installation)
- [Contribution](#-contribution)

---

## 📂 Structure du Projet

```
TF_SAP250026_DevenirDev_CSharpOO/
├── 01 - Namespaces/
├── 02 - Encapsulation/
├── 03 - Classes et Propriétés/
├── 04 - Indexeurs/
├── 05 - Surcharge Opérateurs/
├── 06 - Héritage Polymorphisme/
├── 07 - Classes Abstraites/
├── 08 - Classes Statiques/
├── 09 - Interfaces/
├── 10 - Constructeur Destructeur/
├── 11 - Exceptions/
├── 12 - Délégués/
├── 13 - Événements/
├── 14 - Généricité/
├── GestionBanque/ (01-10)
├── ExerciceCarwash/
└── HeroesVsMonsters/
```

---

## 🎓 Démonstrations

### 01 - Namespaces
**Projet:** `DemoNamespaces`

Organisation et structuration du code avec les espaces de noms.

**Concepts abordés:**
- Déclaration et utilisation de namespaces
- Directive `using` pour importer des namespaces
- Alias de namespaces (`using M2 = DemoNamespaces.Models2`)
- Namespaces imbriqués (`.Sub`)
- Résolution des conflits de noms

```csharp
// Alias de namespace
using M2 = DemoNamespaces.Models2;
using M3 = DemoNamespaces.Models3;

// Utilisation
M2.MaClasse3 maClasse3M2 = new M2.MaClasse3();
M3.MaClasse3 maClasse3M3 = new M3.MaClasse3();
```

---

### 02 - Encapsulation
**Projets:** `DemoEncapsulation`, `DemoEncapsulationDependance`

Exploration des modificateurs d'accès et protection des données.

**Concepts abordés:**
- Modificateurs: `public`, `private`, `internal`, `protected`
- Modificateurs combinés: `protected internal`, `private protected`
- Portée selon l'assembly
- Héritage et accessibilité

**Tableau des modificateurs:**

| Modificateur | Classe | Enfant (même assembly) | Enfant (autre assembly) | Autre classe (même assembly) | Autre classe (autre assembly) |
|-------------|---------|----------------------|----------------------|----------------------------|------------------------------|
| `private` | ✅ | ❌ | ❌ | ❌ | ❌ |
| `protected` | ✅ | ✅ | ✅ | ❌ | ❌ |
| `internal` | ✅ | ✅ | ❌ | ✅ | ❌ |
| `protected internal` | ✅ | ✅ | ✅ | ✅ | ❌ |
| `private protected` | ✅ | ✅ | ❌ | ❌ | ❌ |
| `public` | ✅ | ✅ | ✅ | ✅ | ✅ |

---

### 03 - Classes et Propriétés
**Projet:** `DemoClasses`

Manipulation des classes, propriétés et encapsulation des données.

**Concepts abordés:**
- Déclaration et instanciation
- Champs privés vs propriétés publiques
- Auto-propriétés (`prop`)
- Full-propriétés (`propfull`)
- Propriétés calculées (lecture seule)
- Propriétés `init` (C# 9)
- Classes partielles (`partial`)

```csharp
// Auto-propriété
public string Nom { get; set; }

// Propriété avec validation
private int _age;
public int Age
{
    get { return _age; }
    set { if (value >= 0) _age = value; }
}

// Propriété calculée
public string NomComplet => $"{Nom} {Prenom}";

// Propriété init (modifiable uniquement à la création)
public int MyProperty { get; init; }

// Classe partielle (Chat1.cs et Chat2.cs)
public partial class Chat
{
    internal string couleur;
    public void Meow() { /* ... */ }
}
```

---

### 04 - Indexeurs
**Projet:** `DemoIndexeurs`

Accès aux éléments d'une collection via l'opérateur `[]`.

**Concepts abordés:**
- Syntaxe des indexeurs (`this[]`)
- Indexeurs avec différents types (int, string, multiples paramètres)
- Validation dans get/set
- Redéfinition de `ToString()` et `Equals()`

```csharp
// Indexeur simple
internal JeuVideo this[int index]
{
    get
    {
        if (index < 0 || index >= _jeuVideos.Count) 
            throw new IndexOutOfRangeException();
        return _jeuVideos[index];
    }
    set { /* ... */ }
}

// Indexeur avec paramètres multiples
public JeuVideo? this[string titre, string studio, int annee]
{
    get
    {
        JeuVideo jeuARechercher = new JeuVideo { Titre = titre, ... };
        return _jeuVideos.FirstOrDefault(j => j.Equals(jeuARechercher));
    }
}

// Utilisation
JeuVideo jv = ludotheque[0];
JeuVideo? mh = ludotheque["Monster Hunter", "Capcom", 2004];
```

---

### 05 - Surcharge d'Opérateurs
**Projet:** `DemoSurchargeOperateurs`

Personnalisation du comportement des opérateurs pour types custom.

**Concepts abordés:**
- Surcharge de l'opérateur `+`
- Opérateurs avec différentes signatures
- Spread operator (`..`)
- Paramètres variables (`params`)

```csharp
// Fusion de deux paniers
public static Panier operator +(Panier panier1, Panier panier2)
{
    Panier panierFusionne = new Panier();
    panierFusionne.Ajouter([.. panier1._fruits, .. panier2._fruits]);
    return panierFusionne;
}

// Ajout d'un fruit à un panier
public static Panier operator +(Panier panier, Fruit fruit)
{
    panier.Ajouter(fruit);
    return panier;
}

// Utilisation
Panier p3 = p1 + p2;  // Fusion
p1 = p1 + new Fruit { Nom = "Litchi" };  // Ajout
```

---

### 06 - Héritage et Polymorphisme
**Projet:** `DemoHeritagePolymorphisme`

Concepts fondamentaux de l'héritage et du polymorphisme.

**Concepts abordés:**
- Héritage simple (`class Enfant : Parent`)
- Mot-clé `base` pour accéder au parent
- Chaînage de constructeurs
- **Polymorphisme d'héritage** (upcasting)
- **Polymorphisme d'ad hoc** (redéfinition avec `virtual`/`override`)
- **Polymorphisme paramétrique** (surcharge de méthodes)
- Casting explicite (downcasting)

**Hiérarchie:**
```
Vehicule (base)
├── VehiculeAerien
│   └── Avion
├── VehiculeMaritime
│   └── Bateau
└── VehiculeTerrestre
    ├── Voiture
    └── Moto
```

```csharp
// Classe de base
public class Vehicule
{
    public virtual void Demarrer()
    {
        Console.WriteLine("Le véhicule démarre...");
    }
}

// Redéfinition
public class Bateau : VehiculeMaritime
{
    public override void Demarrer()
    {
        base.Demarrer();  // Appel du parent
        Console.WriteLine("PS: c'est un bateau");
    }
}

// Polymorphisme d'héritage (upcasting)
Vehicule v1 = new Moto();  // OK
v1.Demarrer();  // Appelle Moto.Demarrer()

// Casting explicite (downcasting)
Moto m1 = (Moto)v1;  // OK si v1 contient bien une Moto

// Surcharge de méthodes
public void Accelerer() => Vitesse++;
public void Accelerer(int vitesse) => Vitesse += vitesse;
```

---

### 07 - Classes Abstraites
**Projet:** `DemoAbstract`

Utilisation des classes abstraites pour définir des contrats partiels.

**Concepts abordés:**
- Mot-clé `abstract` sur classes et méthodes
- Méthodes abstraites (pas d'implémentation)
- Méthodes virtuelles (implémentation par défaut)
- Impossibilité d'instancier une classe abstraite
- Obligation d'implémenter les méthodes abstraites dans les enfants

```csharp
// Classe abstraite
internal abstract class Animal
{
    public int Age { get; set; }
    public string Nom { get; set; }

    // Méthode abstraite (pas d'implémentation)
    public abstract void EmmettreSon();

    // Méthode virtuelle (implémentation par défaut)
    public virtual void SeDeplacer()
    {
        Console.WriteLine("L'animal se déplace.");
    }
}

// Implémentation obligatoire
internal class Chien : Animal
{
    public override void EmmettreSon()
    {
        Console.WriteLine("Le chien aboie !");
    }

    public override void SeDeplacer()
    {
        Console.WriteLine("Le chien se deplace");
    }
}

// Impossible
// Animal a = new Animal(); // ❌ Erreur de compilation
```

---

### 08 - Classes Statiques
**Projet:** `DemoStatic`

Membres et classes statiques pour fonctionnalités utilitaires.

**Concepts abordés:**
- Classe statique (`static class`)
- Membres statiques dans classes non-statiques
- Constantes (`const`)
- Accès sans instanciation
- Méthodes utilitaires

```csharp
// Classe statique (utilitaire)
internal static class Tools
{
    public static int GetInt()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) { }
        return result;
    }

    public static void AfficheMenu()
    {
        Console.WriteLine("1 - Accueil");
        Console.WriteLine("2 - Liste");
    }
}

// Classe avec membres statiques
internal static class Calculatrice
{
    internal const double PI = 3.141596;  // Constante

    public static int Addition(int a, int b) => a + b;
    public static int Division(int a, int b) => b == 0 ? 0 : a / b;
}

// Utilisation (sans instanciation)
int nombre = Tools.GetInt();
double resultat = Calculatrice.Addition(5, 3);
Console.WriteLine(Calculatrice.PI);
```

---

### 09 - Interfaces
**Projet:** `DemoInterfaces`

Définition de contrats via les interfaces.

**Concepts abordés:**
- Déclaration d'interfaces (`interface`)
- Implémentation multiple d'interfaces
- Héritage d'interfaces
- Implémentation par défaut (C# 8)
- Polymorphisme via interfaces
- Pattern matching avec `is`

```csharp
// Interfaces
internal interface IUser
{
    void Login();
    void Logout();
}

internal interface IAdmin : IUser
{
    void AjouterUtilisateur(string username);
    void SupprimerUtilisateur(string username);
}

internal interface ILogger
{
    void Log(string message)  // Implémentation par défaut
    {
        Console.WriteLine($"message: {message}");
    }
    void LogError(string message);
}

// Implémentation multiple
internal class Admin : Person, IAdmin, ILogger
{
    public void Login() { /* ... */ }
    public void Logout() { /* ... */ }
    public void AjouterUtilisateur(string username) { /* ... */ }
    public void LogError(string message) { /* ... */ }
}

// Polymorphisme et pattern matching
List<IUser> personnes = new List<IUser> { user, admin };
foreach (var personne in personnes)
{
    if (personne is IAdmin admin)
        admin.AjouterUtilisateur("newuser");
    
    personne.Login();
}
```

---

### 10 - Constructeur/Destructeur
**Projet:** `DemoConstructeurDestructeur`

Gestion de la construction et destruction d'objets.

**Concepts abordés:**
- Constructeurs par défaut
- Constructeurs paramétrés
- Chaînage de constructeurs (`: this()`)
- Appel du constructeur parent (`: base()`)
- Destructeur (`~ClassName()`)
- Pattern `IDisposable` et `using`
- Initialisation d'objets

```csharp
internal class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructeur par défaut
    public User()
    {
        Random rnd = new Random();
        Id = rnd.Next(1, 1000);
    }

    // Chaînage de constructeurs
    public User(int id, string name) : this()
    {
        Name = name;
    }

    public User(int id, string name, int age) : this(id, name)
    {
        Age = age;
    }

    // Destructeur (rarement utilisé)
    ~User()
    {
        Console.WriteLine("Appel du destructeur");
    }
}

// Héritage et constructeurs
internal class Voiture
{
    public string Marque { get; set; }
    
    public Voiture() { }
    public Voiture(string marque) : this() { Marque = marque; }
}

internal class VoitureSport : Voiture
{
    public VoitureSport() { }
    public VoitureSport(string marque) : base(marque) { }
}

// Pattern IDisposable
internal class AppelDb : IDisposable
{
    public void Dispose() { /* Libération des ressources */ }
}

using (AppelDb db = new AppelDb())
{
    // Dispose() appelé automatiquement à la fin du bloc
}

// Initialisation d'objets
Voiture v2 = new Voiture { Marque = "Kia" };
Voiture v3 = new Voiture("Kia");
```

---

### 11 - Exceptions
**Projets:** `DemoExceptions`, `DemoTryCatch`

Gestion des erreurs et exceptions personnalisées.

**Concepts abordés:**
- Bloc `try-catch-finally`
- Lancement d'exceptions (`throw`)
- Exceptions standard (.NET)
- Création d'exceptions personnalisées
- Gestion de plusieurs types d'exceptions
- Pattern `TryParse`

```csharp
// Exception personnalisée
internal class QuentinException : ArgumentException
{
    public string Value { get; set; }
    
    public QuentinException(string? message = "") : base(message) { }
    
    public QuentinException(string? message, string? paramName) 
        : base(message, paramName) { }
}

// Gestion d'exceptions
public static bool TryParse(string value, out int convertedValue)
{
    if (value == null) throw new ArgumentNullException();
    if (value == "Quentin") 
        throw new QuentinException("La valeur entrée est 'Quentin'", "value");

    try
    {
        convertedValue = int.Parse(value);
        return true;
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("La valeur ne peut pas être nulle.");
        convertedValue = 0;
        return false;
    }
    catch (FormatException)
    {
        Console.WriteLine("Format invalide.");
        convertedValue = 0;
        return false;
    }
    catch (OverflowException)
    {
        Console.WriteLine("Valeur trop grande.");
        convertedValue = 0;
        return false;
    }
    finally
    {
        Console.WriteLine("Conversion terminée.");
    }
}

// Utilisation
int result;
while (!Conversion.TryParse(Console.ReadLine(), out result))
{
    Console.WriteLine("Erreur, réessayez:");
}
```

---

### 12 - Délégués
**Projet:** `DemoDelegues`

Références à des méthodes et callbacks.

**Concepts abordés:**
- Déclaration de délégués (`delegate`)
- Délégués simples
- Délégués multicast (chaîne de méthodes)
- Opérateurs `+=` et `-=`
- Délégués anonymes
- Expressions lambda
- Délégués génériques: `Action<T>`, `Func<T>`, `Predicate<T>`

```csharp
// Déclaration de délégué
public delegate void AfficherMessageDelegate(string message);

// Utilisation simple
AfficherMessageDelegate messageDelegate;
messageDelegate = SystemMessage.AfficherDansConsole;
messageDelegate.Invoke("Hello");  // ou messageDelegate("Hello")

// Délégué multicast
AfficherMessageDelegate systemeNotification = SystemMessage.EnvoyerParEmail;
systemeNotification += SystemMessage.EnvoyerParSMS;
systemeNotification += SystemMessage.EnvoyerParPigeon;
systemeNotification("Message");  // Appelle les 3 méthodes

// Délégué comme callback
public delegate bool CompareFnDelegate(Personne p);

public static List<Personne> Filter(List<Personne> personnes, CompareFnDelegate compareFn)
{
    List<Personne> result = new();
    foreach (var p in personnes)
        if (compareFn(p)) result.Add(p);
    return result;
}

// Utilisation avec méthode nommée
var majeurs = FilterToolBox.Filter(personnes, EstMajeur);
bool EstMajeur(Personne p) => p.Age >= 18;

// Délégué anonyme
var mineurs = Filter(personnes, delegate(Personne p) { return p.Age < 18; });

// Expression lambda (recommandé)
var mineurs2 = Filter(personnes, (Personne p) => { return p.Age < 18; });
var mineurs3 = Filter(personnes, p => p.Age < 18);  // Syntaxe courte

// Délégués génériques
Action<string> action = SystemMessage.EnvoyerParEmail;  // void
Func<float, float, double> func = OperationsMath.Addition;  // avec retour
Predicate<Personne> predicate = p => p.Age >= 18;  // retourne bool
```

---

### 13 - Événements
**Projet:** `DemoEvents`

Programmation événementielle et pattern Observateur.

**Concepts abordés:**
- Mot-clé `event`
- Délégués pour événements
- Abonnement (`+=`) et désabonnement (`-=`)
- Protection des événements
- `Action<T>` et `Func<T>` pour événements
- Méthode protégée `On...()` pour déclencher l'événement

```csharp
// Définition du délégué et de l'événement
public delegate void ThresholdReached(int counter, int threshold);

public class Counter
{
    protected int _counter;
    protected int _threshold;

    // Événement basé sur le délégué
    public event ThresholdReached ThresholdReached;
    
    // Ou avec Action<T>
    public event Action<int, int> ThresholdReachedAction;

    public Counter(int threshold)
    {
        _threshold = threshold;
    }

    public virtual void Increment(int value)
    {
        _counter += value;
        if (_counter >= _threshold)
            OnThresholdReached();
    }
    
    protected void OnThresholdReached()
    {
        // Vérification null et invocation
        ThresholdReached?.Invoke(_counter, _threshold);
    }
}

// Classe qui réagit à l'événement
public class Displayer
{
    public void DisplayCounter(int counter, int threshold)
    {
        Console.WriteLine($"Le compteur '{counter}' a atteint '{threshold}'");
    }
}

// Utilisation
Displayer displayer = new Displayer();
Counter counter = new Counter(10);

// Abonnement
counter.ThresholdReached += displayer.DisplayCounter;

counter.Increment(5);
counter.Increment(5);  // Déclenche l'événement

// Désabonnement
counter.ThresholdReached -= displayer.DisplayCounter;

// Impossible depuis l'extérieur (protection)
// counter.ThresholdReached.Invoke(12, 10);  // ❌ Erreur
```

---

### 14 - Généricité
**Projet:** `DemoGenerique`

Types génériques pour code réutilisable et type-safe.

**Concepts abordés:**
- Classes génériques (`<T>`)
- Méthodes génériques
- Contraintes avec `where`
  - `where T : struct` (type valeur)
  - `where T : class` (type référence)
  - `where T : new()` (constructeur sans paramètre)
  - `where T : NomClasse` (héritage)
  - `where T : IInterface` (implémentation d'interface)
- Contraintes multiples
- Inférence de type

```csharp
// Classe générique avec contraintes multiples
internal class ListGeneric<T> where T : BaseEntity, IBaseEntity, new()
{
    private List<T> items = new();

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= items.Count) 
                throw new IndexOutOfRangeException();
            return items[index];
        }
    }

    public void Add(T item)
    {
        if (item == null) throw new ArgumentNullException();
        if (items.Contains(item)) throw new ArgumentException();
        items.Add(item);
    }

    // Méthode générique avec contrainte
    public List<TEnfant> Filter<TEnfant>() where TEnfant : T
    {
        List<TEnfant> enfants = new();
        foreach (var item in items)
        {
            if (item is TEnfant)
                enfants.Add((TEnfant)item);
        }
        return enfants;
    }
}

// Utilisation
ListGeneric<Personne> personnes2 = new();
personnes2.Add(new Personne());

ListGeneric<Animal> animaux = new();
animaux.Add(new Chat());
animaux.Add(new Chien());

// Filtrage par type
List<Chat> chats = animaux.Filter<Chat>();
List<Chien> chiens = animaux.Filter<Chien>();

// Interface générique
internal interface IConvertisseur<TEntree, TSortie>
{
    TSortie Convertir(TEntree valeur);
}
```

---

## 🏋️ Exercices Pratiques

### 🏦 Série GestionBanque

#### GestionBanque01 - Fondations
**Objectif:** Créer les classes de base pour la gestion bancaire.

**Classes:**
- `Personne`: Nom, Prénom, DateNaissance
- `Courant`: Numéro, Solde (lecture seule), LigneDeCredit, Titulaire

**Fonctionnalités:**
```csharp
Courant c1 = new Courant
{
    Numero = "00001",
    Titulaire = p1,
    LigneDeCredit = 0
};

c1.Depot(500);   // Ajoute 500 au solde
c1.Retrait(200); // Retire 200 (avec validation ligne de crédit)
```

---

#### GestionBanque02 - Gestion de Banque
**Nouveautés:**
- Classe `Banque` avec `Dictionary<string, Courant>`
- Indexeur pour accès par numéro
- Méthodes Ajouter/Supprimer

```csharp
Banque b = new Banque { Nom = "TechnoBank" };
b.Ajouter(c1);
b.Ajouter(c2);

Courant? compte = b["00001"];  // Indexeur
Console.WriteLine(b.AfficherComptes());
```

---

#### GestionBanque03 - Surcharge d'Opérateurs
**Nouveautés:**
- Surcharge de `operator +` pour calculer l'avoir
- Méthode `AvoirDesComptes()`

```csharp
public static double operator +(double somme, Courant courant)
{
    return courant.Solde >= 0 ? courant.Solde + somme : 0;
}

// Utilisation
double avoir = b.AvoirDesComptes(p1);
```

---

#### GestionBanque04 - Héritage
**Nouveautés:**
- Classe abstraite `Compte` (base commune)
- `Courant` et `Epargne` héritent de `Compte`
- Méthode abstraite `CalculInteret()`

```csharp
public abstract class Compte
{
    protected abstract double CalculInteret();
    public void AppliquerInteret() => Solde += CalculInteret();
}

public class Epargne : Compte
{
    public DateTime DateDernierRetrait { get; private set; }
    protected override double CalculInteret() => Solde * 0.045;
}
```

---

#### GestionBanque05-06 - Polymorphisme
**Nouveautés:**
- `Banque` gère maintenant `Compte` (pas seulement `Courant`)
- Polymorphisme pour calculer l'avoir total

```csharp
// Polymorphisme d'héritage
Banque b = new Banque { Nom = "TechnoBank" };
b.Ajouter(new Courant { /* ... */ });
b.Ajouter(new Epargne { /* ... */ });

double avoir = b.AvoirDesComptes(p1);  // Marche pour tous les types
```

---

#### GestionBanque07 - Interfaces
**Nouveautés:**
- Interface `ICustomer` (opérations client)
- Interface `IBanker` (opérations banque)
- `Compte` implémente `IBanker`
- Constructeurs obligatoires

```csharp
internal interface ICustomer
{
    double Solde { get; }
    void Retrait(double montant);
    void Depot(double montant);
}

internal interface IBanker : ICustomer
{
    void AppliquerInteret();
    Personne Titulaire { get; }
    string Numero { get; }
}

public abstract class Compte : IBanker
{
    public Compte(string numero, Personne titulaire)
    {
        Numero = numero;
        Titulaire = titulaire;
    }
}

// Utilisation
Courant c1 = new Courant("BE4201", p1, 1000);
```

---

#### GestionBanque08 - Exceptions
**Nouveautés:**
- Exception personnalisée `SoldeInsuffisantException`
- Remplacement des `return` par `throw`
- Gestion des erreurs dans le `Program`

```csharp
internal class SoldeInsuffisantException : Exception
{
    public string Message { get; private set; }
    public string Origin { get; private set; }

    public SoldeInsuffisantException(string message, string origin)
    {
        Message = message;
        Origin = origin;
    }
}

protected void Retrait(double montant, double ligneDeCredit)
{
    if (montant <= 0) 
        throw new ArgumentNullException("Le montant est invalide");
    if (Solde - montant < -ligneDeCredit) 
        throw new SoldeInsuffisantException("Solde insuffisant", "Compte");
    
    Solde -= montant;
}

// Utilisation
try
{
    c1.Retrait(600);
}
catch (SoldeInsuffisantException ex)
{
    Console.WriteLine(ex.Message);
}
```

---

#### GestionBanque09 - Événements
**Nouveautés:**
- Événement `PassageEnNegatifEvent`
- Notification automatique lors du passage en négatif
- Abonnement de la banque à l'événement

```csharp
public delegate void PassageEnNegatifDelegate(Compte compte);

public abstract class Compte : IBanker
{
    public event PassageEnNegatifDelegate PassageEnNegatifEvent;

    protected virtual void EnPassageEnNegatif()
    {
        PassageEnNegatifEvent?.Invoke(this);
    }
}

public class Courant : Compte
{
    public override void Retrait(double montant)
    {
        double soldeAvantRetrait = Solde;
        base.Retrait(montant, LigneDeCredit);
        
        if (soldeAvantRetrait >= 0 && Solde < 0)
            EnPassageEnNegatif();
    }
}

// Dans Banque
public void Ajouter(Compte compte)
{
    _comptes.Add(compte.Numero, compte);
    compte.PassageEnNegatifEvent += PassageEnNegatifAction;
}

private void PassageEnNegatifAction(Compte c)
{
    Console.WriteLine($"Le compte {c.Numero} vient de passer en négatif");
}
```

---

#### GestionBanque10 - Délégués Génériques
**Nouveautés:**
- Remplacement du délégué custom par `Action<Compte>`
- Utilisation de délégués génériques .NET

```csharp
// Avant
public delegate void PassageEnNegatifDelegate(Compte compte);
public event PassageEnNegatifDelegate PassageEnNegatifEvent;

// Après
public event Action<Compte> PassageEnNegatifEvent;
```

---

### 🚗 ExerciceCarwash

**Objectif:** Système de lavage de voitures utilisant les délégués.

**Versions:**
- **V1:** Délégués classiques avec méthodes nommées
- **V2:** Délégués anonymes et expressions lambda

```csharp
// Version 1 - Méthodes nommées
public class Carwash
{
    private CarwashDelegate traitements = null;

    public Carwash()
    {
        traitements += Preparer;
        traitements += Laver;
        traitements += Secher;
        traitements += Finaliser;
    }

    public void Traiter(Voiture v)
    {
        traitements?.Invoke(v);
    }
}

// Version 2 - Lambda
public Carwash()
{
    traitements += delegate(Voiture v) 
        { Console.WriteLine($"je prépare la voiture : {v.Plaque}"); };
    traitements += v => Console.WriteLine($"je lave la voiture : {v.Plaque}");
    traitements += v => Console.WriteLine($"je sèche la voiture : {v.Plaque}");
    traitements += v => Console.WriteLine($"je finalise la voiture : {v.Plaque}");
}
```

---

### ⚔️ HeroesVsMonsters

**Objectif:** Jeu RPG complet démontrant tous les concepts POO.

**Concepts utilisés:**
- Héritage (Personnage → Hero/Monstre)
- Classes abstraites
- Interfaces (`IOr`, `ICuir`)
- Événements (mort des personnages)
- Polymorphisme
- Génériques
- Exceptions

**Structure:**
```
Models/
├── Personnages/
│   ├── Personnage.cs (classe abstraite de base)
│   ├── Heros/
│   │   ├── Hero.cs (classe abstraite)
│   │   ├── Humain.cs
│   │   └── Nain.cs
│   └── Monstres/
│       ├── Monstre.cs (classe de base)
│       ├── Loup.cs (ICuir)
│       ├── Orque.cs (IOr)
│       └── Dragonnet.cs (IOr, ICuir)
├── Jeu/
│   ├── Foret.cs (gestion du jeu)
│   └── InterfaceGraphique.cs
└── Utils/
    ├── De.cs
    ├── GenerateurNom.cs
    └── Typing.cs
```

**Fonctionnalités clés:**

```csharp
// Événement de mort
public abstract class Personnage
{
    public event Action<Personnage> Meurt;
    
    public int PointsVie
    {
        get => _pointsVie;
        private set
        {
            _pointsVie = value;
            if (_pointsVie <= 0) Meurt?.Invoke(this);
        }
    }
}

// Interfaces pour le loot
public interface IOr { int Or { get; } }
public interface ICuir { int Cuir { get; } }

public abstract class Hero : Personnage, ICuir, IOr
{
    public void Loot(Personnage p)
    {
        if (p is IOr cibleOr)
            Or += cibleOr.Or;
        if (p is ICuir cibleCuir)
            Cuir += cibleCuir.Cuir;
    }
}

// Pattern matching et polymorphisme
Monstre monstre = Random.Shared.Next(3) switch
{
    0 => new Loup(),
    1 => new Orque(),
    _ => new Dragonnet()
};
```

---

## 🛠️ Technologies Utilisées

- **.NET 10.0** - Framework de développement
- **C# 12** - Langage de programmation
- **Visual Studio 2025** - IDE
- **Git** - Contrôle de version

### Fonctionnalités C# Utilisées

| Fonctionnalité | Version C# | Exemples |
|---------------|-----------|----------|
| Records | C# 9 | `public record Person(string Name);` |
| Init-only setters | C# 9 | `public int Id { get; init; }` |
| Pattern matching | C# 7-10 | `if (obj is Admin admin)` |
| Expression-bodied members | C# 6-7 | `public int Total => x + y;` |
| Null-conditional operator | C# 6 | `event?.Invoke()` |
| String interpolation | C# 6 | `$"Hello {name}"` |
| Collection expressions | C# 12 | `List<int> nums = [1, 2, 3];` |

---

## 📥 Installation

### Prérequis
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Un IDE : [Visual Studio 2025](https://visualstudio.microsoft.com/) (recommandé) ou [VS Code](https://code.visualstudio.com/)

### Cloner le Projet
```bash
git clone https://github.com/votre-username/TF_SAP250026_DevenirDev_CSharpOO.git
cd TF_SAP250026_DevenirDev_CSharpOO
```

### Ouvrir la Solution
```bash
# Avec Visual Studio
start TF_SAP250026_DevenirDev__CSharpOO.slnx

# Avec VS Code
code .

# Avec CLI
dotnet build
```

### Exécuter un Projet
```bash
# Exemple: lancer GestionBanque09
cd GestionBanque09
dotnet run

# Ou avec Projet spécifique
dotnet run --project HeroesVsMonsters/HeroesVsMonsters.csproj
```

---

## 📖 Guide d'Apprentissage

### Progression Recommandée

#### 🟢 Niveau Débutant (Semaine 1-2)
1. ✅ Namespaces
2. ✅ Encapsulation
3. ✅ Classes et Propriétés
4. ✅ Constructeur/Destructeur
5. ✅ GestionBanque01-02

#### 🟡 Niveau Intermédiaire (Semaine 3-4)
6. ✅ Indexeurs
7. ✅ Surcharge d'Opérateurs
8. ✅ Héritage et Polymorphisme
9. ✅ Classes Abstraites
10. ✅ Classes Statiques
11. ✅ GestionBanque03-05

#### 🔴 Niveau Avancé (Semaine 5-6)
12. ✅ Interfaces
13. ✅ Exceptions
14. ✅ Délégués
15. ✅ Événements
16. ✅ Généricité
17. ✅ GestionBanque06-10
18. ✅ ExerciceCarwash
19. ✅ HeroesVsMonsters

---

## 🎯 Objectifs Pédagogiques

À la fin de ce cours, vous serez capable de:

- ✅ Structurer votre code avec des **namespaces**
- ✅ Protéger vos données avec l'**encapsulation**
- ✅ Créer des hiérarchies de classes avec l'**héritage**
- ✅ Utiliser le **polymorphisme** pour écrire du code flexible
- ✅ Définir des contrats avec les **interfaces**
- ✅ Créer des types réutilisables avec les **génériques**
- ✅ Gérer les erreurs avec les **exceptions**
- ✅ Implémenter des callbacks avec les **délégués**
- ✅ Créer des systèmes réactifs avec les **événements**
- ✅ Appliquer les principes **SOLID** dans vos designs

---

## 📚 Ressources Complémentaires

### Documentation Officielle
- [Documentation C#](https://docs.microsoft.com/fr-fr/dotnet/csharp/)
- [Documentation .NET](https://docs.microsoft.com/fr-fr/dotnet/)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)

---

## 📝 Licence

Ce projet est sous licence **Educational** - voir le fichier [LICENSE](LICENSE) pour plus de détails.

---

## 👨‍🏫 Formateur

**Quentin Geerts**  
Formation: TF_SAP250026 - Devenir Dev

---

<div align="center">

**⭐ Si ce cours vous a été utile, n'hésitez pas à laisser une étoile! ⭐**

Made with ❤️ for learning C# OOP

</div>
