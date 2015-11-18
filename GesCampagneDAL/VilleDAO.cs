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
    public class VilleDAO
    {
        private static VilleDAO uneInstanceVilleDAO;

        public static VilleDAO GetInstanceDAOVille()
        {
            if (uneInstanceVilleDAO == null)

            {
                uneInstanceVilleDAO = new VilleDAO();
            }
            return uneInstanceVilleDAO;
        }

        public List<Ville> GetVilles()
        {


            //on récup l'objet responsable de la connexion a la base
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

            //on creer la collection lesClients de type list<Client> qui va contenir les clients
            List<Ville> lesVilles = new List<Ville>();

            //crer objet de type sqlCommand
            SqlCommand maCommand = new SqlCommand();

            //execute la requete

            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "GetVille";
            // maCommand.CommandText = "select nom,prenom  from Client ";

            maCommand.Connection = cnx;
            SqlDataReader monReader = maCommand.ExecuteReader();
            while (monReader.Read())
            {
                 int numInsee = (int)monReader["numInsee"];
                 string libelle = (string)monReader["libelle"];
                 string cp = (string)monReader["cp"];

                lesVilles.Add(new Ville(numInsee,libelle, cp));

            }


            AccesBD.GetInstance().CloseConnection();
            return lesVilles;
        }


    }

}
