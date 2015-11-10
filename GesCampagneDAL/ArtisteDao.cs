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
    public class ArtisteDAO
    {
        private static ArtisteDAO uneInstanceArtisteDAO;

        //cette methode s'appelle un singleton
        //elle crée un objet instance de la classeDAO
        //s'il n'existe pas puis retourne la reference à cet objet
        public static ArtisteDAO GetInstanceArtisteDAO()
        {
            if (uneInstanceArtisteDAO == null)
            {
                uneInstanceArtisteDAO = new ArtisteDAO();
            }
            return uneInstanceArtisteDAO;
        }

        //la méthode getClient retourne une collection contenant les lesClients
        //existant dans la table Client
        public List<Artiste> GetArtistes()
        {
            string nomLu;
            string siteWebLu;
            Courant courantLu;
            SqlDataReader monLecteur;

            //on recupere l'objet responsable de la connexion à la base
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnection();

            //on crée la collection lesArtistes de type List<artiste> qui va contenir les artistes
            List<Artiste> lesClients = new List<Artiste>();

            //on crée l'objet de type SqlCommand qui va contenir la requete SQL
            //permettant d'obtenir toutes les caractéristiques de tous les artistes
            SqlCommand command = new SqlCommand();
            command.Connection = cnx;
            command.CommandText = "select * from artiste";

            //on execute la requete
            monLecteur = command.ExecuteReader();

            //pour chaque enregistrement retourné on crée un objet instance de client
            //que l'on ajoute dans la collection lesClients
            while (monLecteur.Read())
            {
                //on récupère le nom et le numéro de l'employe
                nomLu = (string)monLecteur["nom"];
                siteWebLu = (string)monLecteur["siteWeb"];
                courantLu = (Courant)monLecteur["Courant"];

                Artiste unClient = new Artiste(nomLu, siteWebLu , courantLu);
                lesArtistes.Add(unArtiste);
            }
            AccesBD.GetInstance().CloseConnection();
            return lesClients;
        }
        //on ajoute l'artiste dans la base de données.Les caractéristiques de l'artiste sont passées
        //en paramètre (objet unClient). La méthode retourne le nombre d'enregistrements
        //ajoutés
        public int AjoutArtiste(Artiste unArtiste)
        {
            int nbLigne = 0;
            string nom = unArtiste.Nom;
            string siteWeb = unArtiste.SiteWeb;
            Courant Courant = unArtiste.UnCourant;
            SqlDataReader monLecteur;

            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnection();

            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "obtenirArtiste";

            monLecteur = maCommand.ExecuteReader();

            int nb = (int)maCommand.ExecuteScalar();

            if (nb == 0)
            {
                maCommand.Parameters.Clear();
                maCommand.CommandText = "creerArtiste";

                maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[0].Value = unArtiste.Nom;
                maCommand.Parameters.Add("siteWeb", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[1].Value = unArtiste.SiteWeb;
                maCommand.Parameters.Add("Courant", System.Data.SqlDbType.Courant);
                maCommand.Parameters[2].Value = unArtiste.UnCourant;

                nbLigne = maCommand.ExecuteNonQuery();
            }
            //on retourne le nombre d'enregistrement ajoutées
            //refermer la connection avant chaque return
            AccesBD.GetInstance().CloseConnection();
            return nbLigne;
        }
    }
}
