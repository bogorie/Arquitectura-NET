using ESupplierPresentation.Facade;
using ESupplierPresentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ESupplierPresentation.Views
{
    public class AuctionController : Controller
    {
        private QueryAuctionFacade facade;

        /*public String startDate;
        public String endDate;
        public bool isRest;*/

        // GET: Auction
        public ActionResult Index()
        {
            //return View(facade.Index(startDate, endDate));
            return View();
        }

        // GET: Auction/Details/startDate/endDate
        public ActionResult Details(String startDate, String endDate)
        {
            if (startDate == null || endDate == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auction auction = facade.getAuction(startDate, endDate);
            if (auction == null)
            {
                return HttpNotFound();
            }
            return View(auction);
        }

        // Auction/Query
        public ActionResult Query([Bind(Include = "startDate, closeDate, isRest")] Auction auction)
        {
            //"Details", facade.query(auction)
            return View();
        }

    }
}
