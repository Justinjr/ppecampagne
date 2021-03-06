﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneDAL;
using System.Configuration;
using GesCampagneBO;


namespace GesCampagneBLL
{
    public class VilleManager
    {
        private static VilleManager uneInstanceCliManag;

        //cette methode sappelle un singleton
        //elle crée un objet instance de la classe clientManager s'il n'existe pas
        //puis retourne la reference a cet objet
        public static VilleManager GetInstance()
        {
            if (uneInstanceCliManag == null)
            {
                uneInstanceCliManag = new VilleManager();
            }
            return uneInstanceCliManag;
        }

        //cette methode permet de fournir la chaine de connexion a la couche DAL
        public void SetChaineConnexion(ConnectionStringSettings connSetting)
        {
            string laChaine = connSetting.ConnectionString;
            AccesBD.GetInstance().SetChaine(laChaine);
        }
        //appel de la couche DAL pour recup une collectionn de client
        public List<Ville> GetVilles()
        {
            return VilleDAO.GetInstanceDAOVille().GetVilles();
        }

        
       
    }
}
