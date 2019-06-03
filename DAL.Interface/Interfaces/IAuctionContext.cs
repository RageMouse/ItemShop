using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;

namespace DAL.Interface.Interfaces
{
    public interface IAuctionContext
    {
        void AddAuction(AuctionDTO auction);
        AuctionDTO GetById(int id);
        void Update(AuctionDTO auction);
        List<AuctionDTO> GetAllAuctions();
    }
}
