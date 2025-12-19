# TF_SAP250026 - Devenir Dev - C# Orienté Objet

Ce repository contient l'ensemble des démonstrations et exercices pratiques du cours de programmation orientée objet en C#.

## 📋 Structure du Projet

### 01 - Namespaces
**Projet:** `DemoNamespaces`

Introduction aux espaces de noms (namespaces) en C#.

**Concepts abordés:**
- Organisation du code avec les namespaces
- Utilisation de `using` pour importer des namespaces
- Alias de namespaces (`using M2 = DemoNamespaces.Models2`)
- Namespaces imbriqués (`.Sub`)
- Résolution des conflits de noms entre classes

**Fichiers clés:**
- `Models/MaClasse.cs` - Démonstration de plusieurs classes dans différents namespaces
- `Models/Sub/MaClasse5.cs` - Namespace imbriqué

---

### 02 - Encapsulation
**Projets:** 
- `DemoEncapsulation`
- `DemoEncapsulationDependance`

Exploration des modificateurs d'accès et de l'encapsulation.

**Concepts abordés:**
- Modificateurs d'accès: `public`, `private`, `internal`, `protected`, `protected internal`, `private protected`
- Portée des membres selon l'assembly
- Héritage et accessibilité des membres
- Relations entre projets (dépendances)

**Fichiers clés:**
- `Models/Personne.cs` - Classe de base avec différents modificateurs
- `Models/Etudiant.cs` - Héritage et accès aux membres
- `DemoEncapsulationDependance/Models/Professeur.cs` - Accès depuis un autre assembly

---

### 03 - Classes et Propriétés
**Projet:** `DemoClasses`

Introduction aux classes, propriétés et encapsulation des données.

**Concepts abordés:**
- Déclaration et instanciation de classes
- Champs (fields) privés
- Propriétés (properties) avec get/set
- Auto-propriétés (`prop`)
- Full-propriétés (`propfull`)
- Propriétés en lecture seule
- Propriétés `init` (modifiable uniquement à la création)
- Propriétés calculées (lecture seule)
- Classes partielles (`partial class`)

**Fichiers clés:**
- `Models/Chat1.cs` et `Models/Chat2.cs` - Démonstration de classe partielle
- `Models/Personne.cs` - Propriétés complètes avec validation

**Exemples de code:**
```csharp
// Auto-propriété
public string Nom { get; set; }

// Propriété avec validation
public int Age
{
    get { return _age; }
    set { if (value < 0) return; _age = value; }
}

// Propriété calculée
public string NomComplet { get => $"{Nom} {Prenom}"; }

// Propriété init
public int MyProperty { get; init; }
```

---

### 04 - Indexeurs
**Projet:** `DemoIndexeurs`

Utilisation des indexeurs pour accéder aux éléments d'une collection.

**Concepts abordés:**
- Syntaxe des indexeurs (`this[]`)
- Indexeurs avec différents types de paramètres (int, string, multiples)
- Validation dans les indexeurs
- Redéfinition de `ToString()`
- Redéfinition de `Equals()`

**Fichiers clés:**
- `Models/JeuVideo.cs` - Modèle avec `Equals()` personnalisé
- `Models/Ludotheque.cs` - Collection avec indexeurs

**Exemples de code:**
```csharp
// Indexeur simple
internal JeuVideo this[int index]
{
    get { /* ... */ }
    set { /* ... */ }
}

// Indexeur avec paramètres multiples
public JeuVideo? this[string titre, string studio, int annee]
{
    get { /* ... */ }
}
```

---

### 05 - Surcharge d'Opérateurs
**Projet:** `DemoSurchargeOperateurs`

Surcharge des opérateurs pour des types personnalisés.

**Concepts abordés:**
- Surcharge de l'opérateur `+`
- Opérateurs avec différentes signatures
- Spread operator (`..`)
- Méthode `params` pour paramètres variables

**Fichiers clés:**
- `Models/Panier.cs` - Surcharge d'opérateurs pour fusion de paniers
- `Models/Fruit.cs` - Modèle simple

