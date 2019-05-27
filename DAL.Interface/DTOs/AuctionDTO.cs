using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface.DTOs
{
    public struct AuctionDTO
    {
        public readonly int AuctionId;
        public readonly DateTime DateCreated;
        public readonly bool Sold;
        public readonly DateTime EndDateTime;
        public readonly int MinPrice;
        public readonly int BuyoutPrice;
        public readonly int ItemId;

        public AuctionDTO(int auctionId, DateTime dateCreated, bool sold, DateTime endDateTime, int minPrice, int buyoutPrice, int itemId)
        {
            AuctionId = auctionId;
            DateCreated = dateCreated;
            Sold = sold;
            EndDateTime = endDateTime;
            MinPrice = minPrice;
            BuyoutPrice = buyoutPrice;
            ItemId = itemId;
        }

        public AuctionDTO(DateTime dateCreated, bool sold, DateTime endDateTime, int minPrice, int buyoutPrice, int itemId)
        {
            AuctionId = 0;
            DateCreated = dateCreated;
            Sold = sold;
            EndDateTime = endDateTime;
            MinPrice = minPrice;
            BuyoutPrice = buyoutPrice;
            ItemId = itemId;
        }
    }
}
