using DemoGenerique.Interfaces;

namespace DemoGenerique.Models;

// where T : struct         → type valeur
// where T : class          → type référence
// where T : new()          → posséder un constructeur sans paramètre
// where T : NomClasse      → doit hériter de la dite classe
// where T : NomInterface   → doit implémenter la dite interface
internal class ListGeneric<TypeGeneric> where TypeGeneric : BaseEntity, IBaseEntity, new()
{
    private List<TypeGeneric> items = new();

    public TypeGeneric this[int index]
    {
        get
        {
            if (index < 0 || index >= items.Count) throw new IndexOutOfRangeException();
            return items[index];
        }
    }

    public void Add(TypeGeneric item)
    {
        if (item == null) throw new ArgumentNullException();
        if (items.Contains(item)) throw new ArgumentException();

        items.Add(item);
    }

    public void Remove(TypeGeneric item)
    {
        if (item == null) throw new ArgumentNullException();

        items.Remove(item);
    }

    //public List<TypeGeneric> Filter(Type type)
    //{
    //    List<TypeGeneric> enfants = new List<TypeGeneric>();

    //    foreach (var item in items)
    //    {
    //        if (item.GetType() == type)
    //        {
    //            enfants.Add(item);
    //        }
    //    }

    //    return enfants;
    //}

    public List<TypeEnfant> Filter<TypeEnfant>() where TypeEnfant : TypeGeneric
    {
        List<TypeEnfant> enfants = new List<TypeEnfant>();

        foreach (var item in items)
        {
            if (item is TypeEnfant)
            {
                enfants.Add((TypeEnfant)item);
            }
        }

        return enfants;
    }
}
