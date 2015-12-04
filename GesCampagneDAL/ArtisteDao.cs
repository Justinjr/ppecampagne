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

        /// <summary>
        /// la méthode getArtiste retourne une collection contenant les Artistes
        /// existant dans la table Artiste
        /// </summary>
        /// <returns>la liste de tous les artistes</returns>
        public List<Artiste> GetArtistes()
        {
            string nomLu;
            string siteWebLu;
            Courant courantLu;
            SqlDataReader monLecteur;

            //on recupere l'objet responsable de la connexion à la base
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

            //on crée la collection lesArtistes de type List<artiste> qui va contenir les artistes
            List<Artiste> lesArtistes = new List<Artiste>();

            //on crée l'objet de type SqlCommand qui va contenir la requete SQL
            //permettant d'obtenir toutes les caractéristiques de tous les artistes
            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            //maCommand.CommandType = CommandType.StoredProcedure;
            //maCommand.CommandText = "spObtenirArtiste";
            maCommand.CommandText = "select * from artiste";

            //on execute la requete
            monLecteur = maCommand.ExecuteReader();

            //pour chaque enregistrement retourné on crée un objet instance de artiste
            //que l'on ajoute dans la collection lesArtistes
            while (monLecteur.Read())
            {
                //on récupère le nom et le numéro de l'employe
                nomLu = (string)monLecteur["nom"];
                siteWebLu = (string)monLecteur["siteWeb"];
                courantLu = (Courant)monLecteur["Courant"];

                Artiste unArtiste = new Artiste(nomLu, siteWebLu , courantLu);
                lesArtistes.Add(unArtiste);
            }
            AccesBD.GetInstance().CloseConnection();
            return lesArtistes;
        }
        public int ArtisteExist(Artiste unArtiste)
        {
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.Parameters.Clear();
            //maCommand.CommandType = CommandType.StoredProcedure;
            //maCommand.CommandText = "spObtenirArtiste";
            maCommand.CommandText = "select count(*) from Artiste where nom = @nom";

            maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
            maCommand.Parameters[0].Value = unArtiste.Nom;

            int nb = (int)maCommand.ExecuteScalar();
            //on retourne le nombre d'enregistrement ajoutées
            //refermer la connection avant chaque return
            AccesBD.GetInstance().CloseConnection();
            return nb;
        }
        //on ajoute l'artiste dans la base de données.Les caractéristiques de l'artiste sont passées
        //en paramètre (objet unArtiste). La méthode retourne le nombre d'enregistrements
        //ajoutés
        public int AjoutArtiste(Artiste unArtiste)
        {  
            //SqlDataReader monLecteur;

            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.Parameters.Clear();

            maCommand.Parameters.Clear();
            //maCommand.CommandType = CommandType.StoredProcedure;
            //maCommand.CommandText = "spAjoutArtiste";
            maCommand.CommandText = "insert into dbo.artiste values(@nom,@siteWeb,@idCourant)";

            maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
            maCommand.Parameters[0].Value = unArtiste.Nom;
            maCommand.Parameters.Add("siteWeb", System.Data.SqlDbType.VarChar);
            maCommand.Parameters[1].Value = unArtiste.SiteWeb;
            maCommand.Parameters.Add("idCourant", System.Data.SqlDbType.Int);
            maCommand.Parameters[2].Value = unArtiste.UnCourant.Id;

            int nbLigne = (int)maCommand.ExecuteNonQuery();
            //on retourne le nombre d'enregistrement ajoutées
            //refermer la connection avant chaque return
            AccesBD.GetInstance().CloseConnection();
            return nbLigne;
            
        }
    }
}
