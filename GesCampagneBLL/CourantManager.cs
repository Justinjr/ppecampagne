using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

using GesCampagneDAL;
using GesCampagneBO;

namespace GesCampagneBLL
{
    public class CourantManager
    {
        private static CourantManager uneInstanceCourantManag;

        public static CourantManager GetInstance()
        {
            if(uneInstanceCourantManag == null)
            {
                uneInstanceCourantManag = new CourantManager();
            }
            return uneInstanceCourantManag;
        }
        //cette methode permet de fournir la chaine de connexion à la couche DAl
        public void SetChaineConnexion(ConnectionStringSettings connSetting)
        {
            string laChaine = connSetting.ConnectionString;
            AccesBD.GetInstance().SetChaine(laChaine);
        }
        //appel de la couche DAL pour récupéré une collection de clients
        public List<Courant> GetCourants()
        {
            //ici , on peut appliquer des règles métier
            return CourantDAO.GetInstanceDAOCourant().GetCourants();
        }
    }
}
