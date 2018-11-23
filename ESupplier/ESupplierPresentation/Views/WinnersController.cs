using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ESupplierPresentation.Facade;
using ESupplierPresentation.Models;

namespace ESupplierPresentation.Views
{
    public class WinnersController : Controller
    {
        private WinnersFacade facade;

        public WinnersController()
        {
            facade = new WinnersFacade();
        }

        // GET: Winners
        public ActionResult Index()
        {
            return View(facade.Index());
        }
    }
}
