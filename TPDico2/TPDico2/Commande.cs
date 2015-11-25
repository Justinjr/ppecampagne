using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDico2
{
    public class Commande
    {
        int id;
        DateTime dateCreation;
        Dictionary<Produit, int> lignes;

        public Commande(int unId, DateTime uneDateCreation)
        {
            id = unId;
            dateCreation = uneDateCreation;
            lignes = new Dictionary<Produit, int>();
        }

        public Dictionary<Produit, int> GetLignes()
        {
            return lignes;
        }

        public void AjouterLigne(Produit unProd, int uneQte)
        {
            lignes.Add(unProd, uneQte);
        }

        public void SupprimerLigne(Produit unProd)
        {
            if (lignes.ContainsKey(unProd))
            {
                lignes.Remove(unProd);
            }
        }

        public void AfficherQteSupValeur(int uneQuantite)
        {
            foreach (Produit unProduit in lignes.Keys)
            {
                if (lignes[unProduit]>uneQuantite)
                {
                    Console.WriteLine(unProduit.Designation);
                }
            }
        }

        public int GetTotalQte()
        {
            int qte = 0;


            foreach (int uneValeur in lignes.Values)
            {
                qte += uneValeur;
            }

            return qte;
        }

        public int GetQteUnProduit(Produit unProduit)
        {
            int qte = 0;
            if (lignes.ContainsKey(unProduit)==true)
            {
                qte=lignes[unProduit];
            }
            return qte;
        }

        public Dictionary<string, int> GetQteParCategorie()
        {
            Dictionary<string, int> lesCategories = new Dictionary<string, int>();

            foreach (Produit unProduit in lignes.Keys)
            {
                if (lesCategories.ContainsKey(unProduit.Categorie)==false)
                {
                    lesCategories.Add(unProduit.Categorie, lignes[unProduit]);
                }
                else
                {
                    lesCategories[unProduit.Categorie] += lignes[unProduit];
                }
            }

            return lesCategories;
        }






    }
}
