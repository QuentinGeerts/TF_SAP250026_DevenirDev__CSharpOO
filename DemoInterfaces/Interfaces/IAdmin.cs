namespace DemoInterfaces.Interfaces;

internal interface IAdmin : IUser
{

    int Age { get; set; }
    void AfficherInfoAdmin();

    void SupprimerUtilisateur(string username);

    void AjouterUtilisateur(string username);
}
