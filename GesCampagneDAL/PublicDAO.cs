﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneBO;
using System.Data.SqlClient;
using System.Data;

namespace GesCampagneDAL
{
    public class PublicDAO
    {
        private static PublicDAO uneInstancePublicDAO;

        public static PublicDAO GetInstanceDAOPublic()
        {
            if (uneInstancePublicDAO == null)
            {
                uneInstancePublicDAO = new PublicDAO();
            }
            return uneInstancePublicDAO;
        }



        /// <summary>
        /// Récupère une liste avec tous les publics.
        /// </summary>
        /// <returns>une list avec les publics</returns>
        public List<Public> GetPublics()
        {
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

            List<Public> lesPublics = new List<Public>();
            SqlCommand maCommand = new SqlCommand();

            maCommand.Connection = cnx;
            maCommand.CommandText = "select * from PublicConcerne";
            SqlDataReader monReader = maCommand.ExecuteReader();

            lesPublics.Add(new Public(0, "Veuillez saisir un public"));
            while (monReader.Read())
            {
                int unId = (int)monReader["id"];
                string unLibelle = (string)monReader["libelle"];
                lesPublics.Add(new Public(unId, unLibelle));
            }

            AccesBD.GetInstance().CloseConnection();
            return lesPublics;
        }


    }
}
