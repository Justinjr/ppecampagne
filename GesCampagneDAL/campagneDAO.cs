using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneBO;
using System.Data.SqlClient;
using System.Data;

namespace GesCampagneDAL
{
    public class CampagneDAO
    {
        private static CampagneDAO uneInstanceCampagneDAO;

        public static CampagneDAO GetInstanceDAOCampagne()
        {
            if (uneInstanceCampagneDAO==null)
            {
                uneInstanceCampagneDAO = new CampagneDAO();
            }
            return uneInstanceCampagneDAO;
        }

        /// <summary>
        /// Ajoute une campagne passé en paramètre si elle n'existe pas déjà.
        /// </summary>
        /// <param name="uneCampagne">référence à campagne</param>
        /// <returns>Retourne 0 si elle existe et 1 si elle s'ajoute.</returns>
        public int AjoutCampagne(Campagne uneCampagne)
        {
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();
            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            //maCommand.CommandType = CommandType.StoredProcedure;
            //maCommand.CommandText = "lenomdelaprocedure";

            maCommand.Parameters.Clear();
            maCommand.CommandText = "select count(*) from Campagne where intitule=@intitule and objectif=@objectif";
            maCommand.Parameters.Add("intitule", System.Data.SqlDbType.VarChar);
            maCommand.Parameters[0].Value = uneCampagne.Intitule;
            maCommand.Parameters.Add("objectif", System.Data.SqlDbType.VarChar);
            maCommand.Parameters[1].Value = uneCampagne.Objectif;

            int nbRet = (int)maCommand.ExecuteScalar();

            if (nbRet > 0)
            {
                AccesBD.GetInstance().CloseConnection();
                return 0;
            }
            else
            {
                //maCommand.CommandType = CommandType.StoredProcedure;
                //maCommand.CommandText = "lenomdelaprocedure";
                maCommand.Parameters.Clear();
                maCommand.CommandText = "insert into Campagne values(@intitule,@objectif,@dateDebut,@dateFin,@idPublic,@idEmploye)";
                maCommand.Parameters.Add("intitule", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[0].Value = uneCampagne.Intitule;
                maCommand.Parameters.Add("objectif", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[1].Value = uneCampagne.Objectif;
                maCommand.Parameters.Add("dateDebut", System.Data.SqlDbType.DateTime);
                maCommand.Parameters[2].Value = uneCampagne.DateDebut;
                maCommand.Parameters.Add("dateFin", System.Data.SqlDbType.DateTime);
                maCommand.Parameters[3].Value = uneCampagne.DateFin;
                maCommand.Parameters.Add("idPublic", System.Data.SqlDbType.Int);
                maCommand.Parameters[4].Value = uneCampagne.IdPublic.Id;
                maCommand.Parameters.Add("idEmploye", System.Data.SqlDbType.Int);
                maCommand.Parameters[5].Value = uneCampagne.IdEmploye.Id;


                int nb = (int)maCommand.ExecuteNonQuery();

                AccesBD.GetInstance().CloseConnection();
                return nb;
            }
        }
             public List<Campagne> GetCampagnes()
        {
            
            //on récup l'objet responsable de la connexion a la base
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

            //on creer la collection lesClients de type list<Client> qui va contenir les clients
            List<Campagne> lesCampagnes = new List<Campagne>();

            //crer objet de type sqlCommand
            SqlCommand maCommand = new SqlCommand();

            //execute la requete

            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spGetCampagnes";
           // maCommand.CommandText = "select Campagne.id,intitule from Campagne";
            maCommand.Connection = cnx;
            SqlDataReader monReader = maCommand.ExecuteReader();
            while (monReader.Read())
            {
                int id = (int)monReader["id"];
                string intitule = (string)monReader["intitule"]; 
               

                lesCampagnes.Add(new Campagne(id,intitule));

            }


            AccesBD.GetInstance().CloseConnection();
            return lesCampagnes;
        }
    }

    
}
