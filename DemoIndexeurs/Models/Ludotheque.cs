namespace DemoIndexeurs.Models;

internal class Ludotheque
{
    //  Champ
    private List<JeuVideo> _jeuVideos = new List<JeuVideo>();


    //  Indexeurs
    internal JeuVideo this[int index]
    {
        get
        {
            if (index < 0 || index >= _jeuVideos.Count) throw new IndexOutOfRangeException();
            return _jeuVideos[index];
        }

        set
        {
            if (index < 0 || index >= _jeuVideos.Count) return;
            if (value == null) return;
            foreach (JeuVideo jeu in _jeuVideos)
            {
                if (jeu.Equals(value)) return;
            }
            _jeuVideos[index] = value;
        }
    }

    public JeuVideo? this[string titre, string studio, int annee]
    {
        get
        {
            JeuVideo jeuARechercher = new JeuVideo
            {
                Titre = titre,
                Studio = studio,
                AnneeParution = annee
            };
            foreach (JeuVideo jeu in _jeuVideos)
            {
                if (jeu.Equals(jeuARechercher)) return jeu;
            }
            return null;
        }
    }


    //  Méthodes
    internal bool AjouterJeu (JeuVideo jeuVideo)
    {
        if (jeuVideo == null) return false;
        foreach (JeuVideo jeu in _jeuVideos)
        {
            if (jeu.Equals(jeuVideo)) return false;
        }
        _jeuVideos.Add(jeuVideo);
        return true;
    }

    internal string AfficherListe ()
    {
        string str = "";

        foreach (JeuVideo jeu in _jeuVideos)
        {
            str += $"- {jeu}\n";
        }

        return str;
    }

}
