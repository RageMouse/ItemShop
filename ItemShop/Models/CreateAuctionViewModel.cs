using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemShop.Models
{
    public class CreateAuctionViewModel
    {
        public DateTime DateCreated { get; set; }
        public bool Sold { get; set; }
        public DateTime EndDateTime { get; set; }
        public int MinPrice { get; set; }
        public int BuyoutPrice { get; set; }
    }
}