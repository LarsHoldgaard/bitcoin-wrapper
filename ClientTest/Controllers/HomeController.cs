using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitcoinWrapper.Wrapper;

namespace ClientTest.Controllers
{
    public class HomeController : Controller
    {
        private BaseBtcConnector _baseBtcConnector;
        //
        // GET: /Home/

        public HomeController()
        {
            this._baseBtcConnector =  new BaseBtcConnector();;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public float GetBalanceInWallet()
        {
            var service = _baseBtcConnector.GetBalance();
            return service;
        }
    }
}
