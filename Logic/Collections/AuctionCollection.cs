using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.Interfaces;
using Logic.Interfaces;
using Logic.Models;

namespace Logic.Collections
{
    public class AuctionCollection : IAuctionCollection
    {
        private readonly IAuctionContext _auctionContext;

        public AuctionCollection(IAuctionContext context)
        {
            _auctionContext = context;
        }

        public void CreateAuction(Auction auction)
        {
            throw new NotImplementedException();
        }
    }
}
