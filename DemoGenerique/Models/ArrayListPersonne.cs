using System.Collections;

namespace DemoGenerique.Models;

public class ArrayListPersonne
{
    private ArrayList _personnes = new(); // Inférence de type (C# 9)

    public Personne this[int index]
    {
        get
        {
            if (index < 0 || index >= _personnes.Count) throw new IndexOutOfRangeException();
            return (Personne) _personnes[index];
        }
    }

    public void Add(Personne p)
    {
        if (p == null) throw new ArgumentNullException();
        if (_personnes.Contains(p)) throw new ArgumentException();
        _personnes.Add(p);
    }

    public void Remove(Personne p)
    {
        if (p == null) throw new ArgumentNullException();

        _personnes.Remove(p);
    }
}
