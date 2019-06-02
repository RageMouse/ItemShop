using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.MSSQL
{
    public class AuctionMSSQLContext : IAuctionContext
    {
        public void AddAuction(AuctionDTO auction)
        {
            try
            {
                using (SqlConnection con = Database.getConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("CreateAuction", con)
                        { CommandType = CommandType.StoredProcedure })
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
            throw new NotImplementedException();
        }

        public void Update(AuctionDTO auction)
        {
            throw new NotImplementedException();
        }
    }
}
