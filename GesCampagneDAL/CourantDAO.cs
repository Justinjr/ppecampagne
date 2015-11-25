using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GesCampagneBO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GesCampagneDAL
{
    public class CourantDAO
    {
        private static CourantDAO uneInstanceCourantDAO;

        //cette methode s'appelle un singleton
        //elle crée un objet instance de la classeDAO s'il n'existe pas 
        //puis retourne la reference à cet objet
        public static CourantDAO GetInstanceDAOCourant()
        {
            if (uneInstanceCourantDAO == null)
            {
                uneInstanceCourantDAO = new CourantDAO();
            }
            return uneInstanceCourantDAO;
        }

        //la méthode getCourant retourne une collection contenant les lesCourants
        //existant dans la table Courant
        public List<Courant> GetCourants()
        {
            int idLu;
            string libelleLu;
            SqlDataReader monLecteur;

            //on recupere l'objet responsable de la connexion à la base
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

            //on crée la collection lesCourants de type List<Courant> qui va contenir les courants
            List<Courant> lesCourants = new List<Courant>();

            //on crée l'objet de type SqlCommand qui va contenir la requete SQL
            //permettant d'obtenir toutes les caractéristiques de tous les courants
            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            //maCommand.CommandType = CommandType.StoredProcedure;
            //maCommand.CommandText = "spSelectCourant";
            maCommand.CommandText = "select id, libelle from courant";

            //on execute la requete
            monLecteur = maCommand.ExecuteReader();

            //pour chaque enregistrement retourné on crée un objet instance de courant
            //que l'on ajoute dans la collection lesCourants
            while (monLecteur.Read())
            {
                //on récupère l'id et le libelle du courant
                idLu = (int)monLecteur["id"];
                libelleLu = (string)monLecteur["libelle"];

                Courant unCourant = new Courant(idLu, libelleLu);
                lesCourants.Add(unCourant);
            }
            AccesBD.GetInstance().CloseConnection();
            return lesCourants;
        }
    }
}
