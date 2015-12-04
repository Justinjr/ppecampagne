using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneBO;
using System.Data;
using System.Data.SqlClient;

namespace GesCampagneDAL
{
    public class MessageDAO
    {
        private static MessageDAO uneInstanceMessageDAO;

        public static MessageDAO GetInstanceDAOMessage()
        {
            if (uneInstanceMessageDAO == null)
            {
                uneInstanceMessageDAO = new MessageDAO();
            }
            return uneInstanceMessageDAO;
        }
        public int AjoutMessage(Message unMessage)
        {
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();
            SqlCommand maCommand = new SqlCommand();

            maCommand.CommandType = CommandType.StoredProcedure;
            //;

            // Verifier si un message a deja été créé pour CET event ET CETTE categorie
            maCommand.Parameters.Clear();
            maCommand.CommandText = "spExistenceMessage";
            maCommand.Parameters.Add("idCategorieVip", System.Data.SqlDbType.Int);
            maCommand.Parameters[0].Value = unMessage.LaCategorieVip;
            maCommand.Parameters.Add("idEvenement", System.Data.SqlDbType.Int);
            maCommand.Parameters[1].Value = unMessage.LEvent;

            bool ret = (bool)maCommand.ExecuteScalar();
            int nb = 0;
            // On verifie si un message existe deja (false) 
            // Ou si il n'existe pas (true)
            if (ret == false)
            {
                AccesBD.GetInstance().CloseConnection();
                nb = -1;
            }
            else
            {
                if (ret == true)
                {
                    maCommand.Parameters.Clear();
                    maCommand.CommandText = "spAjoutMessage";
                    maCommand.Parameters.Add("corps", System.Data.SqlDbType.Text);
                    maCommand.Parameters[0].Value = unMessage.Corps;
                    maCommand.Parameters.Add("date", System.Data.SqlDbType.DateTime);
                    maCommand.Parameters[1].Value = unMessage.Date;
                    maCommand.Parameters.Add("categ", System.Data.SqlDbType.Int);
                    maCommand.Parameters[2].Value = unMessage.LaCategorieVip;
                    maCommand.Parameters.Add("event", System.Data.SqlDbType.Int);
                    maCommand.Parameters[3].Value = unMessage.LEvent;

                    nb = (int)maCommand.ExecuteNonQuery();
                    AccesBD.GetInstance().CloseConnection();
                }
            }
            return nb;
            
        }
        public List<Message> GetMessages()
        {
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();
            List<Message> lesMessages = new List<Message>();
            SqlCommand maCommand = new SqlCommand();

            maCommand.Connection = cnx;
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spGetMessages";
            SqlDataReader monReader = maCommand.ExecuteReader();

            while (monReader.Read())
            {
                int id = (int)monReader["id"];
                string corps = (string)monReader["corps"];
                DateTime date = (DateTime)monReader["date"];
                Event unEvent = (Event)monReader["idEvenement"];
                CategorieVip categ = (CategorieVip)monReader["idCategorieVip"];

                lesMessages.Add(new Message(id, corps, date, categ, unEvent));       
            }
            AccesBD.GetInstance().CloseConnection();
            return lesMessages;
            
        }
    }
}
