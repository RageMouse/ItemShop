using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;
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
            _auctionContext.AddAuction(new AuctionDTO(auction.DateCreated, auction.Sold, auction.EndDateTime, auction.MinPrice, auction.BuyoutPrice, auction.ItemId));
        }

        public Auction GetById(int id)
        {
            AuctionDTO auction = _auctionContext.GetById(id);

            return new Auction(auction.AuctionId, auction.DateCreated, auction.Sold, auction.EndDateTime, auction.MinPrice, auction.BuyoutPrice, auction.ItemId);
        }

        public void Update(Auction auction)
        {
            _auctionContext.Update(new AuctionDTO(auction.DateCreated, auction.Sold, auction.EndDateTime, auction.MinPrice, auction.BuyoutPrice, auction.ItemId));
        }

        internal Auction ConvertAuction(AuctionDTO auction)
        {
            return new Auction(auction.AuctionId, auction.DateCreated, auction.Sold, auction.EndDateTime, auction.MinPrice, auction.BuyoutPrice, auction.ItemId);
        }
    }
}
