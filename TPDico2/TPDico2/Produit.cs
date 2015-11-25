using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDico2
{
    public class Produit
    {
        int reference;
        string designation;
        int quantiteRestante;
        float prixDeVente;
        string categorie;

        public int Reference
        {
            get
            {
                return reference;
            }

            set
            {
                reference = value;
            }
        }

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                designation = value;
            }
        }

        public int QuantiteRestante
        {
            get
            {
                return quantiteRestante;
            }

            set
            {
                quantiteRestante = value;
            }
        }

        public float PrixDeVente
        {
            get
            {
                return prixDeVente;
            }

            set
            {
                prixDeVente = value;
            }
        }

        public string Categorie
        {
            get
            {
                return categorie;
            }

            set
            {
                categorie = value;
            }
        }

        public Produit(int uneReference, string uneDesignation,int uneQuantiteRestante,float unPrixDeVente,string uneCategorie)
        {
            reference = uneReference;
            designation = uneDesignation;
            quantiteRestante = uneQuantiteRestante;
            prixDeVente = unPrixDeVente;
            categorie = uneCategorie;
        }





    }
}
