using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.Memory
{
    public class AuctionMemoryContext : IAuctionContext
    {
        public readonly List<AuctionDTO> _auctions = new List<AuctionDTO>();

        public void AddAuction(AuctionDTO auctionDto)
        {
            _auctions.Add(auctionDto);
        }

        public AuctionDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AuctionDTO auction)
        {
            throw new NotImplementedException();
        }

        public List<AuctionDTO> GetAllAuctions()
        {
            throw new NotImplementedException();
        }
    }
}
