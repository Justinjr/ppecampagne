using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace GesClientDAL
{
    public class AccesBD
    {
        private SqlConnection objConnex;
        private static AccesBD uneInstance;
        private string laChaineConnexion;

        //retourne la chaine de connexion
        public string getChaine()
        {
            return laChaineConnexion;
        }

        //renseigne la chaine de connexion
        public void SetChaine(string laChaine)
        {
            laChaineConnexion = laChaine;
        }

        //methode s'appelle un singleton
        //cree un obj instance de la classe accesbd
        //s'il n'existe pas puis retourn la référence à cet objet
        public static AccesBD getInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AccesBD();
            }
            return uneInstance;
        }

        //constructeur de accesbd est privé
        //seul la classe accesbd puisse créer un objet de la classe,comme le constructeur de la classe est privé 
        //, il ne pourra pas appelé en dehors de la classe accesbd, cela signifie donc qu'un objet de la classe ne pourra pas etre créer ailleurs
        private AccesBD()
        {

        }

        //cette methode permet d'obtenir l'objet responsable de la connexion a la bdd
        public SqlConnection getSqlConnexion()
        {
            //on cree un objet responsable de la connexion a la bd
            if (objConnex == null)
            {
                objConnex = new SqlConnection();
            }
            //renseigne la chaine de connexion de l'objet responsable 
            //de la connexion a la bd
            objConnex.ConnectionString = laChaineConnexion;

            //on ouvre la connexion si elle est fermée
            if (objConnex.State == System.Data.ConnectionState.Closed)
            {
                objConnex.Open();
            }
            return objConnex;
        }

        public void CloseConnection()
        {
            if (this.objConnex != null && this.objConnex.State != System.Data.ConnectionState.Closed)
            {
                this.objConnex.Close();
            }
        }
    }
}
