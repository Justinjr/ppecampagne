using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneBO;
using System.Configuration;
using GesCampagneDAL;


namespace GesCampagneDAL
{
    public class EventDAO
    {

        private DateTime dateDebut;
        private DateTime dateFin;
        private string theme;
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
            SqlConnection cnx = AccesBD.getInstance().getSqlConnexion();

            //on creer la collection lesClients de type list<Client> qui va contenir les clients
            List<Event> lesClients = new List<Event>();

            //crer objet de type sqlCommand
            SqlCommand maCommand = new SqlCommand();

            //execute la requete


            maCommand.CommandText = "select nom,prenom  from Client ";

            maCommand.Connection = cnx;
            SqlDataReader monReader = maCommand.ExecuteReader();
            while (monReader.Read())
            {

                nom = (string)monReader["nom"];
                prenom = (string)monReader["prenom"];

                lesClients.Add(new Client(prenom, nom));

            }


            AccesBD.getInstance().CloseConnection();
            return lesClients;
        }
    }

    
}
