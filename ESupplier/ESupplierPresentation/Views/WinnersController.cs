using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ESupplierPresentation.consumeWCF;
using ESupplierPresentation.Facade;
using ESupplierPresentation.Models;

namespace ESupplierPresentation.Views
{
    public class WinnersController : Controller
    {
        private WinnersFacade facade;
        private consumeWCF.ServicioWCFClient consumidorwcf = new consumeWCF.ServicioWCFClient();



        public WinnersController()
        {
            facade = new WinnersFacade();
        }

        // GET: Winners
        public ActionResult Index()
        {
            WINNERS ganador = new WINNERS();
            ganador.NAME = "RIE";
            ganador.TYPE = "TIPO";
            ganador.DOCUMENT = 1;

            consumidorwcf.PostWINNERS(ganador);
            return View(facade.Index());
        }
    }
}
