﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneBO;
using System.Data.SqlClient;
using System.Data;

namespace GesCampagneDAL
{
    public class EmployeDAO
    {
        private static EmployeDAO uneInstanceEmployeDAO;

        public static EmployeDAO GetInstanceDAOPublic()
        {
            if (uneInstanceEmployeDAO == null)
            {
                uneInstanceEmployeDAO = new EmployeDAO();
            }
            return uneInstanceEmployeDAO;
        }



        /// <summary>
        /// Récupère une liste avec tous les employes.
        /// </summary>
        /// <returns>une list avec les employes</returns>
        public List<Employe> GetEmployes()
        {
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();

            List<Employe> lesEmployes = new List<Employe>();
            SqlCommand maCommand = new SqlCommand();

            maCommand.Connection = cnx;
            //maCommand.CommandType = CommandType.StoredProcedure;
            //maCommand.CommandText = "lenomdelaprocedure";
            maCommand.Parameters.Clear();
            maCommand.CommandText = "select * from Public";
            SqlDataReader monReader = maCommand.ExecuteReader();

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
