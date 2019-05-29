using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;

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
