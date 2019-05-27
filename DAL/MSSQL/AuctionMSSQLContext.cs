using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.MSSQL
{
    public class AuctionMSSQLContext : IAuctionContext
    {
        public void CreateAuction(AuctionDTO auction)
        {
            throw new NotImplementedException();
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
