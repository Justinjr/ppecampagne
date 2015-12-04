using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GesCampagneBO;
using GesCampagneDAL;

namespace GesCampagneBLL
{
    public class MessageManager
    {
        private static MessageManager uneInstanceMessageManager;

        public static MessageManager GetInstance()
        {
            if (uneInstanceMessageManager == null)
            {
                uneInstanceMessageManager = new MessageManager();
            }
            return uneInstanceMessageManager;
        }

        public void SetChaineConnexion(ConnectionStringSettings connSetting)
        {
            string laChaine = connSetting.ConnectionString;
            AccesBD.GetInstance().SetChaine(laChaine);
        }

        public int CreerMessage(string unCorps, DateTime uneDate, int unIdCategVip, int  unIdEvent)
        {
            Message leMessage;
            CategorieVip laCateg = new CategorieVip(unIdCategVip);
            Event lEvent = new Event(unIdEvent);
            leMessage = new Message(unCorps, uneDate, laCateg, lEvent);
            return MessageDAO.GetInstanceDAOMessage().AjoutMessage(leMessage);
        }
    }
}
