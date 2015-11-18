using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GesCampagneBO;
using GesCampagneDAL;

namespace GesCampagneBLL
{
    public class PublicManager
    {
        private static PublicManager uneInstancePublicManager;

        public static PublicManager GetInstance()
        {
            if (uneInstancePublicManager == null)
            {
                uneInstancePublicManager = new PublicManager();
            }
            return uneInstancePublicManager;
        }

        public void SetChaineConnexion(ConnectionStringSettings connSetting)
        {
            string laChaine = connSetting.ConnectionString;
            AccesBD.GetInstance().SetChaine(laChaine);
        }

        public List<Public> GetPublics()
        {
            return PublicDAO.GetInstanceDAOPublic().GetPublics();
        }

    }
}
