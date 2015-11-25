using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDico2
{
    class Program
    {
        static void Main(string[] args)
        {

            Produit prod1 =new Produit(1,"boite",50,50,"A");
            Produit prod2 = new Produit(1, "cailloux", 50, 50, "B");
            Produit prod3 = new Produit(1, "carton", 50, 50, "A");
            Produit prod4 = new Produit(1, "table", 50, 50, "C");


            Commande com1 = new Commande(1, DateTime.Now);
            Commande com2 = new Commande(2, DateTime.Now);
            Commande com3 = new Commande(3, DateTime.Now);
            Commande com4 = new Commande(4, DateTime.Now);

            com1.AjouterLigne(prod1, 10);
            com1.AjouterLigne(prod3, 20);
            com1.AjouterLigne(prod4, 5);

            com2.AjouterLigne(prod2, 2);
            com2.AjouterLigne(prod3, 30);

            com3.AjouterLigne(prod4, 15);
            com3.AjouterLigne(prod2, 13);

            com4.AjouterLigne(prod3, 4);

            //string valSaisie;
            //Console.WriteLine("Veuillez saisir une quantite");
            //valSaisie = Console.ReadLine();
            //int qte;
            //int.TryParse(valSaisie, out qte);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-------------Commande 1-------------");
            Console.WriteLine("------------------------------------");
            com1.AfficherQteSupValeur(8);
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-------------Commande 2-------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(com1.GetTotalQte());
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-------------Commande 3-------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(com1.GetQteUnProduit(prod1));
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-------------Commande 4-------------");
            Console.WriteLine("------------------------------------");
            foreach (string uneCle in com1.GetQteParCategorie().Keys)
            {
                Console.WriteLine(uneCle+" "+com1.GetQteParCategorie()[uneCle]);
            }
            Console.WriteLine("------------------------------------");




            Console.ReadLine();
        }
    }
}
