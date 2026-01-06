namespace DemoDelegues.Models;

public delegate bool CompareFnDelegate(Personne p);

public static class FilterToolBox
{
    public static List<Personne> FilterBySexeHomme (List<Personne> personnes)
    {
        List<Personne> p = new List<Personne>();

        foreach (Personne personne in personnes)
        {
            if (personne.Sexe == Sexe.Homme) p.Add(personne);
        }

        return p;
    }

    public static List<Personne> FilterByNameGeerts(List<Personne> personnes)
    {
        List<Personne> p = new List<Personne>();

        foreach (Personne personne in personnes)
        {
            if (IsNameIsGeerts(personne)) p.Add(personne);
        }

        return p;
    }

    private static bool IsNameIsGeerts(Personne p)
    {
        return p.Nom == "Geerts";
    }


    public static List<Personne> Filter(List<Personne> personnes, CompareFnDelegate compareFn)
    {
        if (compareFn == null) throw new ArgumentNullException();

        List<Personne> p = new List<Personne>();

        foreach (Personne personne in personnes)
        {
            if (compareFn(personne)) p.Add(personne);
        }

        return p;
    }

    public static List<Personne> Filter2(List<Personne> personnes, Predicate<Personne> compareFn)
    {
        if (compareFn == null) throw new ArgumentNullException();

        List<Personne> p = new List<Personne>();

        foreach (Personne personne in personnes)
        {
            if (compareFn(personne)) p.Add(personne);
        }

        return p;
    }
}
