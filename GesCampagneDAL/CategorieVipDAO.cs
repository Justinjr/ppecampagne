using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using GesCampagneBO;

namespace GesCampagneDAL
{
    public class CategorieVipDAO
    {
        private static CategorieVipDAO uneInstanceCategorieVipDAO;

        public static CategorieVipDAO GetInstanceCategorieVipDAO()
        {
            if (uneInstanceCategorieVipDAO == null)
            {
                uneInstanceCategorieVipDAO = new CategorieVipDAO();
            }
            return uneInstanceCategorieVipDAO;
        }
        public List<CategorieVip> GetCategoriesVip()
        {
            int idLu;
            string libelleLu;
            SqlDataReader monLecteur;

            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();
            List<CategorieVip> lesCategoriesVip = new List<CategorieVip>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "spSelectCategoriesVip";
            monLecteur = cmd.ExecuteReader();

            while(monLecteur.Read())
            {
                idLu = (int)monLecteur["id"];
                libelleLu = (string)monLecteur["libelle"];
                CategorieVip uneCategorieVip = new CategorieVip(idLu, libelleLu);
                lesCategoriesVip.Add(uneCategorieVip);
            }
            return lesCategoriesVip;
        }
    }

}
