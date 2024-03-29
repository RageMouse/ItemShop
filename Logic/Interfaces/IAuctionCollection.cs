﻿using System;
using System.Collections.Generic;
using System.Text;
using Logic.Models;

namespace Logic.Interfaces
{
    public interface IAuctionCollection
    {
        void CreateAuction(Auction auction);
        Auction GetById(int id);
        void Update(Auction auction);
    }
}