**Exemples de code:**
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
```

---

### 06 - Héritage et Polymorphisme
**Projet:** `DemoHeritagePolymorphisme`

Concepts avancés d'héritage et de polymorphisme.

**Concepts abordés:**
- Héritage de classes (`class Enfant : Parent`)
- Mot-clé `base` pour accéder au parent
- Constructeurs et chaînage de constructeurs
- Polymorphisme d'héritage (upcasting)
- Polymorphisme d'ad hoc (redéfinition avec `override`)
- Polymorphisme paramétrique (surcharge de méthodes)
- Mot-clé `virtual` pour méthodes redéfinissables
- Casting explicite (downcasting)

**Structure:**
```
Models/
├── Vehicule.cs (classe de base)
├── Aerien/
│   ├── VehiculeAerien.cs
│   └── Avion.cs
├── Maritime/
│   ├── VehiculeMaritime.cs
│   └── Bateau.cs
└── Terrestre/
    ├── VehiculeTerrestre.cs
    ├── Voiture.cs
    └── Moto.cs
```

**Exemples de code:**
```csharp
// Classe de base avec méthode virtuelle
public virtual void Demarrer()
{
    Console.WriteLine($"Le véhicule démarre...");
}

// Redéfinition dans l'enfant
public override void Demarrer()
{
    base.Demarrer(); // Appel du parent
    Console.WriteLine($"PS: c'est un bateau");
}

// Polymorphisme d'héritage
Vehicule v1 = new Moto(); // OK
Moto m1 = (Moto)v1;       // Casting explicite

// Surcharge de méthodes
public void Accelerer() { Vitesse++; }
public void Accelerer(int vitesse) { Vitesse += vitesse; }
```

---

## 🏦 Exercices Pratiques - Gestion Banque

### GestionBanque01
**Objectif:** Créer un système basique de gestion de comptes bancaires.

**Fonctionnalités:**
- Classe `Personne` avec nom, prénom et date de naissance
- Classe `Courant` avec numéro, solde, ligne de crédit et titulaire
- Méthodes `Depot()` et `Retrait()` avec validation
- Protection du solde (lecture seule depuis l'extérieur)

---

### GestionBanque02
**Objectif:** Ajouter une classe Banque pour gérer plusieurs comptes.

**Nouvelles fonctionnalités:**
- Classe `Banque` avec collection de comptes
- Méthodes `Ajouter()` et `Supprimer()` de comptes
- Indexeur pour accéder aux comptes par numéro
- Méthode `AfficherComptes()` pour lister tous les comptes
- Utilisation de `Dictionary<string, Courant>`

**Exemple de code:**
```csharp
// Indexeur pour accéder au compte
public Courant? this[string numero]
{
    get
    {
        if (!_comptes.ContainsKey(numero)) return null;
        return _comptes[numero];
    }
}
```

---

### GestionBanque03
**Objectif:** Ajouter la surcharge d'opérateurs.

**Nouvelles fonctionnalités:**
- Surcharge de l'opérateur `+` pour calculer l'avoir total
- Méthode `AvoirDesComptes()` calculant la somme des soldes positifs
- Utilisation de l'opérateur ternaire
- Gestion des soldes négatifs (non comptabilisés)

**Exemple de code:**
```csharp
// Surcharge de l'opérateur +
public static double operator +(double somme, Courant courant)
{
    return courant.Solde >= 0 ? courant.Solde + somme : 0;
}

// Utilisation
double avoir = b.AvoirDesComptes(p1);
```

---

## 🛠️ Technologies Utilisées

- **.NET 10.0**
- **C# 12**
- **Visual Studio 2025** (ou supérieur)

## 📝 Notes

- Tous les projets utilisent `ImplicitUsings` activé
- `Nullable` est activé sur tous les projets
- Les commentaires dans le code sont en français
- Les exemples progressent en complexité

## 📖 Ressources

- [Documentation officielle C#](https://docs.microsoft.com/fr-fr/dotnet/csharp/)
- [Documentation .NET](https://docs.microsoft.com/fr-fr/dotnet/)
- [Code source](https://source.dot.net/)

---

*Repository de formation - SAP250026*
