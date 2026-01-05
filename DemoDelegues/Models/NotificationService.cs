namespace DemoDelegues.Models;

// Définition du délégué pour les méthodes de notification
// Les méthodes ne retournent pas de valeur et prennent une chaine de caractères en paramètre
public delegate void NotificationDelegate(string message);

public class NotificationService
{
    public NotificationDelegate? _notification;

    public NotificationService()
    {
        Ajouter(EnvoyerSecret);
    }

    // Méthode pour ajouter une méthode de notification
    public void Ajouter(NotificationDelegate methode)
    {
        _notification += methode;
    }

    // Méthode pour supprimer une méthode de notification
    public void Supprimer(NotificationDelegate methode)
    {
        _notification -= methode;
    }

    // Méthode pour déclencher le délégué
    public void Notifier(string message)
    {
        // 1ère version:
        //if (_notification != null) _notification(message);

        // 2ème version:
        //if (_notification != null) _notification.Invoke(message);

        // 3ème version:
        _notification?.Invoke(message);
    }

    private void EnvoyerSecret(string message)
    {
        Console.WriteLine($"Secret: {message}");
    }

}
