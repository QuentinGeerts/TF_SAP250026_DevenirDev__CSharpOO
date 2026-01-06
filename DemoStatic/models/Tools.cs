using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DemoStatic.models
{
    internal static class Tools
    {

        public static void AfficheMenu() 
        {
            Console.WriteLine("Faites votre choix :");
            Console.WriteLine("1 - accueil");
            Console.WriteLine("1 - afficher la liste");
        }
    
        public static int GetInt()
        {
            int result = 0;
            bool isCorrect = false;

            while (!isCorrect)
            {
                Console.WriteLine("Entrez un nombre");
                string inputUser = Console.ReadLine();

                isCorrect = int.TryParse(inputUser, out result);
            }
            return result;
        }
        
        public static string getOperator() 
        {
            bool isCorrect = false;
            string[] operatorsCorrect = ["+", "-", "*", "/"];

            string input = "";

            while (!isCorrect)
            {
                Console.WriteLine("Entrez un operateur : + - * /");

                input = Console.ReadLine();

                if (operatorsCorrect.Contains(input))
                {
                    isCorrect = true;
                }
            }
            return input;
        }
    
        public static bool GetAnswer()
        {
            bool result = false;
            bool isCorrect = false;

            while (!isCorrect)
            {
                Console.WriteLine("Entrez o pour continuez , n pour stopper");

                string input = Console.ReadLine();

                if(input == "o")
                {
                    result = true;
                    isCorrect = true;
                }
                else
                if(input == "n")
                {
                    result = false;
                    isCorrect = true;
                }
            }

            return result;
            
        }
    }
}
