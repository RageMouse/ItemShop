using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface.DTOs
{
    public struct AuctionDTO
    {
        public readonly int AuctionId;
        public readonly DateTime DateTime;
        public readonly bool Sold;
        public readonly DateTime EndDateTime;
        public readonly int MinPrice;
        public readonly int BuyoutPrice;
        public readonly int ItemId;

        public AuctionDTO(int auctionId, DateTime dateTime, bool sold, DateTime endDateTime, int minPrice, int buyoutPrice, int itemId)
        {
            AuctionId = auctionId;
            DateTime = dateTime;
            Sold = sold;
            EndDateTime = endDateTime;
            MinPrice = minPrice;
            BuyoutPrice = buyoutPrice;
            ItemId = itemId;
        }

        public AuctionDTO(DateTime dateTime, bool sold, DateTime endDateTime, int minPrice, int buyoutPrice, int itemId)
        {
            AuctionId = 0;
            DateTime = dateTime;
            Sold = sold;
            EndDateTime = endDateTime;
            MinPrice = minPrice;
            BuyoutPrice = buyoutPrice;
            ItemId = itemId;
        }
    }
}
