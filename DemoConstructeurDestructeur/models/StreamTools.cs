using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConstructeurDestructeur.models
{
    internal static class StreamTools
    {

        public static void WriteFile(string path , string content)
        {
            // ouverture du fichier en ecriture
            using (StreamWriter writer = new StreamWriter(path))
            {
                // ecriture dans le fichier
                writer.WriteLine(content);
            }
            // fin du using => appel automatique de Dispose() => fermeture du fichier

            Console.WriteLine("Le fichier à été fermé");
        }

        public static string ReadFile(string path )
        {
            string content = "";
            // Ouverture du fichier en lecture
            using (StreamReader reader = new StreamReader(path))
            {
                // Lecture du contenu du fichier
                content = reader.ReadToEnd();

            }
            // Fin du using => appel automatique de Dispose() => fermeture du fichier
            Console.WriteLine("Fin de la lecture du fichier");    
            return content;
        }
    }
}
