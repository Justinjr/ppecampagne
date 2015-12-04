using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneBO;
using System.Configuration;
using GesCampagneDAL;
using System.Data.SqlClient;
using System.Data;


namespace GesCampagneDAL
{
    public class EventDAO
    {
        
        private static EventDAO uneInstanceEventDAO;

        public static EventDAO GetInstanceDAOEvent()
        {
            if (uneInstanceEventDAO == null)

            {
                uneInstanceEventDAO = new EventDAO();
            }
            return uneInstanceEventDAO;
        }

        public List<Event> GetEvents()
        {


            //on récup l'objet responsable de la connexion a la base
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

            //on creer la collection lesClients de type list<Client> qui va contenir les clients
            List<Event> lesEvents = new List<Event>();

            //crer objet de type sqlCommand
            SqlCommand maCommand = new SqlCommand();

            //execute la requete

            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spGetEvents";
            // maCommand.CommandText = "select nom,prenom  from Client ";

            maCommand.Connection = cnx;
            SqlDataReader monReader = maCommand.ExecuteReader();
            while (monReader.Read())
            {
                int id = (int)monReader["id"];
                string theme = (string)monReader["theme"];
                DateTime dateDebut = (DateTime)monReader["dateDebut"];
                DateTime dateFin = (DateTime)monReader["dateFin"];
                Campagne laCampagne = (Campagne)monReader["idCampagne"];
                Ville laVille = (Ville)monReader["idVille"];
                
               


                lesEvents.Add(new Event(id,theme,dateDebut,dateFin,laCampagne,laVille));

            }


            AccesBD.GetInstance().CloseConnection();
            return lesEvents;
        }

        /// <summary>
        /// appel de la dao pour ajouter un evenement
        /// </summary>
        /// <param name="unEvent"></param>
        /// <returns>nombre d'element ajouter dans un evenement</returns>
        public int AjoutEvent(Event unEvent)
        {


            //recup l'objet responsable de la connexion a la base
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();
            SqlCommand maCommand = new SqlCommand();


            maCommand.Connection = cnx;
            maCommand.Parameters.Clear();
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "selectEvent";


            // maCommand.CommandText = "select Count(*) from Evenement where idCampagne=@idCampagne and  idVille=@idVille  ";

            maCommand.Parameters.Add("idCampagne", System.Data.SqlDbType.Int);
            maCommand.Parameters[0].Value = unEvent.LaCampagne.Id;
            maCommand.Parameters.Add("idVille", System.Data.SqlDbType.Int);
            maCommand.Parameters[1].Value = unEvent.LaVille.NumInsee;

            int nb = (int)maCommand.ExecuteScalar();

            if (nb > 0)
            {
                AccesBD.GetInstance().CloseConnection();
                return 0;
            }
            else
            {
                maCommand.Parameters.Clear();
                //maCommand.CommandText = "insert into Evenement values(@theme,@Campagne,@dateDebut,@dateFin,@Ville)";
                maCommand.CommandType = CommandType.StoredProcedure;
                maCommand.CommandText = "ajoutEvent";

                maCommand.Parameters.Add("theme", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[0].Value = unEvent.Theme;
                maCommand.Parameters.Add("dateDebut", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[2].Value = unEvent.DateDebut;
                maCommand.Parameters.Add("dateFin", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[3].Value = unEvent.DateFin;
                maCommand.Parameters.Add("idCampagne", System.Data.SqlDbType.Int);
                maCommand.Parameters[1].Value = unEvent.LaCampagne.Id;
                maCommand.Parameters.Add("idVille", System.Data.SqlDbType.Int);
                maCommand.Parameters[4].Value = unEvent.LaVille.NumInsee;

                int eventAjout = maCommand.ExecuteNonQuery();
                AccesBD.GetInstance().CloseConnection();
                return eventAjout;


            }

        }
    }
}
