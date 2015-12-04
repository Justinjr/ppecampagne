using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GesCampagneBO;
using GesCampagneDAL;

namespace GesCampagneBLL
{
    public class CampagneManager
    {
        private static CampagneManager uneInstanceCampagneManager;

        public static CampagneManager GetInstance()
        {
            if (uneInstanceCampagneManager == null)
            {
                uneInstanceCampagneManager = new CampagneManager();
            }
            return uneInstanceCampagneManager;
        }

        public void SetChaineConnexion(ConnectionStringSettings connSetting)
        {
            string laChaine = connSetting.ConnectionString;
            AccesBD.GetInstance().SetChaine(laChaine);
        }


        public int CreerCampagne(string unIntitule, string unObjectif, DateTime uneDateDebut, DateTime uneDateFin, int unIdPublic, int unIdEmploye)
        {
            Campagne laCampagne;
            Public unPublic = new Public(unIdPublic);
            Employe unEmploye = new Employe(unIdEmploye);
            laCampagne = new Campagne( unIntitule, unObjectif, uneDateDebut, uneDateFin, unPublic, unEmploye);
            return CampagneDAO.GetInstanceDAOCampagne().AjoutCampagne(laCampagne);
        }




    }
}
