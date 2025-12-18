namespace DemoIndexeurs.Models;

internal class JeuVideo
{
    public string Titre { get; set; } = string.Empty;
    public string Studio { get; set; } = string.Empty;
    public int AnneeParution { get; set; }

    public override string ToString()
    {
        return $"{Titre} de {Studio} sorti en {AnneeParution}";
    }

    void changeTitre (string Titre)
    {
        this.Titre = Titre;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (!(obj is JeuVideo)) return false;
        return Titre == ((JeuVideo)obj).Titre
                && Studio == ((JeuVideo)obj).Studio
                && AnneeParution == ((JeuVideo)obj).AnneeParution;
    }
}
