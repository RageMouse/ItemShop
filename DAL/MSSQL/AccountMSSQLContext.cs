using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.MSSQL
{
    public class AccountMSSQLContext : IAccountContext
    {
        public void CreateAccount(AccountDTO account)
        {
            using (SqlConnection con = Database.getConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("CreateAccount", con)
                { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@name", account.Name);
                    cmd.Parameters.AddWithValue("@password", account.Password);
                    cmd.Parameters.AddWithValue("@isgamemaster", account.Gamemaster);
                    cmd.Parameters.AddWithValue("@isactive", account.Active);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<AccountDTO> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public AccountDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
