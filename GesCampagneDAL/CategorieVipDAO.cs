using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using GesCampagneBO;

namespace GesCampagneDAL
{
    class CategorieVipDAO
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

            SqlConnection cnx = access
        }
    }
}
