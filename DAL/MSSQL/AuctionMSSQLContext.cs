using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.MSSQL
{
    public class AuctionMSSQLContext : IAuctionContext
    {
        private string _connString;

        public AuctionMSSQLContext(string connString)
        {
            _connString = connString;
        }

        public void AddAuction(AuctionDTO auction)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("CreateAuction", conn)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        cmd.Parameters.AddWithValue("@dateCreated", auction.DateCreated);
                        cmd.Parameters.AddWithValue("@sold", auction.Sold);
                        cmd.Parameters.AddWithValue("@minPrice", auction.MinPrice);
                        cmd.Parameters.AddWithValue("@buyoutPrice", auction.BuyoutPrice);
                        cmd.Parameters.AddWithValue("@itemId", auction.ItemId);

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

        public AuctionDTO GetById(int id)
        {
            List<AuctionDTO> auctions = new List<AuctionDTO>();
            try
            {
                AuctionDTO auction;
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetAccountById", conn)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        cmd.Parameters.AddWithValue("@accountId", id);


                        using (var reader = cmd.ExecuteReader())
                        {
                            foreach (DbDataRecord record in reader)
                            {
                                auction = new AuctionDTO(
                                    record.GetInt32(record.GetOrdinal("AuctionId")),
                                    record.GetDateTime(record.GetOrdinal("DateCreated")),
                                    record.GetBoolean(record.GetOrdinal("Sold")),
                                    record.GetDateTime(record.GetOrdinal("MinPrice")),
                                    record.GetInt32(record.GetOrdinal("BuyoutPrice")),
                                    record.GetInt32(record.GetOrdinal("Item_Id")),
                                    record.GetInt32(record.GetOrdinal("Active"))
                                );
                                auctions.Add(auction);
                            }
                        }
                    }
                }

                auction = auctions.Single(u => u.AuctionId == id);
                return auction;
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
                throw;
            }
        }

        public void Update(AuctionDTO auction)
        {
            throw new NotImplementedException();
        }

        public List<AuctionDTO> GetAllAuctions()
        {
            throw new NotImplementedException();
        }

        public decimal AverageSoldPrice()
        {
            try
            {
                decimal averagePrice = 0;
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("GetAveragePrice", conn)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        foreach (DbDataRecord record in command.ExecuteReader())
                        {
                            averagePrice = (record.GetDecimal(record.GetOrdinal("AveragePrice")));
                        }
                    }
                }

                return averagePrice;
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
                throw;
            }
        }

        public List<decimal> GetAllSoldPrices(int id)
        {
            try
            {
                List<decimal> soldPrices = new List<decimal>();
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("GetAllSoldPrices", conn)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        command.Parameters.AddWithValue("@item_Id", id);

                        foreach (DbDataRecord record in command.ExecuteReader())
                        {
                            soldPrices.Add(record.GetDecimal(record.GetOrdinal("BuyoutPrice")));
                        }

                        ;
                    }
                }

                return soldPrices;
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
                throw;
            }
        }

        public int OpenAuctions(int id)
        {
            try
            {
                int openAuctions = 0;
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("OpenAuctions", conn)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        command.Parameters.AddWithValue("@item_Id", id);

                        foreach (DbDataRecord record in command.ExecuteReader())
                        {
                            openAuctions++;
                        }

                        ;
                    }
                }

                return openAuctions;
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
                throw;
            }
        }
    }
}