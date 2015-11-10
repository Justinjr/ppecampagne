using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneBO;
using System.Configuration;
using GesCampagneDAL;
using System.Data.SqlClient;


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

        public int AjoutEvent(Event unEvent)
        {


            //recup l'objet responsable de la connexion a la base
            SqlConnection cnx = AccesBD.getInstance().getSqlConnexion();
            SqlCommand maCommand = new SqlCommand();


            maCommand.Connection = cnx;
            maCommand.Parameters.Clear();

            maCommand.CommandText = "select Count(*) from Client where nom=@nom and prenom=@prenom ";
            maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
            maCommand.Parameters[0].Value = unEvent.Nom;
            maCommand.Parameters.Add("prenom", System.Data.SqlDbType.VarChar);
            maCommand.Parameters[1].Value = unEvent.Prenom;

            int nb = (int)maCommand.ExecuteScalar();

            if (nb > 0)
            {
                AccesBD.getInstance().CloseConnection();
                return 0;
            }
            else
            {
                maCommand.Parameters.Clear();
                maCommand.CommandText = "insert into Evenement values(@nom,@prenom)";


                maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[0].Value = unEvent.Nom;
                maCommand.Parameters.Add("prenom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[1].Value = unEvent.Prenom;

                int nbEnregAjout = maCommand.ExecuteNonQuery();
                AccesBD.getInstance().CloseConnection();
                return nbEnregAjout;


            }

    
}
