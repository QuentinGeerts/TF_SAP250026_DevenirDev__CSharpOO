using DemoInterfaces.Interfaces;
using DemoInterfaces.models;

Admin myAdmin = new Admin() { Username = "admin", Password = "1234" };
User myUser = new User() { Username = "user", Password = "1234" };

List<IUser> personnes = new List<IUser>();

personnes.Add(myUser);
personnes.Add(myAdmin);

foreach (var personne in personnes)
{
    if (personne is IAdmin admin)
    {
        admin.Login();
    }
    if (personne is IUser user)
    {
        user.Login();
    }

    //personne.Login();
}
