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
    public class ThemeDAO
    {
        private static ThemeDAO uneInstanceThemeDAO;

        public static ThemeDAO GetInstanceDAOTheme()
        {
            if (uneInstanceThemeDAO == null)

            {
                uneInstanceThemeDAO = new ThemeDAO();
            }
            return uneInstanceThemeDAO;
        }

        public List<Theme> GetThemes()
        {


            //on récup l'objet responsable de la connexion a la base
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

            //on creer la collection lesClients de type list<Client> qui va contenir les clients
            List<Theme> lesThemes = new List<Theme>();

            //crer objet de type sqlCommand
            SqlCommand maCommand = new SqlCommand();

            //execute la requete

            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spGetThemes";
            

            maCommand.Connection = cnx;
            SqlDataReader monReader = maCommand.ExecuteReader();
            while (monReader.Read())
            {
                int id = (int)monReader["id"];
                string libelle = (string)monReader["libelle"];


                lesThemes.Add(new Theme(id, libelle));

            }


            AccesBD.GetInstance().CloseConnection();
            return lesThemes;
        }
    }
}
