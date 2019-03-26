using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class Database
    {
        private static readonly ConnectionStringBuilder ConnectionStringBuilder = new ConnectionStringBuilder();

        public static SqlConnection getConnection()
        {
            return ConnectionStringBuilder.GetConnection();
        }   
    }
}
