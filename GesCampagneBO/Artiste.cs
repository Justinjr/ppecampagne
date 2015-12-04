using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesCampagneBO
{
    public class Artiste
    {
        //artiste
        private int id;
        private string nom;
        private string siteWeb;
        Courant unCourant;

        //propriétés
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string SiteWeb
        {
            get { return siteWeb; }
            set { siteWeb = value; }
        }
        public Courant UnCourant
        {
            get { return unCourant; }
            set { unCourant = value; }
        }
        //constructeur
        public Artiste(int unId, string unNom, string unSiteWeb, Courant unNouvCourant)
        {
            this.id = unId;
            this.nom = unNom;
            this.siteWeb = unSiteWeb;
            this.unCourant = unNouvCourant;
        }
        public Artiste(string unNom, string unSiteWeb, Courant unNouvCourant)
        {
            this.nom = unNom;
            this.siteWeb = unSiteWeb;
            this.unCourant = unNouvCourant;
        }
        public Artiste(string unNom)
        {
            this.nom = unNom;
        }
    }
}
