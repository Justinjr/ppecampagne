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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uneCampagne">référence à campagne</param>
        /// <returns></returns>
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

            if (nbRet>0)
            {
                AccesBD.GetInstance().CloseConnection();
                return 0;
            }
            else
            {
                maCommand.Parameters.Clear();
                maCommand.CommandText = "insert into Client values(@intitule,@objectif,@dateDebut,@dateFin,@idPublic,@idEmploye)";
                maCommand.Parameters.Add("intitule", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[0].Value = uneCampagne.Intitule;
                maCommand.Parameters.Add("objectif", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[1].Value = uneCampagne.Objectif;
                maCommand.Parameters.Add("dateDebut", System.Data.SqlDbType.DateTime);
                maCommand.Parameters[2].Value = uneCampagne.DateDebut;
                maCommand.Parameters.Add("dateFin", System.Data.SqlDbType.DateTime);
                maCommand.Parameters[3].Value = uneCampagne.DateFin;
                maCommand.Parameters.Add("idPublic", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[4].Value = uneCampagne.IdPublic;
                maCommand.Parameters.Add("idEmploye", System.Data.SqlDbType.VarChar);
                maCommand.Parameters[5].Value = uneCampagne.IdEmploye;






            }








            
        }










    }
}
