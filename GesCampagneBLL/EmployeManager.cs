using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GesCampagneBO;
using GesCampagneDAL;

namespace GesCampagneBLL
{
    public class EmployeManager
    {
        private static EmployeManager uneInstanceEmployeManager;

        public static EmployeManager GetInstance()
        {
            if (uneInstanceEmployeManager == null)
            {
                uneInstanceEmployeManager = new EmployeManager();
            }
            return uneInstanceEmployeManager;
        }

        public void SetChaineConnexion(ConnectionStringSettings connSetting)
        {
            string laChaine = connSetting.ConnectionString;
            AccesBD.GetInstance().SetChaine(laChaine);
        }

        public List<Employe> GetEmployes()
        {
            return EmployeDAO.GetInstanceDAOEmploye().GetEmployes();
        }

    }
}
