﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneDAL;
using System.Configuration;
using GesCampagneBO;




namespace GesCampagneBLL
{
    public class EventManager
    {

        private static EventManager uneInstanceCliManag;

        //cette methode sappelle un singleton
        //elle crée un objet instance de la classe clientManager s'il n'existe pas
        //puis retourne la reference a cet objet
        public static EventManager GetInstance()
        {
            if (uneInstanceCliManag == null)
            {
                uneInstanceCliManag = new EventManager();
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
        public List<Event> GetEvents()
        {
            return EventDAO.GetInstanceDAOEvent().GetEvents();
        }

        //appel de la couche DAL pour creer un new client
        public int CreerEvenement(string theme, DateTime dateDebut, DateTime dateFin, Campagne laCampagne, Ville laVille)
        {
            Event leEvenement;
            leEvenement = new Event( theme,  dateDebut,  dateFin, laCampagne,laVille);
            return EventDAO.GetInstanceDAOEvent().AjoutEvent(leEvenement);
        }
    }
}
