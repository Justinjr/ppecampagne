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


        //public List<Campagne> GetCampagne()
        //{
        //    SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

        //    List<Campagne> lesCampagnes = new List<Campagne>();
        //    SqlCommand maCommand = new SqlCommand();

        //    maCommand.Connection = cnx;
        //    //maCommand.CommandType = CommandType.StoredProcedure;
        //    //maCommand.CommandText = "lenomdelaprocedure";
        //    //maCommand.CommandText = "select * from Campagne";
        //    SqlDataReader monReader = maCommand.ExecuteReader();

        //    while (monReader.Read())
        //    {

        //    }

        //    AccesBD.GetInstance().CloseConnection();
        //    return lesCampagnes;
        //}

        public int AjoutCampagne(Campagne uneCampagne)
        {
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();
            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            //maCommand.CommandType = CommandType.StoredProcedure;
            //maCommand.CommandText = "lenomdelaprocedure";
            maCommand.CommandText = "";


            maCommand.Parameters.Clear();












            
        }










    }
}
