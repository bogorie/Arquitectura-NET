using ESupplierPresentation.Integration;
using ESupplierPresentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESupplierPresentation.Facade
{
    public class QueryAuctionFacade
    {
        ProxyQueryAuction proxy;

        public QueryAuctionFacade()
        {
            proxy = new ProxyQueryAuction();
        }

        public List<Auction> Index()
        {
            return proxy.GetAuction();
        }

        public Auction getAuction(string startDate, string endDate)
        {
            return proxy.GetAuctionDetails(startDate, endDate);
        }

        public Auction query(Auction auction)
        {
            return proxy.query(auction);
        }

    }
}