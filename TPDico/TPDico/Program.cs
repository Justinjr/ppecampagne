using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDico
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortedDictionary<string, Employe> lesCaracEmployes;
            lesCaracEmployes = new SortedDictionary<string, Employe>();
            
            string key;


            key = "A";
            if (lesCaracEmployes.ContainsKey(key)==false)
            {
                lesCaracEmployes.Add(key, new Employe(key, "Dumas", 20));
            }
            key = "Z";
            if (lesCaracEmployes.ContainsKey(key) == false)
            {
                lesCaracEmployes.Add(key, new Employe(key, "Romain", 20));
            }
            key = "B";
            if (lesCaracEmployes.ContainsKey(key) == false)
            {
                lesCaracEmployes.Add(key, new Employe(key, "Ozon", 20));
            }
            key = "X";
            if (lesCaracEmployes.ContainsKey(key) == false)
            {
                lesCaracEmployes.Add(key, new Employe(key, "Margaux", 20));
            }
            key = "C";
            if (lesCaracEmployes.ContainsKey(key) == false)
            {
                lesCaracEmployes.Add(key, new Employe(key, "Yoann", 20));
            }





            string choix="";
            while (choix != "3")
            {
                Console.WriteLine("Veuillez sélectionner 1 pour afficher les employés, 2 pour supprimer un employe ou 3 pour sortir");
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        foreach (Employe unEmploye in lesCaracEmployes.Values)
                        {
                            Console.WriteLine(unEmploye.Matricule + " " + unEmploye.Nom + " " + unEmploye.Age);
                        }

                        Console.ReadLine();

                        break;
                    case "2":
                        Console.WriteLine("Veuillez saisir le matricule d'un employe à supprimer");
                        string matriculeEmployeSupp = Console.ReadLine();
                        if (lesCaracEmployes.ContainsKey(matriculeEmployeSupp) == true)
                        {

                            lesCaracEmployes.Remove(matriculeEmployeSupp);
                            Console.WriteLine("L'employe avec le matricule " + matriculeEmployeSupp + " a bien été supprimer.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("L'employe avec le matricule " + matriculeEmployeSupp + " n'existe pas.");
                            Console.ReadLine();
                        }

                        break;
                    default:
                        break;
                }
                Console.Clear();
            }

           
        }
    }
}
