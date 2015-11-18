using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

using GesCampagneDAL;
using GesCampagneBO;

namespace GesCampagneBLL
{
    public class ArtisteManager
    {
        private static ArtisteManager uneInstanceArtisteManag;
        // cette methode s'appelle un singleton:
        // elle crée un objet instance de la calsse ClientManager s'il n'exist pas
        //puis retourne la référence à cet objet
        public static ArtisteManager GetInstance()
        {
            if (uneInstanceArtisteManag == null)
            {
                uneInstanceArtisteManag = new ArtisteManager();
            }
            return uneInstanceArtisteManag;
        }
        //cette methode permet de fournir la chaine de connexion à la couche DAl
        public void SetChaineConnexion(ConnectionStringSettings connSetting)
        {
            string laChaine = connSetting.ConnectionString;
            AccesBD.GetInstance().SetChaine(laChaine);
        }
        //appel de la couche DAL pour récupéré une collection de clients
        public List<Artiste> GetClients()
        {
            //ici , on peut appliquer des règles métier
            return ArtisteDAO.GetInstanceArtisteDAO().GetArtistes();
        }
        //appel de la couche DAL pour créer un nouveau client
        public int CreerArtiste(string sonNom, string sonSiteWeb , Courant sonIdCourant)
        {
            Artiste leArtiste;
            leArtiste = new Artiste(sonNom, sonSiteWeb,sonIdCourant);
            return ArtisteDAO.GetInstanceArtisteDAO().AjoutArtiste(leArtiste);
        }
    }
}
