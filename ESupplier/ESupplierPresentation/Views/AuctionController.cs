using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESupplierPresentation.Views
{
    public class AuctionController : Controller
    {
        public String startDate;
        public String endDate;
        public bool isRest;

        // GET: Auction
        public ActionResult Index()
        {
            return View();
        }

        // GET: Auction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Query()
        {
            return View();
        }

    }
}
