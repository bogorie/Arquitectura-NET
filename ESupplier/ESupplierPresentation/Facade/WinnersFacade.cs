using ESupplierPresentation.Integration;
using ESupplierPresentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESupplierPresentation.Facade
{
    public class WinnersFacade
    {
        ProxyWinners proxy;

        public WinnersFacade()
        {
            proxy = new ProxyWinners();
        }

        public List<Winners> Index()
        {
            return proxy.GetWinners();
        }

    }
}