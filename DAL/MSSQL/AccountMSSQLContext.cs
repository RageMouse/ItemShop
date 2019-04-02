using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Data.Common;
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
                    {CommandType = CommandType.StoredProcedure})
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
            List<AccountDTO> accounts = new List<AccountDTO>();
            try
            {
                using (SqlConnection con = Database.getConnection())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("ShowAllAccounts", con)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        foreach (DbDataRecord record in command.ExecuteReader())
                        {
                            AccountDTO character = new AccountDTO(
                                record.GetInt32(record.GetOrdinal("AccountId")),
                                record.GetString(record.GetOrdinal("Name")),
                                record.GetString(record.GetOrdinal("Password")),
                                record.GetBoolean(record.GetOrdinal("Gamemaster")),
                                record.GetBoolean(record.GetOrdinal("Active"))
                            );
                            accounts.Add(character);
                        }

                        con.Close();
                    }
                }

                return accounts;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public AccountDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveAccount(AccountDTO account)
        {
            throw new NotImplementedException();
        }
    }
}