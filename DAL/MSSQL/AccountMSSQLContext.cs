using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.MSSQL
{
    public class AccountMSSQLContext : IAccountContext
    {
        public void CreateAccount(AccountDTO account)
        {
            try
            {
                using (SqlConnection con = Database.getConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("CreateAccount", con)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        cmd.Parameters.AddWithValue("@name", account.Name);
                        cmd.Parameters.AddWithValue("@password", account.Password);
                        cmd.Parameters.AddWithValue("@isactive", account.Active);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
                throw;
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
                //todo a good exception
                Console.WriteLine(e);
                throw;
            }
        }

        public AccountDTO GetById(int id)
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            try
            {
                AccountDTO account;
                using (SqlConnection con = Database.getConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("GetAccountById", con)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        cmd.Parameters.AddWithValue("@accountId", id);


                        using (var reader = cmd.ExecuteReader())
                        {
                            foreach (DbDataRecord record in reader)
                            {
                                account = new AccountDTO(
                                    record.GetInt32(record.GetOrdinal("AccountId")),
                                    record.GetString(record.GetOrdinal("Name")),
                                    record.GetString(record.GetOrdinal("Password")),
                                    record.GetBoolean(record.GetOrdinal("Active"))
                                );
                                accounts.Add(account);
                            }
                        }
                    }
                }

                account = accounts.Single(u => u.AccountId == id);
                return account;
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
                throw;
            }
        }

        public void RemoveAccount(AccountDTO account)
        {
            throw new NotImplementedException();
        }

        public void Update(AccountDTO account)
        {
            try
            {
                using (SqlConnection con = Database.getConnection())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("UpdateAccount", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("AccountId", account.AccountId);
                        command.Parameters.AddWithValue("Name", account.Name);
                        command.Parameters.AddWithValue("Password", account.Password);
                        command.Parameters.AddWithValue("Active", account.Active);
                        command.ExecuteNonQuery();
                    }

                    con.Close();
                }
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
            }
        }
    }
}