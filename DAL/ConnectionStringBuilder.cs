using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class ConnectionStringBuilder
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection("Server=mssql.fhict.local;Database=dbi387022;User Id=dbi387022;Password=wachtwoord");
        }
    }
}
