using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Auction
    {
        public int AuctionId { get; }
        public DateTime DateCreated { get; }
        public bool Sold { get; }
        public DateTime EndDateTime { get; }
        public int MinPrice { get; }
        public int BuyoutPrice { get; }

        public Auction(int auctionId, DateTime dateCreated, bool sold, DateTime endDateTime, int minPrice, int buyoutPrice)
        {
            AuctionId = auctionId;
            DateCreated = dateCreated;
            Sold = sold;
            EndDateTime = endDateTime;
            MinPrice = minPrice;
            BuyoutPrice = buyoutPrice;
        }
    }
}