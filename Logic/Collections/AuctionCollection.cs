using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            _auctionContext.AddAuction(new AuctionDTO(auction.DateCreated, auction.Sold, auction.EndDateTime,
                auction.MinPrice, auction.BuyoutPrice, auction.ItemId));
        }

        public Auction GetById(int id)
        {
            AuctionDTO auction = _auctionContext.GetById(id);

            return new Auction(auction.AuctionId, auction.DateCreated, auction.Sold, auction.EndDateTime,
                auction.MinPrice, auction.BuyoutPrice, auction.ItemId);
        }

        public void Update(Auction auction)
        {
            _auctionContext.Update(new AuctionDTO(auction.DateCreated, auction.Sold, auction.EndDateTime,
                auction.MinPrice, auction.BuyoutPrice, auction.ItemId));
        }

        internal Auction ConvertAuction(AuctionDTO auction)
        {
            return new Auction(auction.AuctionId, auction.DateCreated, auction.Sold, auction.EndDateTime,
                auction.MinPrice, auction.BuyoutPrice, auction.ItemId);
        }

        public List<Auction> GetAllAuctions()
        {
            List<Auction> auctions = new List<Auction>();

            foreach (AuctionDTO auctionDto in _auctionContext.GetAllAuctions())
            {
                Auction auction = ConvertAuction(auctionDto);
                auctions.Add(auction);
            }

            return auctions;
        }

        public decimal SuggestPrice(Auction auction)
        {
            decimal averagePrice = _auctionContext.AverageSoldPrice();
            List<decimal> soldPricesList = _auctionContext.GetAllSoldPrices(auction.ItemId);
            //todo 
            decimal sumOfSquaresOfDifferences = soldPricesList.Select(val => (val - averagePrice) * (val - averagePrice)).Sum();
            //todo
            double standardDeviation = Math.Sqrt((double) (sumOfSquaresOfDifferences / soldPricesList.Count));

            int openAuctions = _auctionContext.OpenAuctions(auction.ItemId);

            switch (openAuctions)
            {
                    
            }
            /*
             * Bepalen wat de ranges zijn.
             * Switch
             * -3 = -x3 standardDeviation
             * -2 = -x2 standardDeviation
             * -1 = =x1 standardDeviation
             * 0 = neutraal = 1-5
             * 1 = x1 standardDeviation
             * 2 = x2 standardDeviation
             * 3 = x3 standardDeviation
             */

            decimal omega = 0;
            /*todo write algoritm
             *step 1: Gemiddelde verkoopsprijs van alle afgeronden met hetzelfde item berekenen.
             *step 2: Bereken standard deviatie van deze verkoopprijs.
             *step 3: Hoeveelheid open Auctions van hetzelfde item word optellen.
             *step 4: 5 categorieen van hoeveelheid open Auctions, heel weinig, weinig, neutraal, veel, heel veel.
             *step 5: Gemiddelde verkooprpijs van stap 1 verekenen met de categorieen uit step 4.
             */
            return omega;
        }
    }
}