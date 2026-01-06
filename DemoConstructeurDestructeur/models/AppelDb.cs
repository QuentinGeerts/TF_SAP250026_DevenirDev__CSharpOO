using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DemoConstructeurDestructeur.models
{
    internal class AppelDb : IDisposable
    {
        public void Dispose()
        {
            
        }

        public void ConnectToDb(string adresse , bool isOpen)
        {
            if(isOpen)
            {
                string ConnectionDB = "Connection => AdresseDb";

                // Ouvrir la Conection
                // prendre un certains temps pour se connecter

                // Commencer la lecture
                // prendre un certains temps pour lire les données
                Console.WriteLine("Connexion a la base de donnee a l'adresse : " + adresse);

            }
                Dispose();
        }
    }
}
