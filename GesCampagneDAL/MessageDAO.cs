using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneBO;
using System.Data;
using System.Data.SqlClient;

namespace GesCampagneDAL
{
    public class MessageDAO
    {
        private static MessageDAO uneInstanceMessageDAO;

        public static MessageDAO GetInstanceDAOMessage()
        {
            if (uneInstanceMessageDAO == null)
            {
                uneInstanceMessageDAO = new MessageDAO();
            }
            return uneInstanceMessageDAO;
        }
        public int AjoutMessage(Message unMessage)
        {
            SqlConnection cnx = AccesBD.GetInstance().GetSqlConnexion();
            SqlCommand maCommand = new SqlCommand();

            //maCommand.CommandType = CommandType.StoredProcedure;
            //maCommand.CommandText = "nomProc";

            maCommand.Parameters.Clear
        }
    }
}
